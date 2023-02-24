namespace CP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.GrillaBD = new System.Windows.Forms.DataGridView();
            this.id_pel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_pel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_productora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_pel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_pel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picBPeli = new System.Windows.Forms.PictureBox();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.labelTextoAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPeli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(26, 95);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(158, 36);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.IndianRed;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.Location = new System.Drawing.Point(208, 95);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(158, 36);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(395, 95);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 36);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // GrillaBD
            // 
            this.GrillaBD.BackgroundColor = System.Drawing.Color.White;
            this.GrillaBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pel,
            this.Titulo,
            this.id_director,
            this.desc_pel,
            this.id_categoria,
            this.id_productora,
            this.anio_pel,
            this.cant_pel});
            this.GrillaBD.GridColor = System.Drawing.Color.LightGray;
            this.GrillaBD.Location = new System.Drawing.Point(12, 200);
            this.GrillaBD.Name = "GrillaBD";
            this.GrillaBD.Size = new System.Drawing.Size(1154, 301);
            this.GrillaBD.TabIndex = 3;
            this.GrillaBD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaBD_CellContentClick);
            // 
            // id_pel
            // 
            this.id_pel.HeaderText = "CODIGO";
            this.id_pel.Name = "id_pel";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 200;
            // 
            // id_director
            // 
            this.id_director.HeaderText = "director";
            this.id_director.Name = "id_director";
            this.id_director.Width = 200;
            // 
            // desc_pel
            // 
            this.desc_pel.HeaderText = "descripcion";
            this.desc_pel.Name = "desc_pel";
            this.desc_pel.Width = 200;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "categoria";
            this.id_categoria.Name = "id_categoria";
            // 
            // id_productora
            // 
            this.id_productora.HeaderText = "productora";
            this.id_productora.Name = "id_productora";
            // 
            // anio_pel
            // 
            this.anio_pel.HeaderText = "anio";
            this.anio_pel.Name = "anio_pel";
            // 
            // cant_pel
            // 
            this.cant_pel.HeaderText = "cantidad";
            this.cant_pel.Name = "cant_pel";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(23, 164);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(50, 13);
            this.lblbuscar.TabIndex = 4;
            this.lblbuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(72, 161);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1091, 521);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picBPeli
            // 
            this.picBPeli.BackColor = System.Drawing.Color.Black;
            this.picBPeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBPeli.Image = ((System.Drawing.Image)(resources.GetObject("picBPeli.Image")));
            this.picBPeli.Location = new System.Drawing.Point(965, 31);
            this.picBPeli.Name = "picBPeli";
            this.picBPeli.Size = new System.Drawing.Size(176, 119);
            this.picBPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBPeli.TabIndex = 7;
            this.picBPeli.TabStop = false;
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.BackColor = System.Drawing.Color.Lavender;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo1.Location = new System.Drawing.Point(66, 31);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Size = new System.Drawing.Size(487, 33);
            this.labeltitulo1.TabIndex = 8;
            this.labeltitulo1.Text = "BASE DE DATOS DE PELICULAS";
            // 
            // labelTextoAdvertencia
            // 
            this.labelTextoAdvertencia.AutoSize = true;
            this.labelTextoAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.labelTextoAdvertencia.Location = new System.Drawing.Point(434, 168);
            this.labelTextoAdvertencia.Name = "labelTextoAdvertencia";
            this.labelTextoAdvertencia.Size = new System.Drawing.Size(732, 13);
            this.labelTextoAdvertencia.TabIndex = 9;
            this.labelTextoAdvertencia.Text = "IMPORTANTE: DEBE SELECCIONAR TODA LA FILA DE LA PELÍCULA QUE DESEA DAR DE BAJA O " +
    "MODIFICAR ANTES DE APRETAR EL BOTÓN\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1178, 556);
            this.Controls.Add(this.labelTextoAdvertencia);
            this.Controls.Add(this.labeltitulo1);
            this.Controls.Add(this.picBPeli);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.GrillaBD);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBPeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView GrillaBD;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picBPeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_director;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_productora;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_pel;
        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.Label labelTextoAdvertencia;
    }
}