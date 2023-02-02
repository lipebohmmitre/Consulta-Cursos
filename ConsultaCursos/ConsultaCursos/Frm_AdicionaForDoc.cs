using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Frm_AdicionaForDoc : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;uid=root;pwd=@Faculdade2022;database=db_cursos";

        public Frm_AdicionaForDoc()
        {
            InitializeComponent();
        }

        private void Btn_salvarForDoc_Click(object sender, EventArgs e)
        {
             try
             {
                if (Txt_adicionaCursoForDoc.Text != "" && Txt_adicionaCargaHorariaForDoc.Text != "")
                {
                    conexao = new MySqlConnection(stringConexao);
                    conexao.Open();

                    var consultaCursoExistente = new MySqlCommand($"SELECT COUNT(1) FROM tb_cursos WHERE nome_curso = '{Txt_adicionaCursoForDoc.Text}';", conexao);
                    var result = consultaCursoExistente.ExecuteScalar();
                    if (result != null)
                    {
                        if (Convert.ToInt64(result) >= 1)
                            MessageBox.Show("Este Curso já Existe, Favor cadastrar um novo Curso.");
                        else
                        {
                            var insertBd = new MySqlCommand($"INSERT INTO tb_cursos(nome_curso, id_periodo, carga_horaria) VALUES ('{Txt_adicionaCursoForDoc.Text}', 1, {Txt_adicionaCargaHorariaForDoc.Text});", conexao);
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

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
