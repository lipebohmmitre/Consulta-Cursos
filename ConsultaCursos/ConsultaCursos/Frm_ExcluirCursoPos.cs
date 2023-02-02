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
    public partial class Frm_ExcluirCursoPos : Form
    {
        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;uid=root;pwd=@Faculdade2022;database=db_cursos";

        private string id;
        private string nomeCurso;
        private string periodo;
        private string cargaHorariaCurso;

        public Frm_ExcluirCursoPos()
        {
            InitializeComponent();

            Lv_exibeCurso.View = View.Details;
            Lv_exibeCurso.LabelEdit = true;
            Lv_exibeCurso.AllowColumnReorder = true;
            Lv_exibeCurso.FullRowSelect = true;
            Lv_exibeCurso.GridLines = true;

            Lv_exibeCurso.Columns.Add("ID", 30, HorizontalAlignment.Left);
            Lv_exibeCurso.Columns.Add("Nome Curso", 470, HorizontalAlignment.Left);
            Lv_exibeCurso.Columns.Add("Período", 150, HorizontalAlignment.Center);
            Lv_exibeCurso.Columns.Add("Carga Horária", 90, HorizontalAlignment.Right);
        }

        private void Btn_procurar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var buscaLike = new MySqlCommand($"SELECT id_cursos, nome_curso, nome_periodo, carga_horaria FROM tb_cursos A INNER JOIN tb_periodo B ON A.id_periodo = B.id_periodo WHERE nome_curso = '{Txb_procurarCurso.Text}' AND A.id_periodo = 2", conexao);
                var reader = buscaLike.ExecuteReader();

                Lv_exibeCurso.Items.Clear();
                Lbl_mostraIdCurso.Text = "";
                Lbl_mostraNomeCurso.Text = "";
                Lbl_mostraPeriodoCurso.Text = "";
                Lbl_mostraCargaHoraria.Text = "";

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
                    //var linha_id = row[0];
                    id = row[0].ToString();
                    nomeCurso = row[1].ToString();
                    periodo = row[2].ToString();
                    cargaHorariaCurso = row[3].ToString();

                    Lv_exibeCurso.Items.Add(linha_listView);
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algou deu errado: " + ex.Message);
            }
        }

        private void Lv_exibeCurso_DoubleClick(object sender, EventArgs e)
        {
            Lbl_mostraIdCurso.Text = id;
            Lbl_mostraNomeCurso.Text = nomeCurso;
            Lbl_mostraPeriodoCurso.Text = periodo;
            Lbl_mostraCargaHoraria.Text = cargaHorariaCurso;
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var excluirCursoPos = new MySqlCommand($"DELETE FROM tb_cursos WHERE id_cursos = {id};", conexao);
                excluirCursoPos.ExecuteReader();
                MessageBox.Show("Curso Apagado com Sucesso!!!");
                conexao.Close();
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
