namespace ConsultaCursos
{
    partial class Frm_AdicionaPos
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
            this.Btn_salvarPos = new System.Windows.Forms.Button();
            this.Txb_adicionaPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_adicionaCargaHorariaPos = new System.Windows.Forms.TextBox();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coloque o nome do Curso de Pós-Graduação";
            // 
            // Btn_salvarPos
            // 
            this.Btn_salvarPos.Location = new System.Drawing.Point(361, 260);
            this.Btn_salvarPos.Name = "Btn_salvarPos";
            this.Btn_salvarPos.Size = new System.Drawing.Size(75, 23);
            this.Btn_salvarPos.TabIndex = 1;
            this.Btn_salvarPos.Text = "Salvar";
            this.Btn_salvarPos.UseVisualStyleBackColor = true;
            this.Btn_salvarPos.Click += new System.EventHandler(this.Btn_salvarPos_Click);
            // 
            // Txb_adicionaPos
            // 
            this.Txb_adicionaPos.Location = new System.Drawing.Point(278, 151);
            this.Txb_adicionaPos.Name = "Txb_adicionaPos";
            this.Txb_adicionaPos.Size = new System.Drawing.Size(247, 23);
            this.Txb_adicionaPos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coloque a Carga Horária do Curso de Pós";
            // 
            // Txb_adicionaCargaHorariaPos
            // 
            this.Txb_adicionaCargaHorariaPos.Location = new System.Drawing.Point(278, 215);
            this.Txb_adicionaCargaHorariaPos.Name = "Txb_adicionaCargaHorariaPos";
            this.Txb_adicionaCargaHorariaPos.Size = new System.Drawing.Size(247, 23);
            this.Txb_adicionaCargaHorariaPos.TabIndex = 4;
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
            // Frm_AdicionaPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Txb_adicionaCargaHorariaPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_adicionaPos);
            this.Controls.Add(this.Btn_salvarPos);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AdicionaPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdicionaPos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Btn_salvarPos;
        private TextBox Txb_adicionaPos;
        private Label label2;
        private TextBox Txb_adicionaCargaHorariaPos;
        private Button Btn_fechar;
    }
}