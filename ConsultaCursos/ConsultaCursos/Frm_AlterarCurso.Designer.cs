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
            this.Txt_procurarCurso = new System.Windows.Forms.TextBox();
            this.Lv_exibirAlterarCurso = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_nomeCursoAlterar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_cargaHorariaAlterar = new System.Windows.Forms.TextBox();
            this.Lbl_ExibeId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_periodo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_procurarCursoAlterar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_FecharApp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_alterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Curso que Deseja Alterar";
            // 
            // Txt_procurarCurso
            // 
            this.Txt_procurarCurso.Location = new System.Drawing.Point(189, 22);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do Curso:";
            // 
            // Txb_nomeCursoAlterar
            // 
            this.Txb_nomeCursoAlterar.Location = new System.Drawing.Point(141, 53);
            this.Txb_nomeCursoAlterar.Name = "Txb_nomeCursoAlterar";
            this.Txb_nomeCursoAlterar.Size = new System.Drawing.Size(214, 23);
            this.Txb_nomeCursoAlterar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carga Horária:";
            // 
            // Txb_cargaHorariaAlterar
            // 
            this.Txb_cargaHorariaAlterar.Location = new System.Drawing.Point(141, 126);
            this.Txb_cargaHorariaAlterar.Name = "Txb_cargaHorariaAlterar";
            this.Txb_cargaHorariaAlterar.Size = new System.Drawing.Size(214, 23);
            this.Txb_cargaHorariaAlterar.TabIndex = 8;
            // 
            // Lbl_ExibeId
            // 
            this.Lbl_ExibeId.AutoSize = true;
            this.Lbl_ExibeId.Location = new System.Drawing.Point(141, 19);
            this.Lbl_ExibeId.Name = "Lbl_ExibeId";
            this.Lbl_ExibeId.Size = new System.Drawing.Size(0, 15);
            this.Lbl_ExibeId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID do Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Período:";
            // 
            // Lbl_periodo
            // 
            this.Lbl_periodo.AutoSize = true;
            this.Lbl_periodo.Location = new System.Drawing.Point(141, 91);
            this.Lbl_periodo.Name = "Lbl_periodo";
            this.Lbl_periodo.Size = new System.Drawing.Size(0, 15);
            this.Lbl_periodo.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.Btn_procurarCursoAlterar);
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_FecharApp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_procurarCurso);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 71);
            this.panel1.TabIndex = 14;
            // 
            // Btn_procurarCursoAlterar
            // 
            this.Btn_procurarCursoAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_procurarCursoAlterar.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_procurarCursoAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_procurarCursoAlterar.FlatAppearance.BorderSize = 0;
            this.Btn_procurarCursoAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_procurarCursoAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_procurarCursoAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_procurarCursoAlterar.ForeColor = System.Drawing.Color.Black;
            this.Btn_procurarCursoAlterar.Location = new System.Drawing.Point(600, 15);
            this.Btn_procurarCursoAlterar.Name = "Btn_procurarCursoAlterar";
            this.Btn_procurarCursoAlterar.Size = new System.Drawing.Size(69, 34);
            this.Btn_procurarCursoAlterar.TabIndex = 16;
            this.Btn_procurarCursoAlterar.Text = "Procurar";
            this.Btn_procurarCursoAlterar.UseVisualStyleBackColor = false;
            this.Btn_procurarCursoAlterar.Click += new System.EventHandler(this.Btn_procurarCursoAlterar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_fechar.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_fechar.FlatAppearance.BorderSize = 0;
            this.Btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar.ForeColor = System.Drawing.Color.Black;
            this.Btn_fechar.Location = new System.Drawing.Point(686, 15);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(69, 34);
            this.Btn_fechar.TabIndex = 15;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = false;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click_1);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_minimizar.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.ForeColor = System.Drawing.Color.Black;
            this.Btn_minimizar.Location = new System.Drawing.Point(1134, 11);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(69, 34);
            this.Btn_minimizar.TabIndex = 5;
            this.Btn_minimizar.Text = "Minimizar";
            this.Btn_minimizar.UseVisualStyleBackColor = false;
            // 
            // Btn_FecharApp
            // 
            this.Btn_FecharApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_FecharApp.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_FecharApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_FecharApp.FlatAppearance.BorderSize = 0;
            this.Btn_FecharApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_FecharApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_FecharApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FecharApp.ForeColor = System.Drawing.Color.Black;
            this.Btn_FecharApp.Location = new System.Drawing.Point(1209, 11);
            this.Btn_FecharApp.Name = "Btn_FecharApp";
            this.Btn_FecharApp.Size = new System.Drawing.Size(69, 34);
            this.Btn_FecharApp.TabIndex = 4;
            this.Btn_FecharApp.Text = "Fechar";
            this.Btn_FecharApp.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.Btn_alterar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Lbl_periodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txb_nomeCursoAlterar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lbl_ExibeId);
            this.groupBox1.Controls.Add(this.Txb_cargaHorariaAlterar);
            this.groupBox1.Location = new System.Drawing.Point(109, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 179);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Btn_alterar
            // 
            this.Btn_alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_alterar.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_alterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_alterar.FlatAppearance.BorderSize = 0;
            this.Btn_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_alterar.ForeColor = System.Drawing.Color.Black;
            this.Btn_alterar.Location = new System.Drawing.Point(433, 71);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(59, 54);
            this.Btn_alterar.TabIndex = 17;
            this.Btn_alterar.Text = "Alterar";
            this.Btn_alterar.UseVisualStyleBackColor = false;
            this.Btn_alterar.Click += new System.EventHandler(this.Btn_alterar_Click_1);
            // 
            // Frm_AlterarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(764, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lv_exibirAlterarCurso);
            this.Name = "Frm_AlterarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarCursoPos";
            this.Load += new System.EventHandler(this.Frm_AlterarCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox Txt_procurarCurso;
        private ListView Lv_exibirAlterarCurso;
        private Label label2;
        private TextBox Txb_nomeCursoAlterar;
        private Label label3;
        private TextBox Txb_cargaHorariaAlterar;
        private Label Lbl_ExibeId;
        private Label label4;
        private Label label5;
        private Label Lbl_periodo;
        private Panel panel1;
        private Button Btn_minimizar;
        private Button Btn_FecharApp;
        private Button Btn_procurarCursoAlterar;
        private Button Btn_fechar;
        private GroupBox groupBox1;
        private Button Btn_alterar;
    }
}