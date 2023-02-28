namespace CP
{
    partial class FormModificar
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

        #region Windows Form Designer generated code

        #endregion
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.btn_modificar_pel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tit = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_desc_pel = new System.Windows.Forms.Label();
            this.txt_desc_mod = new System.Windows.Forms.TextBox();
            this.cb_cat_mod = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cb_prod_mod = new System.Windows.Forms.ComboBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.cb_dir_mod = new System.Windows.Forms.ComboBox();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_titulo_pel_mod = new System.Windows.Forms.TextBox();
            this.nud_cant_mod = new System.Windows.Forms.NumericUpDown();
            this.dtp_pel_mod = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_mod)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 544);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 43;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_modificar_pel
            // 
            this.btn_modificar_pel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_modificar_pel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_modificar_pel.Location = new System.Drawing.Point(169, 518);
            this.btn_modificar_pel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_modificar_pel.Name = "btn_modificar_pel";
            this.btn_modificar_pel.Size = new System.Drawing.Size(161, 53);
            this.btn_modificar_pel.TabIndex = 42;
            this.btn_modificar_pel.Text = "MODIFICAR";
            this.btn_modificar_pel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(38, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha de estreno";
            // 
            // lbl_tit
            // 
            this.lbl_tit.AutoSize = true;
            this.lbl_tit.BackColor = System.Drawing.Color.Tan;
            this.lbl_tit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tit.Location = new System.Drawing.Point(169, 19);
            this.lbl_tit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tit.Name = "lbl_tit";
            this.lbl_tit.Size = new System.Drawing.Size(220, 27);
            this.lbl_tit.TabIndex = 39;
            this.lbl_tit.Text = "MODIFICAR PELICULA";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.BackColor = System.Drawing.Color.Tan;
            this.lbl_cant.Location = new System.Drawing.Point(38, 391);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(55, 15);
            this.lbl_cant.TabIndex = 37;
            this.lbl_cant.Text = "Cantidad";
            // 
            // lbl_desc_pel
            // 
            this.lbl_desc_pel.AutoSize = true;
            this.lbl_desc_pel.BackColor = System.Drawing.Color.Tan;
            this.lbl_desc_pel.Location = new System.Drawing.Point(44, 273);
            this.lbl_desc_pel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc_pel.Name = "lbl_desc_pel";
            this.lbl_desc_pel.Size = new System.Drawing.Size(69, 15);
            this.lbl_desc_pel.TabIndex = 36;
            this.lbl_desc_pel.Text = "Descripción";
            // 
            // txt_desc_mod
            // 
            this.txt_desc_mod.Location = new System.Drawing.Point(144, 265);
            this.txt_desc_mod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_desc_mod.Name = "txt_desc_mod";
            this.txt_desc_mod.Size = new System.Drawing.Size(332, 23);
            this.txt_desc_mod.TabIndex = 35;
            this.txt_desc_mod.TextChanged += new System.EventHandler(this.txt_desc_mod_TextChanged);
            // 
            // cb_cat_mod
            // 
            this.cb_cat_mod.FormattingEnabled = true;
            this.cb_cat_mod.Location = new System.Drawing.Point(144, 224);
            this.cb_cat_mod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_cat_mod.Name = "cb_cat_mod";
            this.cb_cat_mod.Size = new System.Drawing.Size(227, 23);
            this.cb_cat_mod.TabIndex = 34;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.BackColor = System.Drawing.Color.Tan;
            this.lbl_categoria.Location = new System.Drawing.Point(44, 232);
            this.lbl_categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_categoria.TabIndex = 33;
            this.lbl_categoria.Text = "Categoría";
            // 
            // cb_prod_mod
            // 
            this.cb_prod_mod.FormattingEnabled = true;
            this.cb_prod_mod.Location = new System.Drawing.Point(144, 181);
            this.cb_prod_mod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_prod_mod.Name = "cb_prod_mod";
            this.cb_prod_mod.Size = new System.Drawing.Size(227, 23);
            this.cb_prod_mod.TabIndex = 31;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.BackColor = System.Drawing.Color.Tan;
            this.lbl_product.Location = new System.Drawing.Point(44, 189);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(66, 15);
            this.lbl_product.TabIndex = 30;
            this.lbl_product.Text = "Productora";
            // 
            // cb_dir_mod
            // 
            this.cb_dir_mod.FormattingEnabled = true;
            this.cb_dir_mod.Location = new System.Drawing.Point(144, 145);
            this.cb_dir_mod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_dir_mod.Name = "cb_dir_mod";
            this.cb_dir_mod.Size = new System.Drawing.Size(227, 23);
            this.cb_dir_mod.TabIndex = 28;
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.BackColor = System.Drawing.Color.Tan;
            this.lbl_dir.Location = new System.Drawing.Point(44, 148);
            this.lbl_dir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(49, 15);
            this.lbl_dir.TabIndex = 27;
            this.lbl_dir.Text = "Director";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Tan;
            this.lbl_titulo.Location = new System.Drawing.Point(44, 113);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(37, 15);
            this.lbl_titulo.TabIndex = 26;
            this.lbl_titulo.Text = "Título";
            // 
            // txt_titulo_pel_mod
            // 
            this.txt_titulo_pel_mod.Location = new System.Drawing.Point(144, 110);
            this.txt_titulo_pel_mod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_titulo_pel_mod.Name = "txt_titulo_pel_mod";
            this.txt_titulo_pel_mod.Size = new System.Drawing.Size(332, 23);
            this.txt_titulo_pel_mod.TabIndex = 23;
            // 
            // nud_cant_mod
            // 
            this.nud_cant_mod.Location = new System.Drawing.Point(144, 389);
            this.nud_cant_mod.Name = "nud_cant_mod";
            this.nud_cant_mod.Size = new System.Drawing.Size(120, 23);
            this.nud_cant_mod.TabIndex = 45;
            // 
            // dtp_pel_mod
            // 
            this.dtp_pel_mod.Location = new System.Drawing.Point(144, 335);
            this.dtp_pel_mod.Name = "dtp_pel_mod";
            this.dtp_pel_mod.Size = new System.Drawing.Size(227, 23);
            this.dtp_pel_mod.TabIndex = 44;
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::CP.Properties.Resources.Movie_aesthetic_uwu;
            this.ClientSize = new System.Drawing.Size(533, 585);
            this.Controls.Add(this.nud_cant_mod);
            this.Controls.Add(this.dtp_pel_mod);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_modificar_pel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tit);
            this.Controls.Add(this.lbl_cant);
            this.Controls.Add(this.lbl_desc_pel);
            this.Controls.Add(this.txt_desc_mod);
            this.Controls.Add(this.cb_cat_mod);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.cb_prod_mod);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.cb_dir_mod);
            this.Controls.Add(this.lbl_dir);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_titulo_pel_mod);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormModificar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_mod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_modificar_pel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tit;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_desc_pel;
        private System.Windows.Forms.TextBox txt_desc_mod;
        private System.Windows.Forms.ComboBox cb_cat_mod;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cb_prod_mod;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.ComboBox cb_dir_mod;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_titulo_pel_mod;
        private NumericUpDown nud_cant_mod;
        private DateTimePicker dtp_pel_mod;
    }
}