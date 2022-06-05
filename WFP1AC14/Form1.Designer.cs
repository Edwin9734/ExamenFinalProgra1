namespace WFP1AC14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonObtenerDatos = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxParcial1 = new System.Windows.Forms.TextBox();
            this.textBoxParcial2 = new System.Windows.Forms.TextBox();
            this.textBoxParcial3 = new System.Windows.Forms.TextBox();
            this.buttonBorrarAlumno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEstante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObtenerDatos
            // 
            this.buttonObtenerDatos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonObtenerDatos.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonObtenerDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonObtenerDatos.Location = new System.Drawing.Point(48, 261);
            this.buttonObtenerDatos.Name = "buttonObtenerDatos";
            this.buttonObtenerDatos.Size = new System.Drawing.Size(248, 55);
            this.buttonObtenerDatos.TabIndex = 0;
            this.buttonObtenerDatos.Text = "Ver Mercaderia";
            this.buttonObtenerDatos.UseVisualStyleBackColor = false;
            this.buttonObtenerDatos.Click += new System.EventHandler(this.buttonObtenerDatos_Click);
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.GridColor = System.Drawing.Color.Cyan;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(837, 29);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowTemplate.Height = 25;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(337, 429);
            this.dataGridViewAlumnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(400, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumBlue;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(403, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumBlue;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(402, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumBlue;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(403, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumBlue;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(401, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(392, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "Control de Mercaderia";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(604, 124);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(173, 23);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(554, 155);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(227, 23);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(554, 184);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(227, 23);
            this.textBoxCorreo.TabIndex = 10;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "Bocadillos",
            "Golosinas",
            "Bebidas"});
            this.comboBoxClase.Location = new System.Drawing.Point(668, 215);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(110, 23);
            this.comboBoxClase.TabIndex = 11;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonConsulta.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConsulta.Location = new System.Drawing.Point(47, 38);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(251, 56);
            this.buttonConsulta.TabIndex = 13;
            this.buttonConsulta.Text = "Buscar Producto";
            this.buttonConsulta.UseVisualStyleBackColor = false;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonActualizar.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonActualizar.Location = new System.Drawing.Point(45, 142);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(251, 56);
            this.buttonActualizar.TabIndex = 15;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonExportar.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExportar.Location = new System.Drawing.Point(45, 380);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(251, 54);
            this.buttonExportar.TabIndex = 17;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumBlue;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(400, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Existencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumBlue;
            this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(400, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ventas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumBlue;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(400, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio";
            // 
            // textBoxParcial1
            // 
            this.textBoxParcial1.Location = new System.Drawing.Point(623, 283);
            this.textBoxParcial1.Name = "textBoxParcial1";
            this.textBoxParcial1.Size = new System.Drawing.Size(154, 23);
            this.textBoxParcial1.TabIndex = 21;
            // 
            // textBoxParcial2
            // 
            this.textBoxParcial2.Location = new System.Drawing.Point(622, 312);
            this.textBoxParcial2.Name = "textBoxParcial2";
            this.textBoxParcial2.Size = new System.Drawing.Size(156, 23);
            this.textBoxParcial2.TabIndex = 22;
            // 
            // textBoxParcial3
            // 
            this.textBoxParcial3.Location = new System.Drawing.Point(621, 341);
            this.textBoxParcial3.Name = "textBoxParcial3";
            this.textBoxParcial3.Size = new System.Drawing.Size(157, 23);
            this.textBoxParcial3.TabIndex = 23;
            // 
            // buttonBorrarAlumno
            // 
            this.buttonBorrarAlumno.BackColor = System.Drawing.Color.Red;
            this.buttonBorrarAlumno.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonBorrarAlumno.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBorrarAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBorrarAlumno.Location = new System.Drawing.Point(467, 427);
            this.buttonBorrarAlumno.Name = "buttonBorrarAlumno";
            this.buttonBorrarAlumno.Size = new System.Drawing.Size(242, 46);
            this.buttonBorrarAlumno.TabIndex = 24;
            this.buttonBorrarAlumno.Text = "Eliminar Poducto";
            this.buttonBorrarAlumno.UseVisualStyleBackColor = false;
            this.buttonBorrarAlumno.UseWaitCursor = true;
            this.buttonBorrarAlumno.Click += new System.EventHandler(this.buttonBorrarAlumno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WFP1AC14.Properties.Resources.png_transparent_computer_icons_google_search_symbol_mobile_search_search_for_miscellaneous_logo_mobile_phones;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(569, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxEstante
            // 
            this.textBoxEstante.Location = new System.Drawing.Point(621, 256);
            this.textBoxEstante.Name = "textBoxEstante";
            this.textBoxEstante.Size = new System.Drawing.Size(157, 23);
            this.textBoxEstante.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImage = global::WFP1AC14.Properties.Resources.a_2022_06_05_105538;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 485);
            this.Controls.Add(this.textBoxEstante);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBorrarAlumno);
            this.Controls.Add(this.textBoxParcial3);
            this.Controls.Add(this.textBoxParcial2);
            this.Controls.Add(this.textBoxParcial1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.buttonObtenerDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonObtenerDatos;
        private DataGridView dataGridViewAlumnos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private Button buttonActualizar;
        private Button buttonExportar;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxParcial1;
        private TextBox textBoxParcial2;
        private TextBox textBoxParcial3;
        private Button buttonBorrarAlumno;
        private PictureBox pictureBox1;
        private TextBox textBoxEstante;
    }
}