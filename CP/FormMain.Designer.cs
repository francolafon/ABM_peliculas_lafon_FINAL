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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgv_peliculas = new System.Windows.Forms.DataGridView();
            this.btn_baja_pel = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.Location = new System.Drawing.Point(30, 110);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(184, 42);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(435, 110);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(184, 42);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbuscar.Location = new System.Drawing.Point(13, 212);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(50, 13);
            this.lblbuscar.TabIndex = 4;
            this.lblbuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(71, 208);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(320, 23);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(1304, 549);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.BackColor = System.Drawing.Color.Lavender;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltitulo1.Location = new System.Drawing.Point(30, 25);
            this.labeltitulo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Size = new System.Drawing.Size(169, 33);
            this.labeltitulo1.TabIndex = 8;
            this.labeltitulo1.Text = "CINECLUB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimePicker1.Location = new System.Drawing.Point(1174, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dgv_peliculas
            // 
            this.dgv_peliculas.AllowUserToAddRows = false;
            this.dgv_peliculas.AllowUserToDeleteRows = false;
            this.dgv_peliculas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peliculas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_peliculas.Location = new System.Drawing.Point(30, 255);
            this.dgv_peliculas.Name = "dgv_peliculas";
            this.dgv_peliculas.ReadOnly = true;
            this.dgv_peliculas.RowTemplate.Height = 25;
            this.dgv_peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_peliculas.Size = new System.Drawing.Size(1362, 272);
            this.dgv_peliculas.TabIndex = 11;
            // 
            // btn_baja_pel
            // 
            this.btn_baja_pel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_baja_pel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_baja_pel.Location = new System.Drawing.Point(234, 110);
            this.btn_baja_pel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_baja_pel.Name = "btn_baja_pel";
            this.btn_baja_pel.Size = new System.Drawing.Size(184, 42);
            this.btn_baja_pel.TabIndex = 12;
            this.btn_baja_pel.Text = "BAJA";
            this.btn_baja_pel.UseVisualStyleBackColor = false;
            this.btn_baja_pel.Click += new System.EventHandler(this.btn_baja_pel_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(412, 209);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::CP.Properties.Resources._9859bcf103e15c74671b14f350799207;
            this.ClientSize = new System.Drawing.Size(1418, 600);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_baja_pel);
            this.Controls.Add(this.dgv_peliculas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labeltitulo1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labeltitulo1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgv_peliculas;
        private Button btn_baja_pel;
        private Button btn_buscar;
    }
}