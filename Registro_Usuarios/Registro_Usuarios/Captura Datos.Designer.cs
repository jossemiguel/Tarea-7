namespace Registro_Usuarios
{
    partial class Registro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextID = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextEdad = new System.Windows.Forms.TextBox();
            this.TextGuardar = new System.Windows.Forms.Button();
            this.Despliegue = new System.Windows.Forms.DataGridView();
            this.TextModificar = new System.Windows.Forms.Button();
            this.TextEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Despliegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(87, 38);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(76, 20);
            this.TextID.TabIndex = 0;
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(87, 90);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(149, 20);
            this.TextNombre.TabIndex = 1;
            // 
            // TextApellidos
            // 
            this.TextApellidos.Location = new System.Drawing.Point(87, 141);
            this.TextApellidos.Name = "TextApellidos";
            this.TextApellidos.Size = new System.Drawing.Size(149, 20);
            this.TextApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // TextEdad
            // 
            this.TextEdad.Location = new System.Drawing.Point(87, 211);
            this.TextEdad.Name = "TextEdad";
            this.TextEdad.Size = new System.Drawing.Size(76, 20);
            this.TextEdad.TabIndex = 7;
            // 
            // TextGuardar
            // 
            this.TextGuardar.Location = new System.Drawing.Point(12, 351);
            this.TextGuardar.Name = "TextGuardar";
            this.TextGuardar.Size = new System.Drawing.Size(79, 47);
            this.TextGuardar.TabIndex = 8;
            this.TextGuardar.Text = "Guardar";
            this.TextGuardar.UseVisualStyleBackColor = true;
            this.TextGuardar.Click += new System.EventHandler(this.TextGuardar_Click);
            // 
            // Despliegue
            // 
            this.Despliegue.AllowUserToAddRows = false;
            this.Despliegue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Despliegue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Despliegue.DefaultCellStyle = dataGridViewCellStyle8;
            this.Despliegue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Despliegue.Location = new System.Drawing.Point(-3, 248);
            this.Despliegue.Name = "Despliegue";
            this.Despliegue.ReadOnly = true;
            this.Despliegue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Despliegue.Size = new System.Drawing.Size(512, 97);
            this.Despliegue.TabIndex = 9;
            this.Despliegue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Despliegue_CellContentClick);
            // 
            // TextModificar
            // 
            this.TextModificar.Location = new System.Drawing.Point(205, 351);
            this.TextModificar.Name = "TextModificar";
            this.TextModificar.Size = new System.Drawing.Size(79, 47);
            this.TextModificar.TabIndex = 10;
            this.TextModificar.Text = "Midificar";
            this.TextModificar.UseVisualStyleBackColor = true;
            this.TextModificar.Click += new System.EventHandler(this.TextModificar_Click);
            // 
            // TextEliminar
            // 
            this.TextEliminar.Location = new System.Drawing.Point(376, 351);
            this.TextEliminar.Name = "TextEliminar";
            this.TextEliminar.Size = new System.Drawing.Size(79, 47);
            this.TextEliminar.TabIndex = 11;
            this.TextEliminar.Text = "Eliminar";
            this.TextEliminar.UseVisualStyleBackColor = true;
            this.TextEliminar.Click += new System.EventHandler(this.TextEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar nombre";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(275, 218);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(136, 20);
            this.textBuscar.TabIndex = 13;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Foto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registro de Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(332, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 123);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Fecha
            // 
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Fecha.Location = new System.Drawing.Point(51, 167);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 17;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(510, 393);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextEliminar);
            this.Controls.Add(this.TextModificar);
            this.Controls.Add(this.Despliegue);
            this.Controls.Add(this.TextGuardar);
            this.Controls.Add(this.TextEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextApellidos);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextID);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resgistro de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Despliegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextEdad;
        private System.Windows.Forms.Button TextGuardar;
        private System.Windows.Forms.DataGridView Despliegue;
        private System.Windows.Forms.Button TextModificar;
        private System.Windows.Forms.Button TextEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Fecha;
    }
}

