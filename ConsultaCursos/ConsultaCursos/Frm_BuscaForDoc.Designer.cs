namespace ConsultaCursos
{
    partial class Frm_BuscarForDoc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lv_ExibirCursos = new System.Windows.Forms.ListView();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_BuscarCursos = new System.Windows.Forms.Button();
            this.Btn_FecharForDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lv_ExibirCursos
            // 
            this.Lv_ExibirCursos.Location = new System.Drawing.Point(12, 35);
            this.Lv_ExibirCursos.Name = "Lv_ExibirCursos";
            this.Lv_ExibirCursos.Size = new System.Drawing.Size(776, 403);
            this.Lv_ExibirCursos.TabIndex = 0;
            this.Lv_ExibirCursos.UseCompatibleStateImageBehavior = false;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(217, 6);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(322, 23);
            this.Txt_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Curso que deseja Buscar";
            // 
            // Btn_BuscarCursos
            // 
            this.Btn_BuscarCursos.Location = new System.Drawing.Point(559, 6);
            this.Btn_BuscarCursos.Name = "Btn_BuscarCursos";
            this.Btn_BuscarCursos.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarCursos.TabIndex = 3;
            this.Btn_BuscarCursos.Text = "Buscar";
            this.Btn_BuscarCursos.UseVisualStyleBackColor = true;
            this.Btn_BuscarCursos.Click += new System.EventHandler(this.Btn_BuscarCursos_Click);
            // 
            // Btn_FecharForDoc
            // 
            this.Btn_FecharForDoc.Location = new System.Drawing.Point(661, 6);
            this.Btn_FecharForDoc.Name = "Btn_FecharForDoc";
            this.Btn_FecharForDoc.Size = new System.Drawing.Size(75, 23);
            this.Btn_FecharForDoc.TabIndex = 4;
            this.Btn_FecharForDoc.Text = "Fechar";
            this.Btn_FecharForDoc.UseVisualStyleBackColor = true;
            this.Btn_FecharForDoc.Click += new System.EventHandler(this.Btn_FecharForDoc_Click);
            // 
            // Frm_BuscarForDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_FecharForDoc);
            this.Controls.Add(this.Btn_BuscarCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Lv_ExibirCursos);
            this.Name = "Frm_BuscarForDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cursos Fordoc";
            this.Load += new System.EventHandler(this.Frm_Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Lv_ExibirCursos;
        private TextBox Txt_Buscar;
        private Label label1;
        private Button Btn_BuscarCursos;
        private Button Btn_FecharForDoc;
    }
}