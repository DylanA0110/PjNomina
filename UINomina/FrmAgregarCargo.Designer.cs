namespace UINomina
{
    partial class FrmAgregarCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCargo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtCargo = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            RBFalseComisiones = new RadioButton();
            RBTrueComisiones = new RadioButton();
            label6 = new Label();
            panel1 = new Panel();
            RBFalseRiesgoLaboral = new RadioButton();
            RBTrueRiesgoLaboral = new RadioButton();
            label2 = new Label();
            lvCargos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label3 = new Label();
            btnAgregarCargo = new Button();
            btnEditarCargo = new Button();
            btnEliminarCargo = new Button();
            label4 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            btnRegresar = new Button();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(499, 76);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cargo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_43_Copy__1_;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1124, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.White;
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.ForeColor = Color.Black;
            txtCargo.Location = new Point(174, 168);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(168, 16);
            txtCargo.TabIndex = 4;
            txtCargo.Text = "Nombre de cargo";
            txtCargo.Enter += txtCargo_Enter;
            txtCargo.Leave += txtCargo_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(143, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(RBFalseComisiones);
            panel2.Controls.Add(RBTrueComisiones);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(382, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 115);
            panel2.TabIndex = 43;
            // 
            // RBFalseComisiones
            // 
            RBFalseComisiones.AutoSize = true;
            RBFalseComisiones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBFalseComisiones.Location = new Point(22, 75);
            RBFalseComisiones.Name = "RBFalseComisiones";
            RBFalseComisiones.Size = new Size(45, 21);
            RBFalseComisiones.TabIndex = 37;
            RBFalseComisiones.TabStop = true;
            RBFalseComisiones.Text = "No";
            RBFalseComisiones.UseVisualStyleBackColor = true;
            // 
            // RBTrueComisiones
            // 
            RBTrueComisiones.AutoSize = true;
            RBTrueComisiones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBTrueComisiones.Location = new Point(22, 46);
            RBTrueComisiones.Name = "RBTrueComisiones";
            RBTrueComisiones.Size = new Size(35, 21);
            RBTrueComisiones.TabIndex = 33;
            RBTrueComisiones.TabStop = true;
            RBTrueComisiones.Text = "Sí";
            RBTrueComisiones.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 9);
            label6.Name = "label6";
            label6.Size = new Size(195, 20);
            label6.TabIndex = 32;
            label6.Text = "¿Se le aplica comisiones?";
            // 
            // panel1
            // 
            panel1.Controls.Add(RBFalseRiesgoLaboral);
            panel1.Controls.Add(RBTrueRiesgoLaboral);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(638, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 115);
            panel1.TabIndex = 44;
            // 
            // RBFalseRiesgoLaboral
            // 
            RBFalseRiesgoLaboral.AutoSize = true;
            RBFalseRiesgoLaboral.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBFalseRiesgoLaboral.Location = new Point(28, 75);
            RBFalseRiesgoLaboral.Name = "RBFalseRiesgoLaboral";
            RBFalseRiesgoLaboral.Size = new Size(45, 21);
            RBFalseRiesgoLaboral.TabIndex = 36;
            RBFalseRiesgoLaboral.TabStop = true;
            RBFalseRiesgoLaboral.Text = "No";
            RBFalseRiesgoLaboral.UseVisualStyleBackColor = true;
            // 
            // RBTrueRiesgoLaboral
            // 
            RBTrueRiesgoLaboral.AutoSize = true;
            RBTrueRiesgoLaboral.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBTrueRiesgoLaboral.Location = new Point(28, 46);
            RBTrueRiesgoLaboral.Name = "RBTrueRiesgoLaboral";
            RBTrueRiesgoLaboral.Size = new Size(35, 21);
            RBTrueRiesgoLaboral.TabIndex = 35;
            RBTrueRiesgoLaboral.TabStop = true;
            RBTrueRiesgoLaboral.Text = "Sí";
            RBTrueRiesgoLaboral.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(218, 20);
            label2.TabIndex = 32;
            label2.Text = "¿Se le aplica Riesgo laboral?";
            // 
            // lvCargos
            // 
            lvCargos.BackColor = Color.White;
            lvCargos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvCargos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lvCargos.FullRowSelect = true;
            lvCargos.GridLines = true;
            lvCargos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvCargos.Location = new Point(255, 421);
            lvCargos.MultiSelect = false;
            lvCargos.Name = "lvCargos";
            lvCargos.Size = new Size(636, 205);
            lvCargos.TabIndex = 45;
            lvCargos.UseCompatibleStateImageBehavior = false;
            lvCargos.View = View.Details;
            lvCargos.ItemSelectionChanged += lvCargos_ItemSelectionChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Aplica Comisiones";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Aplica Riesgo Laboral";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 190;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(515, 316);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 46;
            label3.Text = "Editar Cargos";
            // 
            // btnAgregarCargo
            // 
            btnAgregarCargo.FlatAppearance.BorderSize = 0;
            btnAgregarCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnAgregarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnAgregarCargo.FlatStyle = FlatStyle.Flat;
            btnAgregarCargo.Image = (Image)resources.GetObject("btnAgregarCargo.Image");
            btnAgregarCargo.Location = new Point(940, 187);
            btnAgregarCargo.Name = "btnAgregarCargo";
            btnAgregarCargo.Size = new Size(82, 49);
            btnAgregarCargo.TabIndex = 47;
            btnAgregarCargo.UseVisualStyleBackColor = true;
            btnAgregarCargo.Click += btnAgregarCargo_Click;
            // 
            // btnEditarCargo
            // 
            btnEditarCargo.FlatAppearance.BorderSize = 0;
            btnEditarCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnEditarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnEditarCargo.FlatStyle = FlatStyle.Flat;
            btnEditarCargo.Image = Properties.Resources.editar__1___1_;
            btnEditarCargo.Location = new Point(951, 459);
            btnEditarCargo.Name = "btnEditarCargo";
            btnEditarCargo.Size = new Size(63, 46);
            btnEditarCargo.TabIndex = 48;
            btnEditarCargo.UseVisualStyleBackColor = true;
            btnEditarCargo.Click += btnEditarCargo_Click;
            // 
            // btnEliminarCargo
            // 
            btnEliminarCargo.FlatAppearance.BorderSize = 0;
            btnEliminarCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnEliminarCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnEliminarCargo.FlatStyle = FlatStyle.Flat;
            btnEliminarCargo.Image = (Image)resources.GetObject("btnEliminarCargo.Image");
            btnEliminarCargo.Location = new Point(951, 530);
            btnEliminarCargo.Name = "btnEliminarCargo";
            btnEliminarCargo.Size = new Size(63, 46);
            btnEliminarCargo.TabIndex = 49;
            btnEliminarCargo.UseVisualStyleBackColor = true;
            btnEliminarCargo.Click += btnEliminarCargo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(951, 168);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 50;
            label4.Text = "Agregar";
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.White;
            txtBusqueda.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.ForeColor = Color.Black;
            txtBusqueda.Location = new Point(638, 389);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(187, 23);
            txtBusqueda.TabIndex = 52;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(831, 384);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(33, 28);
            btnBuscar.TabIndex = 53;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnRegresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(870, 384);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(33, 28);
            btnRegresar.TabIndex = 54;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(635, 373);
            label5.Name = "label5";
            label5.Size = new Size(76, 16);
            label5.TabIndex = 55;
            label5.Text = "Busqueda:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAgregarCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(1115, 680);
            Controls.Add(label5);
            Controls.Add(btnRegresar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(label4);
            Controls.Add(btnEliminarCargo);
            Controls.Add(btnEditarCargo);
            Controls.Add(btnAgregarCargo);
            Controls.Add(label3);
            Controls.Add(lvCargos);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txtCargo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarCargo";
            Text = "FrmAgregarCargo";
            Load += FrmAgregarCargo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtCargo;
        private PictureBox pictureBox2;
        private Panel panel2;
        private RadioButton RBMixto;
        private RadioButton RBNocturno;
        private RadioButton RBTrueComisiones;
        private Label label6;
        private Panel panel1;
        private Label label2;
        private RadioButton RBFalseRiesgoLaboral;
        private RadioButton RBTrueRiesgoLaboral;
        private ListView lvCargos;
        private Label label3;
        private Button btnAgregarCargo;
        private Button btnEditarCargo;
        private RadioButton RBFalseComisiones;
        private Button btnEliminarCargo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label4;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Button btnRegresar;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}