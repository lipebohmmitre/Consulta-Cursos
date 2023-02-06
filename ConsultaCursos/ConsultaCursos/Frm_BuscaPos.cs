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
    public partial class Frm_BuscaPos : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=192.168.0.50;Port=3306;uid=root;pwd=@Faculdade2022;database=db_cursos";

        public Frm_BuscaPos()
        {
            InitializeComponent();

            Lv_exibirCursosPos.View = View.Details;
            Lv_exibirCursosPos.LabelEdit = true;
            Lv_exibirCursosPos.AllowColumnReorder = true;
            Lv_exibirCursosPos.FullRowSelect = true;
            Lv_exibirCursosPos.GridLines = true;

            Lv_exibirCursosPos.Columns.Add("Nome Curso", 500, HorizontalAlignment.Left);
            Lv_exibirCursosPos.Columns.Add("Período", 100, HorizontalAlignment.Center);
            Lv_exibirCursosPos.Columns.Add("Carga Horária", 150, HorizontalAlignment.Right);
        }

        private void Frm_BuscaPos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_fecharPos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_buscarCursosPos_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var buscaLike = new MySqlCommand($"SELECT nome_curso, nome_periodo, carga_horaria FROM tb_cursos A INNER JOIN tb_periodo B ON A.id_periodo = 2 AND B.id_periodo = 2 WHERE nome_curso LIKE '%{Txt_bucarPos.Text}%'", conexao);

                var reader = buscaLike.ExecuteReader();

                Lv_exibirCursosPos.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                    };
                    var linha_listView = new ListViewItem(row);

                    Lv_exibirCursosPos.Items.Add(linha_listView);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algou deu errado: " + ex.Message);
            }
        }
    }
}
