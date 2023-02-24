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
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.lbl_tit = new System.Windows.Forms.Label();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_alta_pel = new System.Windows.Forms.Button();
            this.btn_cancel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_titulo_pel
            // 
            this.txt_titulo_pel.Location = new System.Drawing.Point(123, 137);
            this.txt_titulo_pel.Name = "txt_titulo_pel";
            this.txt_titulo_pel.Size = new System.Drawing.Size(285, 20);
            this.txt_titulo_pel.TabIndex = 0;
            // 
            // txt_id_pel
            // 
            this.txt_id_pel.Enabled = false;
            this.txt_id_pel.Location = new System.Drawing.Point(123, 98);
            this.txt_id_pel.Name = "txt_id_pel";
            this.txt_id_pel.Size = new System.Drawing.Size(101, 20);
            this.txt_id_pel.TabIndex = 1;
            // 
            // lbl_id_pel
            // 
            this.lbl_id_pel.AutoSize = true;
            this.lbl_id_pel.Location = new System.Drawing.Point(37, 101);
            this.lbl_id_pel.Name = "lbl_id_pel";
            this.lbl_id_pel.Size = new System.Drawing.Size(80, 13);
            this.lbl_id_pel.TabIndex = 2;
            this.lbl_id_pel.Text = "Codigo Pelicula";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(38, 140);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(35, 13);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Título";
            // 
            // lbl_dir
            // 
            this.lbl_dir.AutoSize = true;
            this.lbl_dir.Location = new System.Drawing.Point(38, 182);
            this.lbl_dir.Name = "lbl_dir";
            this.lbl_dir.Size = new System.Drawing.Size(44, 13);
            this.lbl_dir.TabIndex = 4;
            this.lbl_dir.Text = "Director";
            // 
            // cb_dir
            // 
            this.cb_dir.FormattingEnabled = true;
            this.cb_dir.Location = new System.Drawing.Point(123, 174);
            this.cb_dir.Name = "cb_dir";
            this.cb_dir.Size = new System.Drawing.Size(195, 21);
            this.cb_dir.TabIndex = 5;
            // 
            // btn_alta_dir
            // 
            this.btn_alta_dir.Location = new System.Drawing.Point(333, 172);
            this.btn_alta_dir.Name = "btn_alta_dir";
            this.btn_alta_dir.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_dir.TabIndex = 6;
            this.btn_alta_dir.Text = "Agregar";
            this.btn_alta_dir.UseVisualStyleBackColor = true;
            this.btn_alta_dir.Click += new System.EventHandler(this.btn_alta_dir_Click);
            // 
            // btn_alta_prod
            // 
            this.btn_alta_prod.Location = new System.Drawing.Point(333, 211);
            this.btn_alta_prod.Name = "btn_alta_prod";
            this.btn_alta_prod.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_prod.TabIndex = 9;
            this.btn_alta_prod.Text = "Agregar";
            this.btn_alta_prod.UseVisualStyleBackColor = true;
            this.btn_alta_prod.Click += new System.EventHandler(this.btn_alta_prod_Click);
            // 
            // cb_prod
            // 
            this.cb_prod.FormattingEnabled = true;
            this.cb_prod.Location = new System.Drawing.Point(123, 213);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(195, 21);
            this.cb_prod.TabIndex = 8;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(38, 221);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(59, 13);
            this.lbl_product.TabIndex = 7;
            this.lbl_product.Text = "Productora";
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(123, 250);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(195, 21);
            this.cb_cat.TabIndex = 11;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(38, 258);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(54, 13);
            this.lbl_categoria.TabIndex = 10;
            this.lbl_categoria.Text = "Categoría";
            // 
            // lbl_desc_pel
            // 
            this.lbl_desc_pel.AutoSize = true;
            this.lbl_desc_pel.Location = new System.Drawing.Point(38, 292);
            this.lbl_desc_pel.Name = "lbl_desc_pel";
            this.lbl_desc_pel.Size = new System.Drawing.Size(63, 13);
            this.lbl_desc_pel.TabIndex = 14;
            this.lbl_desc_pel.Text = "Descripción";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(123, 289);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(285, 20);
            this.txt_desc.TabIndex = 13;
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(37, 361);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(49, 13);
            this.lbl_cant.TabIndex = 16;
            this.lbl_cant.Text = "Cantidad";
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(123, 327);
            this.txt_anio.MaxLength = 4;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(101, 20);
            this.txt_anio.TabIndex = 17;
            // 
            // lbl_tit
            // 
            this.lbl_tit.AutoSize = true;
            this.lbl_tit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tit.Location = new System.Drawing.Point(129, 34);
            this.lbl_tit.Name = "lbl_tit";
            this.lbl_tit.Size = new System.Drawing.Size(201, 27);
            this.lbl_tit.TabIndex = 18;
            this.lbl_tit.Text = "ALTA DE PELICULAS";
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.Location = new System.Drawing.Point(38, 330);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(26, 13);
            this.lbl_anio.TabIndex = 19;
            this.lbl_anio.Text = "Año";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(123, 361);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(101, 20);
            this.txt_cantidad.TabIndex = 20;
            // 
            // btn_alta_pel
            // 
            this.btn_alta_pel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_alta_pel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_pel.Location = new System.Drawing.Point(157, 437);
            this.btn_alta_pel.Name = "btn_alta_pel";
            this.btn_alta_pel.Size = new System.Drawing.Size(138, 46);
            this.btn_alta_pel.TabIndex = 21;
            this.btn_alta_pel.Text = "CARGAR";
            this.btn_alta_pel.UseVisualStyleBackColor = false;
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.Location = new System.Drawing.Point(367, 460);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel1.TabIndex = 22;
            this.btn_cancel1.Text = "Volver";
            this.btn_cancel1.UseVisualStyleBackColor = true;
            this.btn_cancel1.Click += new System.EventHandler(this.btn_cancel1_Click);
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(456, 508);
            this.Controls.Add(this.btn_cancel1);
            this.Controls.Add(this.btn_alta_pel);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_anio);
            this.Controls.Add(this.lbl_tit);
            this.Controls.Add(this.txt_anio);
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
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.Load += new System.EventHandler(this.FormAlta_Load);
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
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label lbl_tit;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_alta_pel;
        private System.Windows.Forms.Button btn_cancel1;
    }
}