namespace CP
{
    partial class FormAltaProductora
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
            this.btn_cancel_prod = new System.Windows.Forms.Button();
            this.btn_alta_prod = new System.Windows.Forms.Button();
            this.lbl_tit = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_id_prod = new System.Windows.Forms.Label();
            this.txt_id_prod = new System.Windows.Forms.TextBox();
            this.txt_nomb_prod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel_prod
            // 
            this.btn_cancel_prod.Location = new System.Drawing.Point(275, 237);
            this.btn_cancel_prod.Name = "btn_cancel_prod";
            this.btn_cancel_prod.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_prod.TabIndex = 57;
            this.btn_cancel_prod.Text = "Volver";
            this.btn_cancel_prod.UseVisualStyleBackColor = true;
            this.btn_cancel_prod.Click += new System.EventHandler(this.btn_cancel_prod_Click);
            // 
            // btn_alta_prod
            // 
            this.btn_alta_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_alta_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_prod.Location = new System.Drawing.Point(108, 214);
            this.btn_alta_prod.Name = "btn_alta_prod";
            this.btn_alta_prod.Size = new System.Drawing.Size(138, 46);
            this.btn_alta_prod.TabIndex = 56;
            this.btn_alta_prod.Text = "Alta";
            this.btn_alta_prod.UseVisualStyleBackColor = false;
            // 
            // lbl_tit
            // 
            this.lbl_tit.AutoSize = true;
            this.lbl_tit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tit.Location = new System.Drawing.Point(112, 28);
            this.lbl_tit.Name = "lbl_tit";
            this.lbl_tit.Size = new System.Drawing.Size(172, 27);
            this.lbl_tit.TabIndex = 55;
            this.lbl_tit.Text = "Alta Productoras";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(22, 136);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(72, 13);
            this.lbl_titulo.TabIndex = 54;
            this.lbl_titulo.Text = "Nombre Prod.";
            // 
            // lbl_id_prod
            // 
            this.lbl_id_prod.AutoSize = true;
            this.lbl_id_prod.Location = new System.Drawing.Point(22, 95);
            this.lbl_id_prod.Name = "lbl_id_prod";
            this.lbl_id_prod.Size = new System.Drawing.Size(68, 13);
            this.lbl_id_prod.TabIndex = 53;
            this.lbl_id_prod.Text = "Codigo Prod.";
            // 
            // txt_id_prod
            // 
            this.txt_id_prod.Enabled = false;
            this.txt_id_prod.Location = new System.Drawing.Point(117, 92);
            this.txt_id_prod.Name = "txt_id_prod";
            this.txt_id_prod.Size = new System.Drawing.Size(101, 20);
            this.txt_id_prod.TabIndex = 52;
            // 
            // txt_nomb_prod
            // 
            this.txt_nomb_prod.Location = new System.Drawing.Point(117, 133);
            this.txt_nomb_prod.Name = "txt_nomb_prod";
            this.txt_nomb_prod.Size = new System.Drawing.Size(218, 20);
            this.txt_nomb_prod.TabIndex = 51;
            // 
            // FormAltaProductora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(361, 268);
            this.Controls.Add(this.btn_cancel_prod);
            this.Controls.Add(this.btn_alta_prod);
            this.Controls.Add(this.lbl_tit);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_id_prod);
            this.Controls.Add(this.txt_id_prod);
            this.Controls.Add(this.txt_nomb_prod);
            this.Name = "FormAltaProductora";
            this.Text = "FormAltaProductora";
            this.Load += new System.EventHandler(this.FormAltaProductora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_prod;
        private System.Windows.Forms.Button btn_alta_prod;
        private System.Windows.Forms.Label lbl_tit;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_id_prod;
        private System.Windows.Forms.TextBox txt_id_prod;
        private System.Windows.Forms.TextBox txt_nomb_prod;
    }
}