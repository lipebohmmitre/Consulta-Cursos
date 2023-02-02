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
    public partial class Frm_AlterarCursoSegLic : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;uid=root;pwd=@Faculdade2022;database=db_cursos";

        private string id;
        private string nomeCurso;
        private string periodo;
        private string cargaHorariaCurso;

        public Frm_AlterarCursoSegLic()
        {
            InitializeComponent();

            Lv_exibirAlterarCurso.View = View.Details;
            Lv_exibirAlterarCurso.LabelEdit = true;
            Lv_exibirAlterarCurso.AllowColumnReorder = true;
            Lv_exibirAlterarCurso.FullRowSelect = true;
            Lv_exibirAlterarCurso.GridLines = true;

            Lv_exibirAlterarCurso.Columns.Add("ID", 30, HorizontalAlignment.Left);
            Lv_exibirAlterarCurso.Columns.Add("Nome Curso", 470, HorizontalAlignment.Left);
            Lv_exibirAlterarCurso.Columns.Add("Período", 150, HorizontalAlignment.Center);
            Lv_exibirAlterarCurso.Columns.Add("Carga Horária", 90, HorizontalAlignment.Right);
        }

        private void Frm_AlterarCursoSegLic_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Lv_exibirAlterarCurso_DoubleClick(object sender, EventArgs e)
        {
            Lbl_ExibeId.Text = id;
            Txb_nomeCursoAlterar.Text = nomeCurso;
            Lbl_periodo.Text = periodo;
            Txb_cargaHorariaAlterar.Text = cargaHorariaCurso;
        }

        private void Btn_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_procurarCursoAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var buscaLike = new MySqlCommand($"SELECT id_cursos, nome_curso, nome_periodo, carga_horaria FROM tb_cursos A INNER JOIN tb_periodo B ON A.id_periodo = B.id_periodo WHERE nome_curso = '{Txt_procurarCurso.Text}' AND A.id_periodo = 3", conexao);
                var reader = buscaLike.ExecuteReader();

                Lv_exibirAlterarCurso.Items.Clear();
                Txb_cargaHorariaAlterar.Text = "";
                Txb_nomeCursoAlterar.Text = "";
                Lbl_ExibeId.Text = "";
                Lbl_periodo.Text = "";

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

                    Lv_exibirAlterarCurso.Items.Add(linha_listView);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algou deu errado: " + ex.Message);
            }
        }

        private void Btn_alterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Txb_nomeCursoAlterar.Text != "" && Txb_cargaHorariaAlterar.Text != "")
                {
                    conexao = new MySqlConnection(stringConexao);
                    conexao.Open();

                    var consultaCursoExistente = new MySqlCommand($"SELECT COUNT(1) FROM tb_cursos WHERE nome_curso = '{Txb_nomeCursoAlterar.Text}' AND id_periodo = 3;", conexao);
                    var result = consultaCursoExistente.ExecuteScalar();
                    if (result != null)
                    {
                        if (Convert.ToInt64(result) >= 1)
                        {
                            MessageBox.Show("Este Curso já Existe, Favor cadastrar um novo Curso.");
                        }
                        else
                        {
                            var updateCursoPos = new MySqlCommand($"UPDATE tb_cursos SET nome_curso = '{Txb_nomeCursoAlterar.Text}', carga_horaria = {Txb_cargaHorariaAlterar.Text} WHERE id_cursos = {id} AND id_periodo = 3;", conexao);
                            updateCursoPos.ExecuteReader();
                            MessageBox.Show("Curso atualizado com Sucesso!!!");
                            conexao.Close();
                        }
                    }
                }
                else
                    MessageBox.Show("Por Favor Digite nos Campos para Alterar o Curso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
