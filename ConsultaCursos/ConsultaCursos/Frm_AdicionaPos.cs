using MySql.Data.MySqlClient;
using Mysqlx.Connection;
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
    public partial class Frm_AdicionaPos : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;uid=root;pwd=@Faculdade2022;database=db_cursos";

        public Frm_AdicionaPos()
        {
            InitializeComponent();
            }

        private void Btn_salvarPos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txb_adicionaPos.Text != "" && Txb_adicionaCargaHorariaPos.Text != "")
                {
                    conexao = new MySqlConnection(stringConexao);
                    conexao.Open();

                    var consultaCursoExistente = new MySqlCommand($"SELECT COUNT(1) FROM tb_cursos WHERE nome_curso = '{Txb_adicionaPos.Text}';", conexao);
                    var result = consultaCursoExistente.ExecuteScalar();
                    if (result != null)
                    {
                        if (Convert.ToInt64(result) >= 1)
                            MessageBox.Show("Este Curso já Existe, Favor cadastrar um novo Curso.");
                        else
                        {
                            var insertBd = new MySqlCommand($"INSERT INTO tb_cursos(nome_curso, id_periodo, carga_horaria) VALUES ('{Txb_adicionaPos.Text}', 2, {Txb_adicionaCargaHorariaPos.Text});", conexao);
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
            catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado: " + ex.Message);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
