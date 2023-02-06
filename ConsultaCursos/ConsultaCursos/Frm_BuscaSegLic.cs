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
    public partial class Frm_BuscaSegLic : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=192.168.0.50;Port=3306;uid=root;pwd=@Faculdade2022;database=db_cursos";


        public Frm_BuscaSegLic()
        {
            InitializeComponent();

            Lv_exibirCursosSegLic.View = View.Details;
            Lv_exibirCursosSegLic.LabelEdit = true;
            Lv_exibirCursosSegLic.AllowColumnReorder = true;
            Lv_exibirCursosSegLic.FullRowSelect = true;
            Lv_exibirCursosSegLic.GridLines = true;

            Lv_exibirCursosSegLic.Columns.Add("Nome Curso",200, HorizontalAlignment.Left);
            Lv_exibirCursosSegLic.Columns.Add("Período", 150, HorizontalAlignment.Center);
            Lv_exibirCursosSegLic.Columns.Add("Carga Horária", 150, HorizontalAlignment.Right);
        }

        private void Btn_fecharSegLic_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_buscarCursosSegLic_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var buscaLike = new MySqlCommand($"SELECT nome_curso, nome_periodo, carga_horaria FROM tb_cursos A INNER JOIN tb_periodo B ON A.id_periodo = 3 AND B.id_periodo = 3 WHERE nome_curso LIKE '%{Txt_buscarSegLic.Text}%'", conexao);

                var reader = buscaLike.ExecuteReader();

                Lv_exibirCursosSegLic.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                    };
                    var linha_listView = new ListViewItem(row);

                    Lv_exibirCursosSegLic.Items.Add(linha_listView);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algou deu errado: " + ex.Message);
            }
        }
    }
}
