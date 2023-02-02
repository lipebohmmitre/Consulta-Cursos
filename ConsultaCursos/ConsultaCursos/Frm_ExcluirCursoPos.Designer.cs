namespace ConsultaCursos
{
    partial class Frm_ExcluirCursoPos
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
            this.Lv_exibeCurso = new System.Windows.Forms.ListView();
            this.Txb_procurarCurso = new System.Windows.Forms.TextBox();
            this.Lbl_mostraIdCurso = new System.Windows.Forms.Label();
            this.Lbl_mostraNomeCurso = new System.Windows.Forms.Label();
            this.Lbl_mostraPeriodoCurso = new System.Windows.Forms.Label();
            this.Lbl_mostraCargaHoraria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_procurar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_procurarCursoAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_FecharApp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_alterar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Lbl_periodo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ExibeId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Curso que Deseja Excluir:";
            // 
            // Lv_exibeCurso
            // 
            this.Lv_exibeCurso.Location = new System.Drawing.Point(12, 77);
            this.Lv_exibeCurso.Name = "Lv_exibeCurso";
            this.Lv_exibeCurso.Size = new System.Drawing.Size(776, 97);
            this.Lv_exibeCurso.TabIndex = 1;
            this.Lv_exibeCurso.UseCompatibleStateImageBehavior = false;
            this.Lv_exibeCurso.DoubleClick += new System.EventHandler(this.Lv_exibeCurso_DoubleClick);
            // 
            // Txb_procurarCurso
            // 
            this.Txb_procurarCurso.Location = new System.Drawing.Point(192, 22);
            this.Txb_procurarCurso.Name = "Txb_procurarCurso";
            this.Txb_procurarCurso.Size = new System.Drawing.Size(430, 23);
            this.Txb_procurarCurso.TabIndex = 2;
            // 
            // Lbl_mostraIdCurso
            // 
            this.Lbl_mostraIdCurso.AutoSize = true;
            this.Lbl_mostraIdCurso.Location = new System.Drawing.Point(147, 19);
            this.Lbl_mostraIdCurso.Name = "Lbl_mostraIdCurso";
            this.Lbl_mostraIdCurso.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraIdCurso.TabIndex = 6;
            // 
            // Lbl_mostraNomeCurso
            // 
            this.Lbl_mostraNomeCurso.AutoSize = true;
            this.Lbl_mostraNomeCurso.Location = new System.Drawing.Point(147, 53);
            this.Lbl_mostraNomeCurso.Name = "Lbl_mostraNomeCurso";
            this.Lbl_mostraNomeCurso.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraNomeCurso.TabIndex = 8;
            // 
            // Lbl_mostraPeriodoCurso
            // 
            this.Lbl_mostraPeriodoCurso.AutoSize = true;
            this.Lbl_mostraPeriodoCurso.Location = new System.Drawing.Point(147, 105);
            this.Lbl_mostraPeriodoCurso.Name = "Lbl_mostraPeriodoCurso";
            this.Lbl_mostraPeriodoCurso.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraPeriodoCurso.TabIndex = 10;
            // 
            // Lbl_mostraCargaHoraria
            // 
            this.Lbl_mostraCargaHoraria.AutoSize = true;
            this.Lbl_mostraCargaHoraria.Location = new System.Drawing.Point(141, 126);
            this.Lbl_mostraCargaHoraria.Name = "Lbl_mostraCargaHoraria";
            this.Lbl_mostraCargaHoraria.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraCargaHoraria.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.Btn_procurar);
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_procurarCursoAlterar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_FecharApp);
            this.panel1.Controls.Add(this.Txb_procurarCurso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 71);
            this.panel1.TabIndex = 16;
            // 
            // Btn_procurar
            // 
            this.Btn_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_procurar.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_procurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_procurar.FlatAppearance.BorderSize = 0;
            this.Btn_procurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_procurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_procurar.ForeColor = System.Drawing.Color.Black;
            this.Btn_procurar.Location = new System.Drawing.Point(643, 15);
            this.Btn_procurar.Name = "Btn_procurar";
            this.Btn_procurar.Size = new System.Drawing.Size(69, 34);
            this.Btn_procurar.TabIndex = 19;
            this.Btn_procurar.Text = "Procurar";
            this.Btn_procurar.UseVisualStyleBackColor = false;
            this.Btn_procurar.Click += new System.EventHandler(this.Btn_procurar_Click_1);
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
            this.Btn_fechar.Location = new System.Drawing.Point(718, 15);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(69, 34);
            this.Btn_fechar.TabIndex = 18;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = false;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click_1);
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
            this.Btn_procurarCursoAlterar.Location = new System.Drawing.Point(1213, 15);
            this.Btn_procurarCursoAlterar.Name = "Btn_procurarCursoAlterar";
            this.Btn_procurarCursoAlterar.Size = new System.Drawing.Size(69, 34);
            this.Btn_procurarCursoAlterar.TabIndex = 17;
            this.Btn_procurarCursoAlterar.Text = "Procurar";
            this.Btn_procurarCursoAlterar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1288, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1774, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Procurar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1860, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = false;
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
            this.Btn_minimizar.Location = new System.Drawing.Point(2308, 11);
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
            this.Btn_FecharApp.Location = new System.Drawing.Point(2383, 11);
            this.Btn_FecharApp.Name = "Btn_FecharApp";
            this.Btn_FecharApp.Size = new System.Drawing.Size(69, 34);
            this.Btn_FecharApp.TabIndex = 4;
            this.Btn_FecharApp.Text = "Fechar";
            this.Btn_FecharApp.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.Btn_excluir);
            this.groupBox1.Controls.Add(this.Btn_alterar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Lbl_periodo);
            this.groupBox1.Controls.Add(this.Lbl_mostraCargaHoraria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lbl_ExibeId);
            this.groupBox1.Controls.Add(this.Lbl_mostraPeriodoCurso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Lbl_mostraNomeCurso);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Lbl_mostraIdCurso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(115, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 179);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_excluir.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_excluir.FlatAppearance.BorderSize = 0;
            this.Btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_excluir.ForeColor = System.Drawing.Color.Black;
            this.Btn_excluir.Location = new System.Drawing.Point(356, 45);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(84, 75);
            this.Btn_excluir.TabIndex = 19;
            this.Btn_excluir.Text = "Apagar";
            this.Btn_excluir.UseVisualStyleBackColor = false;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click_1);
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
            this.Btn_alterar.Location = new System.Drawing.Point(784, 71);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(59, 54);
            this.Btn_alterar.TabIndex = 18;
            this.Btn_alterar.Text = "Alterar";
            this.Btn_alterar.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Moccasin;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(1147, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 54);
            this.button4.TabIndex = 17;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Lbl_periodo
            // 
            this.Lbl_periodo.AutoSize = true;
            this.Lbl_periodo.Location = new System.Drawing.Point(141, 91);
            this.Lbl_periodo.Name = "Lbl_periodo";
            this.Lbl_periodo.Size = new System.Drawing.Size(0, 15);
            this.Lbl_periodo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID do Curso:";
            // 
            // Lbl_ExibeId
            // 
            this.Lbl_ExibeId.AutoSize = true;
            this.Lbl_ExibeId.Location = new System.Drawing.Point(147, 19);
            this.Lbl_ExibeId.Name = "Lbl_ExibeId";
            this.Lbl_ExibeId.Size = new System.Drawing.Size(0, 15);
            this.Lbl_ExibeId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome do Curso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Período:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(35, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Carga Horária:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 9;
            // 
            // Frm_ExcluirCursoPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lv_exibeCurso);
            this.Name = "Frm_ExcluirCursoPos";
            this.Text = "Excluir Curso Pós Graduação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ListView Lv_exibeCurso;
        private TextBox Txb_procurarCurso;
        private Label Lbl_mostraIdCurso;
        private Label Lbl_mostraNomeCurso;
        private Label Lbl_mostraPeriodoCurso;
        private Label Lbl_mostraCargaHoraria;
        private Panel panel1;
        private Button Btn_procurarCursoAlterar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Btn_minimizar;
        private Button Btn_FecharApp;
        private Button Btn_procurar;
        private Button Btn_fechar;
        private GroupBox groupBox1;
        private Button Btn_alterar;
        private Button button4;
        private Label Lbl_periodo;
        private Label label3;
        private Label Lbl_ExibeId;
        private Label label7;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button Btn_excluir;
    }
}