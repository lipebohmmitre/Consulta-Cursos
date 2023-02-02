namespace ConsultaCursos
{
    partial class Frm_BuscaTodosCursos
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
            this.Lv_exibeTodosCursos = new System.Windows.Forms.ListView();
            this.Txt_buscaTodosCursos = new System.Windows.Forms.TextBox();
            this.Btn_procurarTodosCursos = new System.Windows.Forms.Button();
            this.Btn_fecharTodosCursos = new System.Windows.Forms.Button();
            this.Btn_alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procurar o Curso que Deseja";
            // 
            // Lv_exibeTodosCursos
            // 
            this.Lv_exibeTodosCursos.Location = new System.Drawing.Point(12, 36);
            this.Lv_exibeTodosCursos.Name = "Lv_exibeTodosCursos";
            this.Lv_exibeTodosCursos.Size = new System.Drawing.Size(824, 415);
            this.Lv_exibeTodosCursos.TabIndex = 1;
            this.Lv_exibeTodosCursos.UseCompatibleStateImageBehavior = false;
            // 
            // Txt_buscaTodosCursos
            // 
            this.Txt_buscaTodosCursos.Location = new System.Drawing.Point(219, 5);
            this.Txt_buscaTodosCursos.Name = "Txt_buscaTodosCursos";
            this.Txt_buscaTodosCursos.Size = new System.Drawing.Size(407, 23);
            this.Txt_buscaTodosCursos.TabIndex = 2;
            // 
            // Btn_procurarTodosCursos
            // 
            this.Btn_procurarTodosCursos.Location = new System.Drawing.Point(632, 7);
            this.Btn_procurarTodosCursos.Name = "Btn_procurarTodosCursos";
            this.Btn_procurarTodosCursos.Size = new System.Drawing.Size(75, 23);
            this.Btn_procurarTodosCursos.TabIndex = 3;
            this.Btn_procurarTodosCursos.Text = "Procurar";
            this.Btn_procurarTodosCursos.UseVisualStyleBackColor = true;
            this.Btn_procurarTodosCursos.Click += new System.EventHandler(this.Btn_procurarTodosCursos_Click);
            // 
            // Btn_fecharTodosCursos
            // 
            this.Btn_fecharTodosCursos.Location = new System.Drawing.Point(713, 7);
            this.Btn_fecharTodosCursos.Name = "Btn_fecharTodosCursos";
            this.Btn_fecharTodosCursos.Size = new System.Drawing.Size(75, 23);
            this.Btn_fecharTodosCursos.TabIndex = 4;
            this.Btn_fecharTodosCursos.Text = "Fechar";
            this.Btn_fecharTodosCursos.UseVisualStyleBackColor = true;
            this.Btn_fecharTodosCursos.Click += new System.EventHandler(this.Btn_fecharTodosCursos_Click);
            // 
            // Btn_alterar
            // 
            this.Btn_alterar.Location = new System.Drawing.Point(761, 457);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_alterar.TabIndex = 5;
            this.Btn_alterar.Text = "Alterar";
            this.Btn_alterar.UseVisualStyleBackColor = true;
            this.Btn_alterar.Click += new System.EventHandler(this.Btn_alterar_Click);
            // 
            // Frm_BuscaTodosCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 486);
            this.Controls.Add(this.Btn_alterar);
            this.Controls.Add(this.Btn_fecharTodosCursos);
            this.Controls.Add(this.Btn_procurarTodosCursos);
            this.Controls.Add(this.Txt_buscaTodosCursos);
            this.Controls.Add(this.Lv_exibeTodosCursos);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BuscaTodosCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BuscaTodosCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView Lv_exibeTodosCursos;
        private TextBox Txt_buscaTodosCursos;
        private Button Btn_procurarTodosCursos;
        private Button Btn_fecharTodosCursos;
        private Button Btn_alterar;
    }
}