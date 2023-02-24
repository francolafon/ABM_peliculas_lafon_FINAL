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
            this.btn_cancel_dir = new System.Windows.Forms.Button();
            this.btn_alta_libros = new System.Windows.Forms.Button();
            this.lbl_tit_dir = new System.Windows.Forms.Label();
            this.lbl_nomb_dir = new System.Windows.Forms.Label();
            this.lbl_id_dir = new System.Windows.Forms.Label();
            this.txt_id_dir = new System.Windows.Forms.TextBox();
            this.txt_nomb_dir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel_dir
            // 
            this.btn_cancel_dir.Location = new System.Drawing.Point(272, 245);
            this.btn_cancel_dir.Name = "btn_cancel_dir";
            this.btn_cancel_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_dir.TabIndex = 50;
            this.btn_cancel_dir.Text = "Volver";
            this.btn_cancel_dir.UseVisualStyleBackColor = true;
            this.btn_cancel_dir.Click += new System.EventHandler(this.btn_cancel_dir_Click);
            // 
            // btn_alta_libros
            // 
            this.btn_alta_libros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_alta_libros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_libros.Location = new System.Drawing.Point(105, 222);
            this.btn_alta_libros.Name = "btn_alta_libros";
            this.btn_alta_libros.Size = new System.Drawing.Size(138, 46);
            this.btn_alta_libros.TabIndex = 49;
            this.btn_alta_libros.Text = "Alta";
            this.btn_alta_libros.UseVisualStyleBackColor = false;
            // 
            // lbl_tit_dir
            // 
            this.lbl_tit_dir.AutoSize = true;
            this.lbl_tit_dir.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tit_dir.Location = new System.Drawing.Point(109, 36);
            this.lbl_tit_dir.Name = "lbl_tit_dir";
            this.lbl_tit_dir.Size = new System.Drawing.Size(158, 27);
            this.lbl_tit_dir.TabIndex = 48;
            this.lbl_tit_dir.Text = "Alta Directores";
            // 
            // lbl_nomb_dir
            // 
            this.lbl_nomb_dir.AutoSize = true;
            this.lbl_nomb_dir.Location = new System.Drawing.Point(19, 144);
            this.lbl_nomb_dir.Name = "lbl_nomb_dir";
            this.lbl_nomb_dir.Size = new System.Drawing.Size(84, 13);
            this.lbl_nomb_dir.TabIndex = 47;
            this.lbl_nomb_dir.Text = "Nombre Director";
            // 
            // lbl_id_dir
            // 
            this.lbl_id_dir.AutoSize = true;
            this.lbl_id_dir.Location = new System.Drawing.Point(19, 103);
            this.lbl_id_dir.Name = "lbl_id_dir";
            this.lbl_id_dir.Size = new System.Drawing.Size(80, 13);
            this.lbl_id_dir.TabIndex = 46;
            this.lbl_id_dir.Text = "Codigo Director";
            // 
            // txt_id_dir
            // 
            this.txt_id_dir.Enabled = false;
            this.txt_id_dir.Location = new System.Drawing.Point(114, 100);
            this.txt_id_dir.Name = "txt_id_dir";
            this.txt_id_dir.Size = new System.Drawing.Size(101, 20);
            this.txt_id_dir.TabIndex = 45;
            // 
            // txt_nomb_dir
            // 
            this.txt_nomb_dir.Location = new System.Drawing.Point(114, 141);
            this.txt_nomb_dir.Name = "txt_nomb_dir";
            this.txt_nomb_dir.Size = new System.Drawing.Size(218, 20);
            this.txt_nomb_dir.TabIndex = 44;
            // 
            // FormAltaDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(359, 280);
            this.Controls.Add(this.btn_cancel_dir);
            this.Controls.Add(this.btn_alta_libros);
            this.Controls.Add(this.lbl_tit_dir);
            this.Controls.Add(this.lbl_nomb_dir);
            this.Controls.Add(this.lbl_id_dir);
            this.Controls.Add(this.txt_id_dir);
            this.Controls.Add(this.txt_nomb_dir);
            this.Name = "FormAltaDirector";
            this.Text = "FormAltaDirector";
            this.Load += new System.EventHandler(this.FormAltaDirector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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