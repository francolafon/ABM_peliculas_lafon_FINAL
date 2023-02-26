namespace CP
{
    partial class FormAltaDirector
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
            btn_cancel_dir = new Button();
            btn_alta_libros = new Button();
            lbl_tit_dir = new Label();
            lbl_nomb_dir = new Label();
            lbl_id_dir = new Label();
            txt_id_dir = new TextBox();
            txt_nomb_dir = new TextBox();
            SuspendLayout();
            // 
            // btn_cancel_dir
            // 
            btn_cancel_dir.Location = new Point(317, 283);
            btn_cancel_dir.Margin = new Padding(4, 3, 4, 3);
            btn_cancel_dir.Name = "btn_cancel_dir";
            btn_cancel_dir.Size = new Size(88, 27);
            btn_cancel_dir.TabIndex = 50;
            btn_cancel_dir.Text = "Volver";
            btn_cancel_dir.UseVisualStyleBackColor = true;
            btn_cancel_dir.Click += btn_cancel_dir_Click;
            // 
            // btn_alta_libros
            // 
            btn_alta_libros.BackColor = Color.Bisque;
            btn_alta_libros.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_alta_libros.Location = new Point(122, 256);
            btn_alta_libros.Margin = new Padding(4, 3, 4, 3);
            btn_alta_libros.Name = "btn_alta_libros";
            btn_alta_libros.Size = new Size(161, 53);
            btn_alta_libros.TabIndex = 49;
            btn_alta_libros.Text = "Alta";
            btn_alta_libros.UseVisualStyleBackColor = false;
            // 
            // lbl_tit_dir
            // 
            lbl_tit_dir.AutoSize = true;
            lbl_tit_dir.BackColor = Color.Tan;
            lbl_tit_dir.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tit_dir.Location = new Point(127, 42);
            lbl_tit_dir.Margin = new Padding(4, 0, 4, 0);
            lbl_tit_dir.Name = "lbl_tit_dir";
            lbl_tit_dir.Size = new Size(158, 27);
            lbl_tit_dir.TabIndex = 48;
            lbl_tit_dir.Text = "Alta Directores";
            // 
            // lbl_nomb_dir
            // 
            lbl_nomb_dir.AutoSize = true;
            lbl_nomb_dir.BackColor = Color.Tan;
            lbl_nomb_dir.Location = new Point(22, 166);
            lbl_nomb_dir.Margin = new Padding(4, 0, 4, 0);
            lbl_nomb_dir.Name = "lbl_nomb_dir";
            lbl_nomb_dir.Size = new Size(96, 15);
            lbl_nomb_dir.TabIndex = 47;
            lbl_nomb_dir.Text = "Nombre Director";
            // 
            // lbl_id_dir
            // 
            lbl_id_dir.AutoSize = true;
            lbl_id_dir.BackColor = Color.Tan;
            lbl_id_dir.Location = new Point(22, 119);
            lbl_id_dir.Margin = new Padding(4, 0, 4, 0);
            lbl_id_dir.Name = "lbl_id_dir";
            lbl_id_dir.Size = new Size(91, 15);
            lbl_id_dir.TabIndex = 46;
            lbl_id_dir.Text = "Codigo Director";
            // 
            // txt_id_dir
            // 
            txt_id_dir.Enabled = false;
            txt_id_dir.Location = new Point(133, 115);
            txt_id_dir.Margin = new Padding(4, 3, 4, 3);
            txt_id_dir.Name = "txt_id_dir";
            txt_id_dir.Size = new Size(117, 23);
            txt_id_dir.TabIndex = 45;
            // 
            // txt_nomb_dir
            // 
            txt_nomb_dir.Location = new Point(133, 163);
            txt_nomb_dir.Margin = new Padding(4, 3, 4, 3);
            txt_nomb_dir.Name = "txt_nomb_dir";
            txt_nomb_dir.Size = new Size(254, 23);
            txt_nomb_dir.TabIndex = 44;
            // 
            // FormAltaDirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.descarga;
            ClientSize = new Size(419, 323);
            Controls.Add(btn_cancel_dir);
            Controls.Add(btn_alta_libros);
            Controls.Add(lbl_tit_dir);
            Controls.Add(lbl_nomb_dir);
            Controls.Add(lbl_id_dir);
            Controls.Add(txt_id_dir);
            Controls.Add(txt_nomb_dir);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAltaDirector";
            Text = "FormAltaDirector";
            Load += FormAltaDirector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_dir;
        private System.Windows.Forms.Button btn_alta_libros;
        private System.Windows.Forms.Label lbl_tit_dir;
        private System.Windows.Forms.Label lbl_nomb_dir;
        private System.Windows.Forms.Label lbl_id_dir;
        private System.Windows.Forms.TextBox txt_id_dir;
        private System.Windows.Forms.TextBox txt_nomb_dir;
    }
}