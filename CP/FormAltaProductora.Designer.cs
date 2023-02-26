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
            btn_cancel_prod = new Button();
            btn_alta_prod = new Button();
            lbl_tit = new Label();
            lbl_titulo = new Label();
            lbl_id_prod = new Label();
            txt_id_prod = new TextBox();
            txt_nomb_prod = new TextBox();
            SuspendLayout();
            // 
            // btn_cancel_prod
            // 
            btn_cancel_prod.Location = new Point(321, 273);
            btn_cancel_prod.Margin = new Padding(4, 3, 4, 3);
            btn_cancel_prod.Name = "btn_cancel_prod";
            btn_cancel_prod.Size = new Size(88, 27);
            btn_cancel_prod.TabIndex = 57;
            btn_cancel_prod.Text = "Volver";
            btn_cancel_prod.UseVisualStyleBackColor = true;
            btn_cancel_prod.Click += btn_cancel_prod_Click;
            // 
            // btn_alta_prod
            // 
            btn_alta_prod.BackColor = Color.Gold;
            btn_alta_prod.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_alta_prod.Location = new Point(126, 247);
            btn_alta_prod.Margin = new Padding(4, 3, 4, 3);
            btn_alta_prod.Name = "btn_alta_prod";
            btn_alta_prod.Size = new Size(161, 53);
            btn_alta_prod.TabIndex = 56;
            btn_alta_prod.Text = "Alta";
            btn_alta_prod.UseVisualStyleBackColor = false;
            // 
            // lbl_tit
            // 
            lbl_tit.AutoSize = true;
            lbl_tit.BackColor = Color.AntiqueWhite;
            lbl_tit.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tit.Location = new Point(179, 25);
            lbl_tit.Margin = new Padding(4, 0, 4, 0);
            lbl_tit.Name = "lbl_tit";
            lbl_tit.Size = new Size(172, 27);
            lbl_tit.TabIndex = 55;
            lbl_tit.Text = "Alta Productoras";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.AntiqueWhite;
            lbl_titulo.Location = new Point(26, 157);
            lbl_titulo.Margin = new Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(82, 15);
            lbl_titulo.TabIndex = 54;
            lbl_titulo.Text = "Nombre Prod.";
            // 
            // lbl_id_prod
            // 
            lbl_id_prod.AutoSize = true;
            lbl_id_prod.BackColor = Color.AntiqueWhite;
            lbl_id_prod.Location = new Point(26, 110);
            lbl_id_prod.Margin = new Padding(4, 0, 4, 0);
            lbl_id_prod.Name = "lbl_id_prod";
            lbl_id_prod.Size = new Size(77, 15);
            lbl_id_prod.TabIndex = 53;
            lbl_id_prod.Text = "Codigo Prod.";
            // 
            // txt_id_prod
            // 
            txt_id_prod.Enabled = false;
            txt_id_prod.Location = new Point(136, 106);
            txt_id_prod.Margin = new Padding(4, 3, 4, 3);
            txt_id_prod.Name = "txt_id_prod";
            txt_id_prod.Size = new Size(117, 23);
            txt_id_prod.TabIndex = 52;
            // 
            // txt_nomb_prod
            // 
            txt_nomb_prod.Location = new Point(136, 153);
            txt_nomb_prod.Margin = new Padding(4, 3, 4, 3);
            txt_nomb_prod.Name = "txt_nomb_prod";
            txt_nomb_prod.Size = new Size(254, 23);
            txt_nomb_prod.TabIndex = 51;
            // 
            // FormAltaProductora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources._0081b6169b11a806603d770b179f974a;
            ClientSize = new Size(514, 328);
            Controls.Add(btn_cancel_prod);
            Controls.Add(btn_alta_prod);
            Controls.Add(lbl_tit);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_id_prod);
            Controls.Add(txt_id_prod);
            Controls.Add(txt_nomb_prod);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAltaProductora";
            Text = "FormAltaProductora";
            Load += FormAltaProductora_Load;
            ResumeLayout(false);
            PerformLayout();
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