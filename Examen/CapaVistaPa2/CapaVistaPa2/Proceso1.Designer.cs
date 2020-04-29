namespace CapaVistaPa2
{
    partial class Proceso1
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
            this.Dgb_pedidosEspeciales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_detalle = new System.Windows.Forms.GroupBox();
            this.Txt_nota = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbalumno = new CapaVista.Combo();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcurso = new CapaVista.Combo();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbaula = new CapaVista.Combo();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbseccion = new CapaVista.Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbjor = new CapaVista.Combo();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsede = new CapaVista.Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcarrera = new CapaVista.Combo();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.enviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbfacultades = new CapaVista.Combo();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_pedidosEspeciales)).BeginInit();
            this.grb_detalle.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgb_pedidosEspeciales
            // 
            this.Dgb_pedidosEspeciales.AllowUserToAddRows = false;
            this.Dgb_pedidosEspeciales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgb_pedidosEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_pedidosEspeciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgb_pedidosEspeciales.Location = new System.Drawing.Point(10, 627);
            this.Dgb_pedidosEspeciales.Name = "Dgb_pedidosEspeciales";
            this.Dgb_pedidosEspeciales.ReadOnly = true;
            this.Dgb_pedidosEspeciales.RowHeadersWidth = 51;
            this.Dgb_pedidosEspeciales.RowTemplate.Height = 24;
            this.Dgb_pedidosEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgb_pedidosEspeciales.Size = new System.Drawing.Size(800, 154);
            this.Dgb_pedidosEspeciales.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Carrera";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cod sede";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cod Jornada";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cod Seccion";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cod aula";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cod Curso";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Carnet alumno";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nota asignada";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // grb_detalle
            // 
            this.grb_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grb_detalle.Controls.Add(this.cmbfacultades);
            this.grb_detalle.Controls.Add(this.label13);
            this.grb_detalle.Controls.Add(this.Txt_nota);
            this.grb_detalle.Controls.Add(this.label12);
            this.grb_detalle.Controls.Add(this.cmbalumno);
            this.grb_detalle.Controls.Add(this.label7);
            this.grb_detalle.Controls.Add(this.cmbcurso);
            this.grb_detalle.Controls.Add(this.label10);
            this.grb_detalle.Controls.Add(this.cmbaula);
            this.grb_detalle.Controls.Add(this.label11);
            this.grb_detalle.Controls.Add(this.cmbseccion);
            this.grb_detalle.Controls.Add(this.label4);
            this.grb_detalle.Controls.Add(this.cmbjor);
            this.grb_detalle.Controls.Add(this.label6);
            this.grb_detalle.Controls.Add(this.cmbsede);
            this.grb_detalle.Controls.Add(this.label1);
            this.grb_detalle.Controls.Add(this.cmbcarrera);
            this.grb_detalle.Controls.Add(this.tableLayoutPanel4);
            this.grb_detalle.Controls.Add(this.tableLayoutPanel2);
            this.grb_detalle.Controls.Add(this.label3);
            this.grb_detalle.ForeColor = System.Drawing.Color.Black;
            this.grb_detalle.Location = new System.Drawing.Point(10, 167);
            this.grb_detalle.Name = "grb_detalle";
            this.grb_detalle.Size = new System.Drawing.Size(800, 429);
            this.grb_detalle.TabIndex = 18;
            this.grb_detalle.TabStop = false;
            this.grb_detalle.Text = "Asignacion Cursos Alumno";
            // 
            // Txt_nota
            // 
            this.Txt_nota.Location = new System.Drawing.Point(145, 371);
            this.Txt_nota.Name = "Txt_nota";
            this.Txt_nota.Size = new System.Drawing.Size(148, 30);
            this.Txt_nota.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Carrera";
            // 
            // cmbalumno
            // 
            this.cmbalumno.Location = new System.Drawing.Point(145, 283);
            this.cmbalumno.Margin = new System.Windows.Forms.Padding(21);
            this.cmbalumno.Name = "cmbalumno";
            this.cmbalumno.Size = new System.Drawing.Size(202, 39);
            this.cmbalumno.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Alumno";
            // 
            // cmbcurso
            // 
            this.cmbcurso.Location = new System.Drawing.Point(145, 247);
            this.cmbcurso.Margin = new System.Windows.Forms.Padding(15);
            this.cmbcurso.Name = "cmbcurso";
            this.cmbcurso.Size = new System.Drawing.Size(202, 37);
            this.cmbcurso.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Curso";
            // 
            // cmbaula
            // 
            this.cmbaula.Location = new System.Drawing.Point(145, 212);
            this.cmbaula.Margin = new System.Windows.Forms.Padding(15);
            this.cmbaula.Name = "cmbaula";
            this.cmbaula.Size = new System.Drawing.Size(202, 35);
            this.cmbaula.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Aula";
            // 
            // cmbseccion
            // 
            this.cmbseccion.Location = new System.Drawing.Point(145, 178);
            this.cmbseccion.Margin = new System.Windows.Forms.Padding(15);
            this.cmbseccion.Name = "cmbseccion";
            this.cmbseccion.Size = new System.Drawing.Size(202, 34);
            this.cmbseccion.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Seccion";
            // 
            // cmbjor
            // 
            this.cmbjor.Location = new System.Drawing.Point(145, 135);
            this.cmbjor.Margin = new System.Windows.Forms.Padding(11);
            this.cmbjor.Name = "cmbjor";
            this.cmbjor.Size = new System.Drawing.Size(202, 34);
            this.cmbjor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Jornada";
            // 
            // cmbsede
            // 
            this.cmbsede.Location = new System.Drawing.Point(145, 96);
            this.cmbsede.Margin = new System.Windows.Forms.Padding(11);
            this.cmbsede.Name = "cmbsede";
            this.cmbsede.Size = new System.Drawing.Size(202, 27);
            this.cmbsede.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sede";
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.Location = new System.Drawing.Point(145, 55);
            this.cmbcarrera.Margin = new System.Windows.Forms.Padding(8);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(202, 36);
            this.cmbcarrera.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.enviar, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(595, 147);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(96, 100);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.enviar.BackgroundImage = global::CapaVistaPa2.Properties.Resources._157_paper_plane;
            this.enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enviar.FlatAppearance.BorderSize = 0;
            this.enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.ForeColor = System.Drawing.Color.Black;
            this.enviar.Location = new System.Drawing.Point(3, 59);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(90, 38);
            this.enviar.TabIndex = 10;
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 56);
            this.label2.TabIndex = 14;
            this.label2.Text = "Asignar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_agregar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Btn_eliminar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(377, 147);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 100);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregar.BackgroundImage = global::CapaVistaPa2.Properties.Resources._144_add_file;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregar.Location = new System.Drawing.Point(3, 53);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(87, 40);
            this.Btn_agregar.TabIndex = 11;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.BackgroundImage = global::CapaVistaPa2.Properties.Resources._243_exit;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminar.Location = new System.Drawing.Point(96, 53);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(91, 40);
            this.Btn_eliminar.TabIndex = 12;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "Agregar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(96, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 50);
            this.label9.TabIndex = 16;
            this.label9.Text = "Eliminar ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Carrera";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2208F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 150);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.pictureBox1.BackgroundImage = global::CapaVistaPa2.Properties.Resources.personas;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(683, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 144);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(674, 150);
            this.label5.TabIndex = 8;
            this.label5.Text = "Asignacion de cursos a alumnos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbfacultades
            // 
            this.cmbfacultades.Location = new System.Drawing.Point(145, 325);
            this.cmbfacultades.Margin = new System.Windows.Forms.Padding(29, 29, 29, 29);
            this.cmbfacultades.Name = "cmbfacultades";
            this.cmbfacultades.Size = new System.Drawing.Size(202, 33);
            this.cmbfacultades.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 23);
            this.label13.TabIndex = 37;
            this.label13.Text = "Facultades";
            // 
            // Proceso1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(822, 793);
            this.Controls.Add(this.Dgb_pedidosEspeciales);
            this.Controls.Add(this.grb_detalle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Proceso1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_pedidosEspeciales)).EndInit();
            this.grb_detalle.ResumeLayout(false);
            this.grb_detalle.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgb_pedidosEspeciales;
        private System.Windows.Forms.GroupBox grb_detalle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox Txt_nota;
        private System.Windows.Forms.Label label12;
        private CapaVista.Combo cmbalumno;
        private System.Windows.Forms.Label label7;
        private CapaVista.Combo cmbcurso;
        private System.Windows.Forms.Label label10;
        private CapaVista.Combo cmbaula;
        private System.Windows.Forms.Label label11;
        private CapaVista.Combo cmbseccion;
        private System.Windows.Forms.Label label4;
        private CapaVista.Combo cmbjor;
        private System.Windows.Forms.Label label6;
        private CapaVista.Combo cmbsede;
        private System.Windows.Forms.Label label1;
        private CapaVista.Combo cmbcarrera;
        private CapaVista.Combo cmbfacultades;
        private System.Windows.Forms.Label label13;
    }
}