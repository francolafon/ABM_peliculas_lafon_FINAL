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
            txt_titulo_pel = new TextBox();
            txt_id_pel = new TextBox();
            lbl_id_pel = new Label();
            lbl_titulo = new Label();
            lbl_dir = new Label();
            cb_dir = new ComboBox();
            btn_alta_dir = new Button();
            btn_alta_prod = new Button();
            cb_prod = new ComboBox();
            lbl_product = new Label();
            cb_cat = new ComboBox();
            lbl_categoria = new Label();
            lbl_desc_pel = new Label();
            txt_desc = new TextBox();
            lbl_cant = new Label();
            lbl_tit = new Label();
            lbl_anio = new Label();
            txt_cantidad = new TextBox();
            btn_alta_pel = new Button();
            btn_cancel1 = new Button();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // txt_titulo_pel
            // 
            txt_titulo_pel.Location = new Point(142, 102);
            txt_titulo_pel.Margin = new Padding(4, 3, 4, 3);
            txt_titulo_pel.Name = "txt_titulo_pel";
            txt_titulo_pel.Size = new Size(332, 23);
            txt_titulo_pel.TabIndex = 0;
            // 
            // txt_id_pel
            // 
            txt_id_pel.Enabled = false;
            txt_id_pel.Location = new Point(142, 68);
            txt_id_pel.Margin = new Padding(4, 3, 4, 3);
            txt_id_pel.Name = "txt_id_pel";
            txt_id_pel.Size = new Size(117, 23);
            txt_id_pel.TabIndex = 1;
            // 
            // lbl_id_pel
            // 
            lbl_id_pel.AutoSize = true;
            lbl_id_pel.BackColor = Color.Tan;
            lbl_id_pel.Location = new Point(44, 71);
            lbl_id_pel.Margin = new Padding(4, 0, 4, 0);
            lbl_id_pel.Name = "lbl_id_pel";
            lbl_id_pel.Size = new Size(90, 15);
            lbl_id_pel.TabIndex = 2;
            lbl_id_pel.Text = "Codigo Pelicula";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Tan;
            lbl_titulo.Location = new Point(44, 105);
            lbl_titulo.Margin = new Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(37, 15);
            lbl_titulo.TabIndex = 3;
            lbl_titulo.Text = "Título";
            // 
            // lbl_dir
            // 
            lbl_dir.AutoSize = true;
            lbl_dir.BackColor = Color.Tan;
            lbl_dir.Location = new Point(44, 139);
            lbl_dir.Margin = new Padding(4, 0, 4, 0);
            lbl_dir.Name = "lbl_dir";
            lbl_dir.Size = new Size(49, 15);
            lbl_dir.TabIndex = 4;
            lbl_dir.Text = "Director";
            // 
            // cb_dir
            // 
            cb_dir.FormattingEnabled = true;
            cb_dir.Location = new Point(144, 136);
            cb_dir.Margin = new Padding(4, 3, 4, 3);
            cb_dir.Name = "cb_dir";
            cb_dir.Size = new Size(227, 23);
            cb_dir.TabIndex = 5;
            // 
            // btn_alta_dir
            // 
            btn_alta_dir.BackColor = Color.Tan;
            btn_alta_dir.Location = new Point(388, 136);
            btn_alta_dir.Margin = new Padding(4, 3, 4, 3);
            btn_alta_dir.Name = "btn_alta_dir";
            btn_alta_dir.Size = new Size(88, 27);
            btn_alta_dir.TabIndex = 6;
            btn_alta_dir.Text = "Agregar";
            btn_alta_dir.UseVisualStyleBackColor = false;
            btn_alta_dir.Click += btn_alta_dir_Click;
            // 
            // btn_alta_prod
            // 
            btn_alta_prod.BackColor = Color.Tan;
            btn_alta_prod.Location = new Point(388, 177);
            btn_alta_prod.Margin = new Padding(4, 3, 4, 3);
            btn_alta_prod.Name = "btn_alta_prod";
            btn_alta_prod.Size = new Size(88, 27);
            btn_alta_prod.TabIndex = 9;
            btn_alta_prod.Text = "Agregar";
            btn_alta_prod.UseVisualStyleBackColor = false;
            btn_alta_prod.Click += btn_alta_prod_Click;
            // 
            // cb_prod
            // 
            cb_prod.FormattingEnabled = true;
            cb_prod.Location = new Point(142, 174);
            cb_prod.Margin = new Padding(4, 3, 4, 3);
            cb_prod.Name = "cb_prod";
            cb_prod.Size = new Size(227, 23);
            cb_prod.TabIndex = 8;
            // 
            // lbl_product
            // 
            lbl_product.AutoSize = true;
            lbl_product.BackColor = Color.Tan;
            lbl_product.Location = new Point(43, 177);
            lbl_product.Margin = new Padding(4, 0, 4, 0);
            lbl_product.Name = "lbl_product";
            lbl_product.Size = new Size(66, 15);
            lbl_product.TabIndex = 7;
            lbl_product.Text = "Productora";
            // 
            // cb_cat
            // 
            cb_cat.FormattingEnabled = true;
            cb_cat.Location = new Point(142, 219);
            cb_cat.Margin = new Padding(4, 3, 4, 3);
            cb_cat.Name = "cb_cat";
            cb_cat.Size = new Size(227, 23);
            cb_cat.TabIndex = 11;
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.BackColor = Color.Tan;
            lbl_categoria.Location = new Point(44, 222);
            lbl_categoria.Margin = new Padding(4, 0, 4, 0);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(58, 15);
            lbl_categoria.TabIndex = 10;
            lbl_categoria.Text = "Categoría";
            // 
            // lbl_desc_pel
            // 
            lbl_desc_pel.AutoSize = true;
            lbl_desc_pel.BackColor = Color.Tan;
            lbl_desc_pel.Location = new Point(44, 259);
            lbl_desc_pel.Margin = new Padding(4, 0, 4, 0);
            lbl_desc_pel.Name = "lbl_desc_pel";
            lbl_desc_pel.Size = new Size(69, 15);
            lbl_desc_pel.TabIndex = 14;
            lbl_desc_pel.Text = "Descripción";
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(142, 259);
            txt_desc.Margin = new Padding(4, 3, 4, 3);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(332, 23);
            txt_desc.TabIndex = 13;
            // 
            // lbl_cant
            // 
            lbl_cant.AutoSize = true;
            lbl_cant.BackColor = Color.Tan;
            lbl_cant.Location = new Point(43, 472);
            lbl_cant.Margin = new Padding(4, 0, 4, 0);
            lbl_cant.Name = "lbl_cant";
            lbl_cant.Size = new Size(55, 15);
            lbl_cant.TabIndex = 16;
            lbl_cant.Text = "Cantidad";
            // 
            // lbl_tit
            // 
            lbl_tit.AutoSize = true;
            lbl_tit.BackColor = Color.Tan;
            lbl_tit.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tit.Location = new Point(170, 21);
            lbl_tit.Margin = new Padding(4, 0, 4, 0);
            lbl_tit.Name = "lbl_tit";
            lbl_tit.Size = new Size(201, 27);
            lbl_tit.TabIndex = 18;
            lbl_tit.Text = "ALTA DE PELICULAS";
            // 
            // lbl_anio
            // 
            lbl_anio.AutoSize = true;
            lbl_anio.BackColor = Color.Tan;
            lbl_anio.Location = new Point(35, 362);
            lbl_anio.Margin = new Padding(4, 0, 4, 0);
            lbl_anio.Name = "lbl_anio";
            lbl_anio.Size = new Size(96, 15);
            lbl_anio.TabIndex = 19;
            lbl_anio.Text = "Fecha de estreno";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(144, 469);
            txt_cantidad.Margin = new Padding(4, 3, 4, 3);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(117, 23);
            txt_cantidad.TabIndex = 20;
            // 
            // btn_alta_pel
            // 
            btn_alta_pel.BackColor = Color.AntiqueWhite;
            btn_alta_pel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_alta_pel.Location = new Point(181, 521);
            btn_alta_pel.Margin = new Padding(4, 3, 4, 3);
            btn_alta_pel.Name = "btn_alta_pel";
            btn_alta_pel.Size = new Size(161, 53);
            btn_alta_pel.TabIndex = 21;
            btn_alta_pel.Text = "CARGAR";
            btn_alta_pel.UseVisualStyleBackColor = false;
            // 
            // btn_cancel1
            // 
            btn_cancel1.Location = new Point(431, 547);
            btn_cancel1.Margin = new Padding(4, 3, 4, 3);
            btn_cancel1.Name = "btn_cancel1";
            btn_cancel1.Size = new Size(88, 27);
            btn_cancel1.TabIndex = 22;
            btn_cancel1.Text = "Volver";
            btn_cancel1.UseVisualStyleBackColor = true;
            btn_cancel1.Click += btn_cancel1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.AccessibleRole = AccessibleRole.Cursor;
            monthCalendar1.BackColor = Color.Gray;
            monthCalendar1.Location = new Point(144, 295);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
            monthCalendar1.TrailingForeColor = SystemColors.ButtonFace;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.Movie_aesthetic_uwu;
            ClientSize = new Size(532, 586);
            Controls.Add(monthCalendar1);
            Controls.Add(btn_cancel1);
            Controls.Add(btn_alta_pel);
            Controls.Add(txt_cantidad);
            Controls.Add(lbl_anio);
            Controls.Add(lbl_tit);
            Controls.Add(lbl_cant);
            Controls.Add(lbl_desc_pel);
            Controls.Add(txt_desc);
            Controls.Add(cb_cat);
            Controls.Add(lbl_categoria);
            Controls.Add(btn_alta_prod);
            Controls.Add(cb_prod);
            Controls.Add(lbl_product);
            Controls.Add(btn_alta_dir);
            Controls.Add(cb_dir);
            Controls.Add(lbl_dir);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_id_pel);
            Controls.Add(txt_id_pel);
            Controls.Add(txt_titulo_pel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_alta_pel;
        private System.Windows.Forms.Button btn_cancel1;
        private MonthCalendar monthCalendar1;
    }
}