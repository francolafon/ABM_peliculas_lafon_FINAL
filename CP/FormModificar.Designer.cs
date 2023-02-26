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
            button3 = new Button();
            btn_modificar_pel = new Button();
            txt_cantidad = new TextBox();
            label1 = new Label();
            lbl_tit = new Label();
            lbl_cant = new Label();
            lbl_desc_pel = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            lbl_categoria = new Label();
            cb_prod = new ComboBox();
            lbl_product = new Label();
            cb_dir = new ComboBox();
            lbl_dir = new Label();
            lbl_titulo = new Label();
            lbl_id_pel = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(432, 544);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 27);
            button3.TabIndex = 43;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_modificar_pel
            // 
            btn_modificar_pel.BackColor = Color.AntiqueWhite;
            btn_modificar_pel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_modificar_pel.Location = new Point(169, 518);
            btn_modificar_pel.Margin = new Padding(4, 3, 4, 3);
            btn_modificar_pel.Name = "btn_modificar_pel";
            btn_modificar_pel.Size = new Size(161, 53);
            btn_modificar_pel.TabIndex = 42;
            btn_modificar_pel.Text = "MODIFICAR";
            btn_modificar_pel.UseVisualStyleBackColor = false;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(151, 480);
            txt_cantidad.Margin = new Padding(4, 3, 4, 3);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(117, 23);
            txt_cantidad.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Location = new Point(38, 341);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 40;
            label1.Text = "Fecha de estreno";
            // 
            // lbl_tit
            // 
            lbl_tit.AutoSize = true;
            lbl_tit.BackColor = Color.Tan;
            lbl_tit.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tit.Location = new Point(169, 19);
            lbl_tit.Margin = new Padding(4, 0, 4, 0);
            lbl_tit.Name = "lbl_tit";
            lbl_tit.Size = new Size(220, 27);
            lbl_tit.TabIndex = 39;
            lbl_tit.Text = "MODIFICAR PELICULA";
            // 
            // lbl_cant
            // 
            lbl_cant.AutoSize = true;
            lbl_cant.BackColor = Color.Tan;
            lbl_cant.Location = new Point(47, 488);
            lbl_cant.Margin = new Padding(4, 0, 4, 0);
            lbl_cant.Name = "lbl_cant";
            lbl_cant.Size = new Size(55, 15);
            lbl_cant.TabIndex = 37;
            lbl_cant.Text = "Cantidad";
            // 
            // lbl_desc_pel
            // 
            lbl_desc_pel.AutoSize = true;
            lbl_desc_pel.BackColor = Color.Tan;
            lbl_desc_pel.Location = new Point(44, 273);
            lbl_desc_pel.Margin = new Padding(4, 0, 4, 0);
            lbl_desc_pel.Name = "lbl_desc_pel";
            lbl_desc_pel.Size = new Size(69, 15);
            lbl_desc_pel.TabIndex = 36;
            lbl_desc_pel.Text = "Descripción";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 265);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(332, 23);
            textBox3.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 224);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 23);
            comboBox1.TabIndex = 34;
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.BackColor = Color.Tan;
            lbl_categoria.Location = new Point(44, 232);
            lbl_categoria.Margin = new Padding(4, 0, 4, 0);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(58, 15);
            lbl_categoria.TabIndex = 33;
            lbl_categoria.Text = "Categoría";
            // 
            // cb_prod
            // 
            cb_prod.FormattingEnabled = true;
            cb_prod.Location = new Point(144, 181);
            cb_prod.Margin = new Padding(4, 3, 4, 3);
            cb_prod.Name = "cb_prod";
            cb_prod.Size = new Size(227, 23);
            cb_prod.TabIndex = 31;
            // 
            // lbl_product
            // 
            lbl_product.AutoSize = true;
            lbl_product.BackColor = Color.Tan;
            lbl_product.Location = new Point(44, 189);
            lbl_product.Margin = new Padding(4, 0, 4, 0);
            lbl_product.Name = "lbl_product";
            lbl_product.Size = new Size(66, 15);
            lbl_product.TabIndex = 30;
            lbl_product.Text = "Productora";
            // 
            // cb_dir
            // 
            cb_dir.FormattingEnabled = true;
            cb_dir.Location = new Point(144, 145);
            cb_dir.Margin = new Padding(4, 3, 4, 3);
            cb_dir.Name = "cb_dir";
            cb_dir.Size = new Size(227, 23);
            cb_dir.TabIndex = 28;
            // 
            // lbl_dir
            // 
            lbl_dir.AutoSize = true;
            lbl_dir.BackColor = Color.Tan;
            lbl_dir.Location = new Point(44, 148);
            lbl_dir.Margin = new Padding(4, 0, 4, 0);
            lbl_dir.Name = "lbl_dir";
            lbl_dir.Size = new Size(49, 15);
            lbl_dir.TabIndex = 27;
            lbl_dir.Text = "Director";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Tan;
            lbl_titulo.Location = new Point(44, 113);
            lbl_titulo.Margin = new Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(37, 15);
            lbl_titulo.TabIndex = 26;
            lbl_titulo.Text = "Título";
            // 
            // lbl_id_pel
            // 
            lbl_id_pel.AutoSize = true;
            lbl_id_pel.BackColor = Color.Tan;
            lbl_id_pel.Location = new Point(44, 80);
            lbl_id_pel.Margin = new Padding(4, 0, 4, 0);
            lbl_id_pel.Name = "lbl_id_pel";
            lbl_id_pel.Size = new Size(90, 15);
            lbl_id_pel.TabIndex = 25;
            lbl_id_pel.Text = "Codigo Pelicula";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(144, 72);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 110);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 23;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(144, 306);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 44;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.Movie_aesthetic_uwu;
            ClientSize = new Size(533, 585);
            Controls.Add(monthCalendar1);
            Controls.Add(button3);
            Controls.Add(btn_modificar_pel);
            Controls.Add(txt_cantidad);
            Controls.Add(label1);
            Controls.Add(lbl_tit);
            Controls.Add(lbl_cant);
            Controls.Add(lbl_desc_pel);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(lbl_categoria);
            Controls.Add(cb_prod);
            Controls.Add(lbl_product);
            Controls.Add(cb_dir);
            Controls.Add(lbl_dir);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_id_pel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormModificar";
            Text = "Form1";
            Load += FormModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_modificar_pel;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tit;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_desc_pel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cb_prod;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.ComboBox cb_dir;
        private System.Windows.Forms.Label lbl_dir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_id_pel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MonthCalendar monthCalendar1;
    }
}