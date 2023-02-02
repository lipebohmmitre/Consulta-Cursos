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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_BuscarCursos = new System.Windows.Forms.Button();
            this.Btn_FecharForDoc = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_FecharApp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lv_ExibirCursos
            // 
            this.Lv_ExibirCursos.Location = new System.Drawing.Point(12, 42);
            this.Lv_ExibirCursos.Name = "Lv_ExibirCursos";
            this.Lv_ExibirCursos.Size = new System.Drawing.Size(776, 396);
            this.Lv_ExibirCursos.TabIndex = 0;
            this.Lv_ExibirCursos.UseCompatibleStateImageBehavior = false;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(264, 10);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(322, 23);
            this.Txt_Buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Curso que deseja Buscar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.Btn_BuscarCursos);
            this.panel1.Controls.Add(this.Btn_FecharForDoc);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_FecharApp);
            this.panel1.Controls.Add(this.Txt_Buscar);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 40);
            this.panel1.TabIndex = 10;
            // 
            // Btn_BuscarCursos
            // 
            this.Btn_BuscarCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BuscarCursos.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_BuscarCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_BuscarCursos.FlatAppearance.BorderSize = 0;
            this.Btn_BuscarCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_BuscarCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_BuscarCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarCursos.ForeColor = System.Drawing.Color.Black;
            this.Btn_BuscarCursos.Location = new System.Drawing.Point(632, 10);
            this.Btn_BuscarCursos.Name = "Btn_BuscarCursos";
            this.Btn_BuscarCursos.Size = new System.Drawing.Size(69, 24);
            this.Btn_BuscarCursos.TabIndex = 12;
            this.Btn_BuscarCursos.Text = "Procurar";
            this.Btn_BuscarCursos.UseVisualStyleBackColor = false;
            this.Btn_BuscarCursos.Click += new System.EventHandler(this.Btn_BuscarCursos_Click_1);
            // 
            // Btn_FecharForDoc
            // 
            this.Btn_FecharForDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_FecharForDoc.BackColor = System.Drawing.Color.Moccasin;
            this.Btn_FecharForDoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_FecharForDoc.FlatAppearance.BorderSize = 0;
            this.Btn_FecharForDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_FecharForDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_FecharForDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FecharForDoc.ForeColor = System.Drawing.Color.Black;
            this.Btn_FecharForDoc.Location = new System.Drawing.Point(719, 10);
            this.Btn_FecharForDoc.Name = "Btn_FecharForDoc";
            this.Btn_FecharForDoc.Size = new System.Drawing.Size(69, 24);
            this.Btn_FecharForDoc.TabIndex = 11;
            this.Btn_FecharForDoc.Text = "Fechar";
            this.Btn_FecharForDoc.UseVisualStyleBackColor = false;
            this.Btn_FecharForDoc.Click += new System.EventHandler(this.Btn_FecharForDoc_Click_1);
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
            this.Btn_minimizar.Location = new System.Drawing.Point(1163, 11);
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
            this.Btn_FecharApp.Location = new System.Drawing.Point(1238, 11);
            this.Btn_FecharApp.Name = "Btn_FecharApp";
            this.Btn_FecharApp.Size = new System.Drawing.Size(69, 34);
            this.Btn_FecharApp.TabIndex = 4;
            this.Btn_FecharApp.Text = "Fechar";
            this.Btn_FecharApp.UseVisualStyleBackColor = false;
            // 
            // Frm_BuscarForDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lv_ExibirCursos);
            this.Name = "Frm_BuscarForDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cursos Fordoc";
            this.Load += new System.EventHandler(this.Frm_Index_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView Lv_ExibirCursos;
        private TextBox Txt_Buscar;
        private Label label1;
        private Panel panel1;
        private Button Btn_minimizar;
        private Button Btn_FecharApp;
        private Button Btn_BuscarCursos;
        private Button Btn_FecharForDoc;
    }
}