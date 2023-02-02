namespace ConsultaCursos
{
    partial class Frm_AlterarCursoFordoc
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
            this.Txt_procurarCurso = new System.Windows.Forms.TextBox();
            this.Btn_procurarCursoAlterar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Lv_exibirAlterarCurso = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_ExibeId = new System.Windows.Forms.Label();
            this.Lbl_periodo = new System.Windows.Forms.Label();
            this.Txb_nomeCursoAlterar = new System.Windows.Forms.TextBox();
            this.Txb_cargaHorariaAlterar = new System.Windows.Forms.TextBox();
            this.Btn_alterar = new System.Windows.Forms.Button();
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
            // Txt_procurarCurso
            // 
            this.Txt_procurarCurso.Location = new System.Drawing.Point(198, 24);
            this.Txt_procurarCurso.Name = "Txt_procurarCurso";
            this.Txt_procurarCurso.Size = new System.Drawing.Size(395, 23);
            this.Txt_procurarCurso.TabIndex = 1;
            // 
            // Btn_procurarCursoAlterar
            // 
            this.Btn_procurarCursoAlterar.Location = new System.Drawing.Point(599, 24);
            this.Btn_procurarCursoAlterar.Name = "Btn_procurarCursoAlterar";
            this.Btn_procurarCursoAlterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_procurarCursoAlterar.TabIndex = 2;
            this.Btn_procurarCursoAlterar.Text = "Procurar";
            this.Btn_procurarCursoAlterar.UseVisualStyleBackColor = true;
            this.Btn_procurarCursoAlterar.Click += new System.EventHandler(this.Btn_procurarCursoAlterar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(683, 24);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_fechar.TabIndex = 3;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Lv_exibirAlterarCurso
            // 
            this.Lv_exibirAlterarCurso.Location = new System.Drawing.Point(3, 74);
            this.Lv_exibirAlterarCurso.Name = "Lv_exibirAlterarCurso";
            this.Lv_exibirAlterarCurso.Size = new System.Drawing.Size(755, 92);
            this.Lv_exibirAlterarCurso.TabIndex = 4;
            this.Lv_exibirAlterarCurso.UseCompatibleStateImageBehavior = false;
            this.Lv_exibirAlterarCurso.DoubleClick += new System.EventHandler(this.Lv_exibirAlterarCurso_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID do Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do Curso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Período:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carga Horária:";
            // 
            // Lbl_ExibeId
            // 
            this.Lbl_ExibeId.AutoSize = true;
            this.Lbl_ExibeId.Location = new System.Drawing.Point(131, 213);
            this.Lbl_ExibeId.Name = "Lbl_ExibeId";
            this.Lbl_ExibeId.Size = new System.Drawing.Size(0, 15);
            this.Lbl_ExibeId.TabIndex = 9;
            // 
            // Lbl_periodo
            // 
            this.Lbl_periodo.AutoSize = true;
            this.Lbl_periodo.Location = new System.Drawing.Point(131, 285);
            this.Lbl_periodo.Name = "Lbl_periodo";
            this.Lbl_periodo.Size = new System.Drawing.Size(0, 15);
            this.Lbl_periodo.TabIndex = 10;
            // 
            // Txb_nomeCursoAlterar
            // 
            this.Txb_nomeCursoAlterar.Location = new System.Drawing.Point(131, 247);
            this.Txb_nomeCursoAlterar.Name = "Txb_nomeCursoAlterar";
            this.Txb_nomeCursoAlterar.Size = new System.Drawing.Size(214, 23);
            this.Txb_nomeCursoAlterar.TabIndex = 11;
            // 
            // Txb_cargaHorariaAlterar
            // 
            this.Txb_cargaHorariaAlterar.Location = new System.Drawing.Point(131, 320);
            this.Txb_cargaHorariaAlterar.Name = "Txb_cargaHorariaAlterar";
            this.Txb_cargaHorariaAlterar.Size = new System.Drawing.Size(214, 23);
            this.Txb_cargaHorariaAlterar.TabIndex = 12;
            // 
            // Btn_alterar
            // 
            this.Btn_alterar.Location = new System.Drawing.Point(376, 267);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(96, 59);
            this.Btn_alterar.TabIndex = 13;
            this.Btn_alterar.Text = "Alterar";
            this.Btn_alterar.UseVisualStyleBackColor = true;
            this.Btn_alterar.Click += new System.EventHandler(this.Btn_alterar_Click);
            // 
            // Frm_AlterarCursoFordoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.Btn_alterar);
            this.Controls.Add(this.Txb_cargaHorariaAlterar);
            this.Controls.Add(this.Txb_nomeCursoAlterar);
            this.Controls.Add(this.Lbl_periodo);
            this.Controls.Add(this.Lbl_ExibeId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lv_exibirAlterarCurso);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_procurarCursoAlterar);
            this.Controls.Add(this.Txt_procurarCurso);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AlterarCursoFordoc";
            this.Text = "Frm_AlterarCursoFordoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Txt_procurarCurso;
        private Button Btn_procurarCursoAlterar;
        private Button Btn_fechar;
        private ListView Lv_exibirAlterarCurso;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Lbl_ExibeId;
        private Label Lbl_periodo;
        private TextBox Txb_nomeCursoAlterar;
        private TextBox Txb_cargaHorariaAlterar;
        private Button Btn_alterar;
    }
}