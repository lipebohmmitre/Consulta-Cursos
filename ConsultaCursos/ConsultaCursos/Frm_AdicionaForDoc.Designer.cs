namespace ConsultaCursos
{
    partial class Frm_AdicionaForDoc
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
            this.Btn_salvarForDoc = new System.Windows.Forms.Button();
            this.Txt_adicionaCursoForDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_adicionaCargaHorariaForDoc = new System.Windows.Forms.TextBox();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Nome Curso de ForDoc";
            // 
            // Btn_salvarForDoc
            // 
            this.Btn_salvarForDoc.Location = new System.Drawing.Point(346, 234);
            this.Btn_salvarForDoc.Name = "Btn_salvarForDoc";
            this.Btn_salvarForDoc.Size = new System.Drawing.Size(75, 23);
            this.Btn_salvarForDoc.TabIndex = 1;
            this.Btn_salvarForDoc.Text = "Salvar";
            this.Btn_salvarForDoc.UseVisualStyleBackColor = true;
            this.Btn_salvarForDoc.Click += new System.EventHandler(this.Btn_salvarForDoc_Click);
            // 
            // Txt_adicionaCursoForDoc
            // 
            this.Txt_adicionaCursoForDoc.Location = new System.Drawing.Point(298, 131);
            this.Txt_adicionaCursoForDoc.Name = "Txt_adicionaCursoForDoc";
            this.Txt_adicionaCursoForDoc.Size = new System.Drawing.Size(185, 23);
            this.Txt_adicionaCursoForDoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adicionar Carga Horária do ForDoc";
            // 
            // Txt_adicionaCargaHorariaForDoc
            // 
            this.Txt_adicionaCargaHorariaForDoc.Location = new System.Drawing.Point(298, 188);
            this.Txt_adicionaCargaHorariaForDoc.Name = "Txt_adicionaCargaHorariaForDoc";
            this.Txt_adicionaCargaHorariaForDoc.Size = new System.Drawing.Size(185, 23);
            this.Txt_adicionaCargaHorariaForDoc.TabIndex = 4;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(713, 12);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_fechar.TabIndex = 5;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Frm_AdicionaForDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Txt_adicionaCargaHorariaForDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_adicionaCursoForDoc);
            this.Controls.Add(this.Btn_salvarForDoc);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AdicionaForDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdicionaForDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Btn_salvarForDoc;
        private TextBox Txt_adicionaCursoForDoc;
        private Label label2;
        private TextBox Txt_adicionaCargaHorariaForDoc;
        private Button Btn_fechar;
    }
}