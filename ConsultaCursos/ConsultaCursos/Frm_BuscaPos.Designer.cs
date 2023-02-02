namespace ConsultaCursos
{
    partial class Frm_BuscaPos
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
            this.Lv_exibirCursosPos = new System.Windows.Forms.ListView();
            this.Txt_bucarPos = new System.Windows.Forms.TextBox();
            this.Btn_buscarCursosPos = new System.Windows.Forms.Button();
            this.Btn_fecharPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Curso de Pós para Procurar";
            // 
            // Lv_exibirCursosPos
            // 
            this.Lv_exibirCursosPos.Location = new System.Drawing.Point(12, 42);
            this.Lv_exibirCursosPos.Name = "Lv_exibirCursosPos";
            this.Lv_exibirCursosPos.Size = new System.Drawing.Size(776, 396);
            this.Lv_exibirCursosPos.TabIndex = 1;
            this.Lv_exibirCursosPos.UseCompatibleStateImageBehavior = false;
            // 
            // Txt_bucarPos
            // 
            this.Txt_bucarPos.Location = new System.Drawing.Point(212, 12);
            this.Txt_bucarPos.Name = "Txt_bucarPos";
            this.Txt_bucarPos.Size = new System.Drawing.Size(396, 23);
            this.Txt_bucarPos.TabIndex = 2;
            // 
            // Btn_buscarCursosPos
            // 
            this.Btn_buscarCursosPos.Location = new System.Drawing.Point(627, 10);
            this.Btn_buscarCursosPos.Name = "Btn_buscarCursosPos";
            this.Btn_buscarCursosPos.Size = new System.Drawing.Size(75, 26);
            this.Btn_buscarCursosPos.TabIndex = 3;
            this.Btn_buscarCursosPos.Text = "Procurar";
            this.Btn_buscarCursosPos.UseVisualStyleBackColor = true;
            this.Btn_buscarCursosPos.Click += new System.EventHandler(this.Btn_buscarCursosPos_Click);
            // 
            // Btn_fecharPos
            // 
            this.Btn_fecharPos.Location = new System.Drawing.Point(713, 10);
            this.Btn_fecharPos.Name = "Btn_fecharPos";
            this.Btn_fecharPos.Size = new System.Drawing.Size(75, 26);
            this.Btn_fecharPos.TabIndex = 4;
            this.Btn_fecharPos.Text = "Fechar";
            this.Btn_fecharPos.UseVisualStyleBackColor = true;
            this.Btn_fecharPos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_BuscaPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_fecharPos);
            this.Controls.Add(this.Btn_buscarCursosPos);
            this.Controls.Add(this.Txt_bucarPos);
            this.Controls.Add(this.Lv_exibirCursosPos);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BuscaPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cursos Pós";
            this.Load += new System.EventHandler(this.Frm_BuscaPos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView Lv_exibirCursosPos;
        private TextBox Txt_bucarPos;
        private Button Btn_buscarCursosPos;
        private Button Btn_fecharPos;
    }
}