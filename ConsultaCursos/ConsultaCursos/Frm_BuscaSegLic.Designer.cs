namespace ConsultaCursos
{
    partial class Frm_BuscaSegLic
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
            this.Lv_exibirCursosSegLic = new System.Windows.Forms.ListView();
            this.Btn_buscarCursosSegLic = new System.Windows.Forms.Button();
            this.Txt_buscarSegLic = new System.Windows.Forms.TextBox();
            this.Btn_fecharSegLic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Curso para procurar de Seg. Licenciatura";
            // 
            // Lv_exibirCursosSegLic
            // 
            this.Lv_exibirCursosSegLic.Location = new System.Drawing.Point(12, 35);
            this.Lv_exibirCursosSegLic.Name = "Lv_exibirCursosSegLic";
            this.Lv_exibirCursosSegLic.Size = new System.Drawing.Size(776, 403);
            this.Lv_exibirCursosSegLic.TabIndex = 1;
            this.Lv_exibirCursosSegLic.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_buscarCursosSegLic
            // 
            this.Btn_buscarCursosSegLic.Location = new System.Drawing.Point(632, 6);
            this.Btn_buscarCursosSegLic.Name = "Btn_buscarCursosSegLic";
            this.Btn_buscarCursosSegLic.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscarCursosSegLic.TabIndex = 2;
            this.Btn_buscarCursosSegLic.Text = "Procurar";
            this.Btn_buscarCursosSegLic.UseVisualStyleBackColor = true;
            this.Btn_buscarCursosSegLic.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_buscarSegLic
            // 
            this.Txt_buscarSegLic.Location = new System.Drawing.Point(282, 6);
            this.Txt_buscarSegLic.Name = "Txt_buscarSegLic";
            this.Txt_buscarSegLic.Size = new System.Drawing.Size(334, 23);
            this.Txt_buscarSegLic.TabIndex = 3;
            // 
            // Btn_fecharSegLic
            // 
            this.Btn_fecharSegLic.Location = new System.Drawing.Point(713, 5);
            this.Btn_fecharSegLic.Name = "Btn_fecharSegLic";
            this.Btn_fecharSegLic.Size = new System.Drawing.Size(75, 23);
            this.Btn_fecharSegLic.TabIndex = 4;
            this.Btn_fecharSegLic.Text = "Fechar";
            this.Btn_fecharSegLic.UseVisualStyleBackColor = true;
            this.Btn_fecharSegLic.Click += new System.EventHandler(this.Btn_fecharSegLic_Click);
            // 
            // Frm_BuscaSegLic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_fecharSegLic);
            this.Controls.Add(this.Txt_buscarSegLic);
            this.Controls.Add(this.Btn_buscarCursosSegLic);
            this.Controls.Add(this.Lv_exibirCursosSegLic);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BuscaSegLic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Cursos Segunda Licenciatura";
            this.Load += new System.EventHandler(this.Frm_BuscaSegLic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView Lv_exibirCursosSegLic;
        private Button Btn_buscarCursosSegLic;
        private TextBox Txt_buscarSegLic;
        private Button Btn_fecharSegLic;
    }
}