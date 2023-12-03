namespace UINomina
{
    partial class FrmComisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComisiones));
            label1 = new Label();
            cmbCargo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbMetaventas = new ComboBox();
            cmbPorcentajeComisiones = new ComboBox();
            label4 = new Label();
            lvComisiones = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(39, 38, 44);
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(417, 69);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Comisiones";
            // 
            // cmbCargo
            // 
            cmbCargo.BackColor = Color.FromArgb(64, 68, 237);
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FlatStyle = FlatStyle.Flat;
            cmbCargo.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCargo.ForeColor = Color.White;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(181, 197);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(161, 24);
            cmbCargo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(39, 38, 44);
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 169);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 3;
            label2.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(39, 38, 44);
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(431, 169);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 4;
            label3.Text = "Meta ventas";
            // 
            // cmbMetaventas
            // 
            cmbMetaventas.BackColor = Color.FromArgb(64, 68, 237);
            cmbMetaventas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetaventas.FlatStyle = FlatStyle.Flat;
            cmbMetaventas.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMetaventas.ForeColor = Color.White;
            cmbMetaventas.FormattingEnabled = true;
            cmbMetaventas.Location = new Point(403, 197);
            cmbMetaventas.Name = "cmbMetaventas";
            cmbMetaventas.Size = new Size(161, 24);
            cmbMetaventas.TabIndex = 5;
            // 
            // cmbPorcentajeComisiones
            // 
            cmbPorcentajeComisiones.BackColor = Color.FromArgb(64, 68, 237);
            cmbPorcentajeComisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPorcentajeComisiones.FlatStyle = FlatStyle.Flat;
            cmbPorcentajeComisiones.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPorcentajeComisiones.ForeColor = Color.White;
            cmbPorcentajeComisiones.FormattingEnabled = true;
            cmbPorcentajeComisiones.Location = new Point(634, 197);
            cmbPorcentajeComisiones.Name = "cmbPorcentajeComisiones";
            cmbPorcentajeComisiones.Size = new Size(161, 24);
            cmbPorcentajeComisiones.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(39, 38, 44);
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(634, 169);
            label4.Name = "label4";
            label4.Size = new Size(159, 16);
            label4.TabIndex = 6;
            label4.Text = "Porcentaje de comision";
            // 
            // lvComisiones
            // 
            lvComisiones.BackColor = Color.White;
            lvComisiones.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvComisiones.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvComisiones.ForeColor = Color.Black;
            lvComisiones.FullRowSelect = true;
            lvComisiones.GridLines = true;
            lvComisiones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvComisiones.Location = new Point(169, 353);
            lvComisiones.MultiSelect = false;
            lvComisiones.Name = "lvComisiones";
            lvComisiones.Size = new Size(671, 158);
            lvComisiones.TabIndex = 8;
            lvComisiones.UseCompatibleStateImageBehavior = false;
            lvComisiones.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cargo";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Meta de Ventas";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Porcentaje de comision";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 190;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.Transparent;
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.Location = new Point(848, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(71, 38);
            btnAgregar.TabIndex = 9;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = Properties.Resources.editar__1___1_;
            btnEditar.Location = new Point(857, 388);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 44);
            btnEditar.TabIndex = 10;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(857, 456);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 44);
            btnEliminar.TabIndex = 11;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmComisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = Properties.Resources.login__1_;
            ClientSize = new Size(1115, 680);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(lvComisiones);
            Controls.Add(cmbPorcentajeComisiones);
            Controls.Add(label4);
            Controls.Add(cmbMetaventas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCargo);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComisiones";
            Text = "FrmComisiones";
            Load += FrmComisiones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCargo;
        private Label label2;
        private Label label3;
        private ComboBox cmbMetaventas;
        private ComboBox cmbPorcentajeComisiones;
        private Label label4;
        private ListView lvComisiones;
        private Button btnAgregar;
        private Button btnEditar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnEliminar;
    }
}