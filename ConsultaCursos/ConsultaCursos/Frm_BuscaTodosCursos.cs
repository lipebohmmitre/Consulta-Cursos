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
    public partial class Frm_BuscaTodosCursos : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;uid=root;pwd=@Faculdade2022;database=db_cursos";

        public Frm_BuscaTodosCursos()
        {
            InitializeComponent();

            Lv_exibeTodosCursos.View = View.Details;
            Lv_exibeTodosCursos.LabelEdit = true;
            Lv_exibeTodosCursos.AllowColumnReorder = true;
            Lv_exibeTodosCursos.FullRowSelect = true;
            Lv_exibeTodosCursos.GridLines = true;

            Lv_exibeTodosCursos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            Lv_exibeTodosCursos.Columns.Add("Nome Curso", 500, HorizontalAlignment.Left);
            Lv_exibeTodosCursos.Columns.Add("Período", 150, HorizontalAlignment.Center);
            Lv_exibeTodosCursos.Columns.Add("Carga Horária", 100, HorizontalAlignment.Right);
        }

        private void Btn_procurarTodosCursos_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var buscaLike = new MySqlCommand($"SELECT id_cursos, nome_curso, nome_periodo, carga_horaria FROM tb_cursos A INNER JOIN tb_periodo B ON A.id_periodo = B.id_periodo WHERE nome_curso LIKE '%{Txt_buscaTodosCursos.Text}%'", conexao);

                var reader = buscaLike.ExecuteReader();

                Lv_exibeTodosCursos.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {   
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    var linha_listView = new ListViewItem(row);
                    var id = new ListViewItem(row[0]);

                    Lv_exibeTodosCursos.Items.Add(linha_listView);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algou deu errado: " + ex.Message);
            }
        }

        private void Btn_fecharTodosCursos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            Frm_AlterarCurso FormAltCurso = new Frm_AlterarCurso();
            FormAltCurso.ShowDialog();
        }
    }
}
