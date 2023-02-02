namespace ConsultaCursos
{
    partial class Frm_AdicionaSegLic
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
            this.Btn_salvarCursoSegLic = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_adicionarCursoSegLic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_AdicionarCargaHorariaSegLic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_salvarCursoSegLic
            // 
            this.Btn_salvarCursoSegLic.Location = new System.Drawing.Point(356, 231);
            this.Btn_salvarCursoSegLic.Name = "Btn_salvarCursoSegLic";
            this.Btn_salvarCursoSegLic.Size = new System.Drawing.Size(75, 23);
            this.Btn_salvarCursoSegLic.TabIndex = 0;
            this.Btn_salvarCursoSegLic.Text = "Salvar";
            this.Btn_salvarCursoSegLic.UseVisualStyleBackColor = true;
            this.Btn_salvarCursoSegLic.Click += new System.EventHandler(this.Btn_salvarCursoSegLic_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(713, 12);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_fechar.TabIndex = 1;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adicionar Curso de Segunda Licenciatura";
            // 
            // Txt_adicionarCursoSegLic
            // 
            this.Txt_adicionarCursoSegLic.Location = new System.Drawing.Point(284, 130);
            this.Txt_adicionarCursoSegLic.Name = "Txt_adicionarCursoSegLic";
            this.Txt_adicionarCursoSegLic.Size = new System.Drawing.Size(224, 23);
            this.Txt_adicionarCursoSegLic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adicionar Carga horária Segunda Licenciatura";
            // 
            // Txt_AdicionarCargaHorariaSegLic
            // 
            this.Txt_AdicionarCargaHorariaSegLic.Location = new System.Drawing.Point(284, 187);
            this.Txt_AdicionarCargaHorariaSegLic.Name = "Txt_AdicionarCargaHorariaSegLic";
            this.Txt_AdicionarCargaHorariaSegLic.Size = new System.Drawing.Size(224, 23);
            this.Txt_AdicionarCargaHorariaSegLic.TabIndex = 5;
            // 
            // Frm_AdicionaSegLic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_AdicionarCargaHorariaSegLic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_adicionarCursoSegLic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_salvarCursoSegLic);
            this.Name = "Frm_AdicionaSegLic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdicionaSegLic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_salvarCursoSegLic;
        private Button Btn_fechar;
        private Label label1;
        private TextBox Txt_adicionarCursoSegLic;
        private Label label2;
        private TextBox Txt_AdicionarCargaHorariaSegLic;
    }
}