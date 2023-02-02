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
            this.Btn_procurar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_mostraIdCurso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_mostraNomeCurso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_mostraPeriodoCurso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_mostraCargaHoraria = new System.Windows.Forms.Label();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Curso que Deseja Excluir:";
            // 
            // Lv_exibeCurso
            // 
            this.Lv_exibeCurso.Location = new System.Drawing.Point(12, 55);
            this.Lv_exibeCurso.Name = "Lv_exibeCurso";
            this.Lv_exibeCurso.Size = new System.Drawing.Size(776, 97);
            this.Lv_exibeCurso.TabIndex = 1;
            this.Lv_exibeCurso.UseCompatibleStateImageBehavior = false;
            this.Lv_exibeCurso.DoubleClick += new System.EventHandler(this.Lv_exibeCurso_DoubleClick);
            // 
            // Txb_procurarCurso
            // 
            this.Txb_procurarCurso.Location = new System.Drawing.Point(219, 22);
            this.Txb_procurarCurso.Name = "Txb_procurarCurso";
            this.Txb_procurarCurso.Size = new System.Drawing.Size(399, 23);
            this.Txb_procurarCurso.TabIndex = 2;
            // 
            // Btn_procurar
            // 
            this.Btn_procurar.Location = new System.Drawing.Point(633, 22);
            this.Btn_procurar.Name = "Btn_procurar";
            this.Btn_procurar.Size = new System.Drawing.Size(75, 23);
            this.Btn_procurar.TabIndex = 3;
            this.Btn_procurar.Text = "Procurar";
            this.Btn_procurar.UseVisualStyleBackColor = true;
            this.Btn_procurar.Click += new System.EventHandler(this.Btn_procurar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(714, 22);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_fechar.TabIndex = 4;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID do Curso:";
            // 
            // Lbl_mostraIdCurso
            // 
            this.Lbl_mostraIdCurso.AutoSize = true;
            this.Lbl_mostraIdCurso.Location = new System.Drawing.Point(151, 222);
            this.Lbl_mostraIdCurso.Name = "Lbl_mostraIdCurso";
            this.Lbl_mostraIdCurso.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraIdCurso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do Curso:";
            // 
            // Lbl_mostraNomeCurso
            // 
            this.Lbl_mostraNomeCurso.AutoSize = true;
            this.Lbl_mostraNomeCurso.Location = new System.Drawing.Point(151, 266);
            this.Lbl_mostraNomeCurso.Name = "Lbl_mostraNomeCurso";
            this.Lbl_mostraNomeCurso.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraNomeCurso.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Período:";
            // 
            // Lbl_mostraPeriodoCurso
            // 
            this.Lbl_mostraPeriodoCurso.AutoSize = true;
            this.Lbl_mostraPeriodoCurso.Location = new System.Drawing.Point(151, 308);
            this.Lbl_mostraPeriodoCurso.Name = "Lbl_mostraPeriodoCurso";
            this.Lbl_mostraPeriodoCurso.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraPeriodoCurso.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Carga Horária:";
            // 
            // Lbl_mostraCargaHoraria
            // 
            this.Lbl_mostraCargaHoraria.AutoSize = true;
            this.Lbl_mostraCargaHoraria.Location = new System.Drawing.Point(151, 352);
            this.Lbl_mostraCargaHoraria.Name = "Lbl_mostraCargaHoraria";
            this.Lbl_mostraCargaHoraria.Size = new System.Drawing.Size(0, 15);
            this.Lbl_mostraCargaHoraria.TabIndex = 12;
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Location = new System.Drawing.Point(392, 257);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(110, 77);
            this.Btn_excluir.TabIndex = 13;
            this.Btn_excluir.Text = "Apagar Curso";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Frm_ExcluirCursoPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Lbl_mostraCargaHoraria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lbl_mostraPeriodoCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl_mostraNomeCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_mostraIdCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_procurar);
            this.Controls.Add(this.Txb_procurarCurso);
            this.Controls.Add(this.Lv_exibeCurso);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ExcluirCursoPos";
            this.Text = "Excluir Curso Pós Graduação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView Lv_exibeCurso;
        private TextBox Txb_procurarCurso;
        private Button Btn_procurar;
        private Button Btn_fechar;
        private Label label2;
        private Label Lbl_mostraIdCurso;
        private Label label4;
        private Label Lbl_mostraNomeCurso;
        private Label label6;
        private Label Lbl_mostraPeriodoCurso;
        private Label label8;
        private Label Lbl_mostraCargaHoraria;
        private Button Btn_excluir;
    }
}