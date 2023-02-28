namespace CP
{
    partial class FormAlta
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
            this.txt_titulo_pel = new System.Windows.Forms.TextBox();
            this.txt_id_pel = new System.Windows.Forms.TextBox();
            this.lbl_id_pel = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_dir = new System.Windows.Forms.Label();
            this.cb_dir = new System.Windows.Forms.ComboBox();
            this.btn_alta_dir = new System.Windows.Forms.Button();
            this.btn_alta_prod = new System.Windows.Forms.Button();
            this.cb_prod = new System.Windows.Forms.ComboBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_desc_pel = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_tit = new System.Windows.Forms.Label();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.btn_alta_pel = new System.Windows.Forms.Button();
            this.btn_cancel1 = new System.Windows.Forms.Button();
            this.cal_pel = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cal_pel_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_titulo_pel
            // 
            this.txt_titulo_pel.Location = new System.Drawing.Point(142, 105);
            this.txt_titulo_pel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_titulo_pel.Name = "txt_titulo_pel";
            this.txt_titulo_pel.Size = new System.Drawing.Size(332, 23);
            this.txt_titulo_pel.TabIndex = 0;
            // 
            // txt_id_pel
            // 
            this.txt_id_pel.Enabled = false;
            this.txt_id_pel.Location = new System.Drawing.Point(142, 68);
            this.txt_id_pel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_id_pel.Name = "txt_id_pel";
            this.txt_id_pel.Size = new System.Drawing.Size(117, 23);
            this.txt_id_pel.TabIndex = 1;
            // 
            // lbl_id_pel
            // 
            this.lbl_id_pel.AutoSize = true;
            this.lbl_id_pel.BackColor = System.Drawing.Color.Tan;
            this.lbl_id_pel.Location = new System.Drawing.Point(44, 71);
            this.lbl_id_pel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_pel.Name = "lbl_id_pel";
            this.lbl_id_pel.Size = new System.Drawing.Size(90, 15);
            this.lbl_id_pel.TabIndex = 2;
            this.lbl_id_pel.Text = "Codigo Pelicula";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Tan;
            this.lbl_titulo.Location = new System.Drawing.Point(44, 105);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(37, 15);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Título";
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.BackColor = System.Drawing.Color.Tan;
            this.lbl_dir.Location = new System.Drawing.Point(44, 139);
            this.lbl_dir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(49, 15);
            this.lbl_dir.TabIndex = 4;
            this.lbl_dir.Text = "Director";
            // 
            // cb_dir
            // 
            this.cb_dir.FormattingEnabled = true;
            this.cb_dir.Location = new System.Drawing.Point(144, 136);
            this.cb_dir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_dir.Name = "cb_dir";
            this.cb_dir.Size = new System.Drawing.Size(227, 23);
            this.cb_dir.TabIndex = 5;
            // 
            // btn_alta_dir
            // 
            this.btn_alta_dir.BackColor = System.Drawing.Color.Tan;
            this.btn_alta_dir.Location = new System.Drawing.Point(388, 136);
            this.btn_alta_dir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_alta_dir.Name = "btn_alta_dir";
            this.btn_alta_dir.Size = new System.Drawing.Size(88, 27);
            this.btn_alta_dir.TabIndex = 6;
            this.btn_alta_dir.Text = "Agregar";
            this.btn_alta_dir.UseVisualStyleBackColor = false;
            this.btn_alta_dir.Click += new System.EventHandler(this.btn_alta_dir_Click_1);
            // 
            // btn_alta_prod
            // 
            this.btn_alta_prod.BackColor = System.Drawing.Color.Tan;
            this.btn_alta_prod.Location = new System.Drawing.Point(388, 177);
            this.btn_alta_prod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_alta_prod.Name = "btn_alta_prod";
            this.btn_alta_prod.Size = new System.Drawing.Size(88, 27);
            this.btn_alta_prod.TabIndex = 9;
            this.btn_alta_prod.Text = "Agregar";
            this.btn_alta_prod.UseVisualStyleBackColor = false;
            this.btn_alta_prod.Click += new System.EventHandler(this.btn_alta_prod_Click_1);
            // 
            // cb_prod
            // 
            this.cb_prod.FormattingEnabled = true;
            this.cb_prod.Location = new System.Drawing.Point(142, 174);
            this.cb_prod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(227, 23);
            this.cb_prod.TabIndex = 8;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.BackColor = System.Drawing.Color.Tan;
            this.lbl_product.Location = new System.Drawing.Point(43, 177);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(66, 15);
            this.lbl_product.TabIndex = 7;
            this.lbl_product.Text = "Productora";
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(142, 219);
            this.cb_cat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(227, 23);
            this.cb_cat.TabIndex = 11;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.BackColor = System.Drawing.Color.Tan;
            this.lbl_categoria.Location = new System.Drawing.Point(44, 222);
            this.lbl_categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_categoria.TabIndex = 10;
            this.lbl_categoria.Text = "Categoría";
            // 
            // lbl_desc_pel
            // 
            this.lbl_desc_pel.AutoSize = true;
            this.lbl_desc_pel.BackColor = System.Drawing.Color.Tan;
            this.lbl_desc_pel.Location = new System.Drawing.Point(44, 259);
            this.lbl_desc_pel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc_pel.Name = "lbl_desc_pel";
            this.lbl_desc_pel.Size = new System.Drawing.Size(69, 15);
            this.lbl_desc_pel.TabIndex = 14;
            this.lbl_desc_pel.Text = "Descripción";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(142, 259);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(332, 23);
            this.txt_desc.TabIndex = 13;
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.BackColor = System.Drawing.Color.Tan;
            this.lbl_cant.Location = new System.Drawing.Point(43, 472);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(55, 15);
            this.lbl_cant.TabIndex = 16;
            this.lbl_cant.Text = "Cantidad";
            // 
            // lbl_tit
            // 
            this.lbl_tit.AutoSize = true;
            this.lbl_tit.BackColor = System.Drawing.Color.Tan;
            this.lbl_tit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tit.Location = new System.Drawing.Point(170, 21);
            this.lbl_tit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tit.Name = "lbl_tit";
            this.lbl_tit.Size = new System.Drawing.Size(201, 27);
            this.lbl_tit.TabIndex = 18;
            this.lbl_tit.Text = "ALTA DE PELICULAS";
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.BackColor = System.Drawing.Color.Tan;
            this.lbl_anio.Location = new System.Drawing.Point(35, 362);
            this.lbl_anio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(96, 15);
            this.lbl_anio.TabIndex = 19;
            this.lbl_anio.Text = "Fecha de estreno";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(144, 469);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(117, 23);
            this.txt_cant.TabIndex = 20;
            // 
            // btn_alta_pel
            // 
            this.btn_alta_pel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_alta_pel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_alta_pel.Location = new System.Drawing.Point(181, 521);
            this.btn_alta_pel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_alta_pel.Name = "btn_alta_pel";
            this.btn_alta_pel.Size = new System.Drawing.Size(161, 53);
            this.btn_alta_pel.TabIndex = 21;
            this.btn_alta_pel.Text = "CARGAR";
            this.btn_alta_pel.UseVisualStyleBackColor = false;
            this.btn_alta_pel.Click += new System.EventHandler(this.btn_alta_pel_Click);
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.Location = new System.Drawing.Point(431, 547);
            this.btn_cancel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(88, 27);
            this.btn_cancel1.TabIndex = 22;
            this.btn_cancel1.Text = "Volver";
            this.btn_cancel1.UseVisualStyleBackColor = true;
            this.btn_cancel1.Click += new System.EventHandler(this.btn_cancel1_Click_1);
            // 
            // cal_pel
            // 
            this.cal_pel.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cal_pel.BackColor = System.Drawing.Color.Gray;
            this.cal_pel.Location = new System.Drawing.Point(144, 295);
            this.cal_pel.Name = "cal_pel";
            this.cal_pel.TabIndex = 23;
            this.cal_pel.TrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 335);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 24;
            // 
            // cal_pel_3
            // 
            this.cal_pel_3.Location = new System.Drawing.Point(357, 464);
            this.cal_pel_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cal_pel_3.Name = "cal_pel_3";
            this.cal_pel_3.Size = new System.Drawing.Size(117, 23);
            this.cal_pel_3.TabIndex = 25;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::CP.Properties.Resources.Movie_aesthetic_uwu;
            this.ClientSize = new System.Drawing.Size(532, 586);
            this.Controls.Add(this.cal_pel_3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cal_pel);
            this.Controls.Add(this.btn_cancel1);
            this.Controls.Add(this.btn_alta_pel);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.lbl_anio);
            this.Controls.Add(this.lbl_tit);
            this.Controls.Add(this.lbl_cant);
            this.Controls.Add(this.lbl_desc_pel);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.btn_alta_prod);
            this.Controls.Add(this.cb_prod);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.btn_alta_dir);
            this.Controls.Add(this.cb_dir);
            this.Controls.Add(this.lbl_dir);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_id_pel);
            this.Controls.Add(this.txt_id_pel);
            this.Controls.Add(this.txt_titulo_pel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_titulo_pel;
        private System.Windows.Forms.TextBox txt_id_pel;
        private System.Windows.Forms.Label lbl_id_pel;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.ComboBox cb_dir;
        private System.Windows.Forms.Button btn_alta_dir;
        private System.Windows.Forms.Button btn_alta_prod;
        private System.Windows.Forms.ComboBox cb_prod;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_desc_pel;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_tit;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Button btn_alta_pel;
        private System.Windows.Forms.Button btn_cancel1;
        private MonthCalendar cal_pel;
        private TextBox textBox1;
        private TextBox cal_pel_3;
        private TextBox lb_id_pel;
    }
}