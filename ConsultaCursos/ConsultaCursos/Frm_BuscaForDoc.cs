using MySql.Data.MySqlClient;

namespace ConsultaCursos
{
    public partial class Frm_BuscarForDoc : Form
    {

        private MySqlConnection conexao;
        private string stringConexao = "server=localhost;uid=root;pwd=@Faculdade2022;database=db_cursos";

        public Frm_BuscarForDoc()
        {
            InitializeComponent();

            Lv_ExibirCursos.View = View.Details;
            Lv_ExibirCursos.LabelEdit = true;
            Lv_ExibirCursos.AllowColumnReorder = true;
            Lv_ExibirCursos.FullRowSelect = true;
            Lv_ExibirCursos.GridLines = true;

            Lv_ExibirCursos.Columns.Add("Nome Curso", 250, HorizontalAlignment.Left);
            Lv_ExibirCursos.Columns.Add("Período", 100, HorizontalAlignment.Center);
            Lv_ExibirCursos.Columns.Add("Carga Horária", 150, HorizontalAlignment.Right);
        }
        
        private void Frm_Index_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_BuscarCursos_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                var buscaLike = new MySqlCommand($"SELECT nome_curso, nome_periodo, carga_horaria FROM tb_cursos A INNER JOIN tb_periodo B ON A.id_periodo = 1 AND B.id_periodo = 1 WHERE nome_curso LIKE '%{Txt_Buscar.Text}%'", conexao);

                var reader = buscaLike.ExecuteReader();

                Lv_ExibirCursos.Items.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                    };
                    var linha_listView = new ListViewItem(row);
                  
                    Lv_ExibirCursos.Items.Add(linha_listView);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algou deu errado: " + ex.Message);
            }
        }

        private void Btn_FecharForDoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}