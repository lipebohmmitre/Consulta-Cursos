using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCursos
{
    public partial class Frm_AdicionaSegLic : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=192.168.0.50;Port=3306;uid=root;pwd=@Faculdade2022;database=db_cursos";

        public Frm_AdicionaSegLic()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salvarCursoSegLic_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Txt_adicionarCursoSegLic.Text != "" && Txt_AdicionarCargaHorariaSegLic.Text != "")
                {
                    conexao = new MySqlConnection(stringConexao);
                    conexao.Open();

                    var consultaCursoExistente = new MySqlCommand($"SELECT COUNT(1) FROM tb_cursos WHERE nome_curso = '{Txt_adicionarCursoSegLic.Text}';", conexao);
                    var result = consultaCursoExistente.ExecuteScalar();
                    if (result != null)
                    {
                        if (Convert.ToInt64(result) >= 1)
                            MessageBox.Show("Este Curso já Existe, Favor cadastrar um novo Curso.");
                        else
                        {
                            var insertBd = new MySqlCommand($"INSERT INTO tb_cursos(nome_curso, id_periodo, carga_horaria) VALUES ('{Txt_adicionarCursoSegLic.Text}', 3, {Txt_AdicionarCargaHorariaSegLic.Text});", conexao);
                            insertBd.ExecuteReader();
                            MessageBox.Show("Curso Cadastrado com Sucesso!!!");
                            conexao.Close();
                        }
                    }
                    conexao.Close();
                }
                else
                    MessageBox.Show("Por Favor, digite os dados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado: " + ex.Message);
            }
        }
    }
}
