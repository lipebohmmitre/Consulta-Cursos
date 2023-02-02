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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_procurarCursosPos_Click(object sender, EventArgs e)
        {
            Frm_BuscaPos formPos = new Frm_BuscaPos();
            formPos.ShowDialog();
        }

        private void Btn_procurarCursosFordoc_Click(object sender, EventArgs e)
        {
            Frm_BuscarForDoc formForDoc = new Frm_BuscarForDoc();
            formForDoc.ShowDialog();
        }

        private void Btn_procurarCursosSegLic_Click(object sender, EventArgs e)
        {
            Frm_BuscaSegLic formSegLic = new Frm_BuscaSegLic();
            formSegLic.ShowDialog();
        }

        private void Btn_procurarCursosTodos_Click(object sender, EventArgs e)
        {
            Frm_BuscaTodosCursos formTodosCursos = new Frm_BuscaTodosCursos();
            formTodosCursos.ShowDialog();
        }

        private void Btn_FecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_adicionarcursosFordoc_Click(object sender, EventArgs e)
        {
            Frm_AdicionaPos formAddPos = new Frm_AdicionaPos();
            formAddPos.ShowDialog();
        }

        private void Btn_adicionarCursoForDoc_Click(object sender, EventArgs e)
        {
            Frm_AdicionaForDoc formForDoc = new Frm_AdicionaForDoc();
            formForDoc.ShowDialog();
        }

        private void Btn_adicionarCursosSegLic_Click(object sender, EventArgs e)
        {
            Frm_AdicionaSegLic formSegLic = new Frm_AdicionaSegLic();
            formSegLic.ShowDialog();
        }

        private void Btn_alterarCurso_Click(object sender, EventArgs e)
        {
            Frm_AlterarCurso formAltCurso = new Frm_AlterarCurso();
            formAltCurso.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AlterarCursoFordoc formAltCursoForDoc = new Frm_AlterarCursoFordoc();
            formAltCursoForDoc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_AlterarCursoSegLic formAltCursoSegLic = new Frm_AlterarCursoSegLic();
            formAltCursoSegLic.ShowDialog();
        }

        private void Btn_excluirCursosPos_Click(object sender, EventArgs e)
        {
            Frm_ExcluirCursoPos formExCursoPos = new Frm_ExcluirCursoPos();
            formExCursoPos.ShowDialog();
        }

        private void Btn_excluirCursosForDoc_Click(object sender, EventArgs e)
        {
            Frm_ExcluirCursosForDoc formExcluirForDoc = new Frm_ExcluirCursosForDoc();
            formExcluirForDoc.ShowDialog();
        }

        private void Btn_excluirCursosSegLicenciatura_Click(object sender, EventArgs e)
        {
            Frm_ExlcuirCursoSegLic formExCursoSegLic = new Frm_ExlcuirCursoSegLic();
            formExCursoSegLic.ShowDialog();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
