namespace ConsultaCursos
{
    partial class Frm_AlterarCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_procurarCursoAlterar = new System.Windows.Forms.Button();
            this.Txt_procurarCurso = new System.Windows.Forms.TextBox();
            this.Lv_exibirAlterarCurso = new System.Windows.Forms.ListView();
            this.Btn_alterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_nomeCursoAlterar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_cargaHorariaAlterar = new System.Windows.Forms.TextBox();
            this.Lbl_ExibeId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_periodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Curso que Deseja Alterar";
            // 
            // Btn_procurarCursoAlterar
            // 
            this.Btn_procurarCursoAlterar.Location = new System.Drawing.Point(599, 24);
            this.Btn_procurarCursoAlterar.Name = "Btn_procurarCursoAlterar";
            this.Btn_procurarCursoAlterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_procurarCursoAlterar.TabIndex = 1;
            this.Btn_procurarCursoAlterar.Text = "Procurar";
            this.Btn_procurarCursoAlterar.UseVisualStyleBackColor = true;
            this.Btn_procurarCursoAlterar.Click += new System.EventHandler(this.Btn_procurarCursoAlterar_Click_1);
            // 
            // Txt_procurarCurso
            // 
            this.Txt_procurarCurso.Location = new System.Drawing.Point(198, 24);
            this.Txt_procurarCurso.Name = "Txt_procurarCurso";
            this.Txt_procurarCurso.Size = new System.Drawing.Size(395, 23);
            this.Txt_procurarCurso.TabIndex = 2;
            // 
            // Lv_exibirAlterarCurso
            // 
            this.Lv_exibirAlterarCurso.Location = new System.Drawing.Point(3, 74);
            this.Lv_exibirAlterarCurso.Name = "Lv_exibirAlterarCurso";
            this.Lv_exibirAlterarCurso.Size = new System.Drawing.Size(755, 92);
            this.Lv_exibirAlterarCurso.TabIndex = 3;
            this.Lv_exibirAlterarCurso.UseCompatibleStateImageBehavior = false;
            this.Lv_exibirAlterarCurso.DoubleClick += new System.EventHandler(this.Lv_exibirAlterarCurso_DoubleClick);
            // 
            // Btn_alterar
            // 
            this.Btn_alterar.Location = new System.Drawing.Point(376, 267);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(96, 59);
            this.Btn_alterar.TabIndex = 4;
            this.Btn_alterar.Text = "Alterar";
            this.Btn_alterar.UseVisualStyleBackColor = true;
            this.Btn_alterar.Click += new System.EventHandler(this.Btn_alterar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Curso:";
            // 
            // Txb_nomeCursoAlterar
            // 
            this.Txb_nomeCursoAlterar.Location = new System.Drawing.Point(137, 247);
            this.Txb_nomeCursoAlterar.Name = "Txb_nomeCursoAlterar";
            this.Txb_nomeCursoAlterar.Size = new System.Drawing.Size(214, 23);
            this.Txb_nomeCursoAlterar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carga Horária:";
            // 
            // Txb_cargaHorariaAlterar
            // 
            this.Txb_cargaHorariaAlterar.Location = new System.Drawing.Point(137, 320);
            this.Txb_cargaHorariaAlterar.Name = "Txb_cargaHorariaAlterar";
            this.Txb_cargaHorariaAlterar.Size = new System.Drawing.Size(214, 23);
            this.Txb_cargaHorariaAlterar.TabIndex = 8;
            // 
            // Lbl_ExibeId
            // 
            this.Lbl_ExibeId.AutoSize = true;
            this.Lbl_ExibeId.Location = new System.Drawing.Point(137, 213);
            this.Lbl_ExibeId.Name = "Lbl_ExibeId";
            this.Lbl_ExibeId.Size = new System.Drawing.Size(0, 15);
            this.Lbl_ExibeId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID do Curso:";
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(683, 24);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_fechar.TabIndex = 11;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Período:";
            // 
            // Lbl_periodo
            // 
            this.Lbl_periodo.AutoSize = true;
            this.Lbl_periodo.Location = new System.Drawing.Point(137, 285);
            this.Lbl_periodo.Name = "Lbl_periodo";
            this.Lbl_periodo.Size = new System.Drawing.Size(0, 15);
            this.Lbl_periodo.TabIndex = 13;
            // 
            // Frm_AlterarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 412);
            this.Controls.Add(this.Lbl_periodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_ExibeId);
            this.Controls.Add(this.Txb_cargaHorariaAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_nomeCursoAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_alterar);
            this.Controls.Add(this.Lv_exibirAlterarCurso);
            this.Controls.Add(this.Txt_procurarCurso);
            this.Controls.Add(this.Btn_procurarCursoAlterar);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AlterarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarCursoPos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Btn_procurarCursoAlterar;
        private TextBox Txt_procurarCurso;
        private ListView Lv_exibirAlterarCurso;
        private Button Btn_alterar;
        private Label label2;
        private TextBox Txb_nomeCursoAlterar;
        private Label label3;
        private TextBox Txb_cargaHorariaAlterar;
        private Label Lbl_ExibeId;
        private Label label4;
        private Button Btn_fechar;
        private Label label5;
        private Label Lbl_periodo;
    }
}