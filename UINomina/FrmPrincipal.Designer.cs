namespace UINomina
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            subMenuEmpleado = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAggCargo = new Button();
            btnAgregarEmp = new Button();
            panel5 = new Panel();
            lbRol = new Label();
            lbNombres = new Label();
            pictureBox2 = new PictureBox();
            btnPlanilla = new Button();
            btnHome = new Button();
            btnComisiones = new Button();
            btnEmpleados = new Button();
            btnConfig = new Button();
            btnLogOut = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelContenedor = new Panel();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            panel1.SuspendLayout();
            subMenuEmpleado.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 38, 62);
            panel1.Controls.Add(subMenuEmpleado);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnPlanilla);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnComisiones);
            panel1.Controls.Add(btnEmpleados);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 686);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // subMenuEmpleado
            // 
            subMenuEmpleado.Controls.Add(panel2);
            subMenuEmpleado.Controls.Add(panel3);
            subMenuEmpleado.Controls.Add(btnAggCargo);
            subMenuEmpleado.Controls.Add(btnAgregarEmp);
            subMenuEmpleado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            subMenuEmpleado.ForeColor = Color.White;
            subMenuEmpleado.Location = new Point(7, 396);
            subMenuEmpleado.Name = "subMenuEmpleado";
            subMenuEmpleado.Size = new Size(146, 91);
            subMenuEmpleado.TabIndex = 9;
            subMenuEmpleado.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 29);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Location = new Point(0, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 29);
            panel3.TabIndex = 16;
            // 
            // btnAggCargo
            // 
            btnAggCargo.BackgroundImageLayout = ImageLayout.None;
            btnAggCargo.FlatAppearance.BorderSize = 0;
            btnAggCargo.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnAggCargo.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnAggCargo.FlatStyle = FlatStyle.Flat;
            btnAggCargo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAggCargo.ForeColor = Color.White;
            btnAggCargo.ImageAlign = ContentAlignment.MiddleLeft;
            btnAggCargo.Location = new Point(8, 45);
            btnAggCargo.Name = "btnAggCargo";
            btnAggCargo.Padding = new Padding(1, 0, 1, 1);
            btnAggCargo.Size = new Size(139, 30);
            btnAggCargo.TabIndex = 14;
            btnAggCargo.Text = "Agregar Cargo";
            btnAggCargo.UseVisualStyleBackColor = true;
            btnAggCargo.Click += btnAggCargo_Click;
            // 
            // btnAgregarEmp
            // 
            btnAgregarEmp.BackgroundImageLayout = ImageLayout.None;
            btnAgregarEmp.FlatAppearance.BorderSize = 0;
            btnAgregarEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnAgregarEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnAgregarEmp.FlatStyle = FlatStyle.Flat;
            btnAgregarEmp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarEmp.ForeColor = Color.White;
            btnAgregarEmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarEmp.Location = new Point(3, 3);
            btnAgregarEmp.Name = "btnAgregarEmp";
            btnAgregarEmp.Padding = new Padding(1, 0, 1, 1);
            btnAgregarEmp.Size = new Size(139, 30);
            btnAgregarEmp.TabIndex = 10;
            btnAgregarEmp.Text = "Agregar Empleados";
            btnAgregarEmp.UseVisualStyleBackColor = true;
            btnAgregarEmp.Click += btnAgregarEmp_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbRol);
            panel5.Controls.Add(lbNombres);
            panel5.Location = new Point(12, 96);
            panel5.Name = "panel5";
            panel5.Size = new Size(113, 56);
            panel5.TabIndex = 12;
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbRol.ForeColor = Color.White;
            lbRol.Location = new Point(9, 29);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(19, 12);
            lbRol.TabIndex = 11;
            lbRol.Text = "Rol";
            // 
            // lbNombres
            // 
            lbNombres.AutoSize = true;
            lbNombres.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombres.ForeColor = Color.White;
            lbNombres.Location = new Point(9, 2);
            lbNombres.Name = "lbNombres";
            lbNombres.Size = new Size(56, 13);
            lbNombres.TabIndex = 10;
            lbNombres.Text = "Nombres";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario__4_;
            pictureBox2.Location = new Point(30, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnPlanilla
            // 
            btnPlanilla.BackgroundImageLayout = ImageLayout.None;
            btnPlanilla.FlatAppearance.BorderSize = 0;
            btnPlanilla.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnPlanilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnPlanilla.FlatStyle = FlatStyle.Flat;
            btnPlanilla.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlanilla.ForeColor = Color.White;
            btnPlanilla.Image = Properties.Resources.Vector__2_;
            btnPlanilla.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlanilla.Location = new Point(-1, 284);
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.Padding = new Padding(1, 0, 1, 1);
            btnPlanilla.Size = new Size(149, 37);
            btnPlanilla.TabIndex = 8;
            btnPlanilla.Text = "Planilla";
            btnPlanilla.UseVisualStyleBackColor = true;
            btnPlanilla.Click += btnPlanilla_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.Fill;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 158);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(1, 0, 1, 1);
            btnHome.Size = new Size(149, 38);
            btnHome.TabIndex = 7;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnComisiones
            // 
            btnComisiones.BackgroundImageLayout = ImageLayout.None;
            btnComisiones.FlatAppearance.BorderSize = 0;
            btnComisiones.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnComisiones.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnComisiones.FlatStyle = FlatStyle.Flat;
            btnComisiones.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComisiones.ForeColor = Color.White;
            btnComisiones.Image = Properties.Resources.Transaction;
            btnComisiones.ImageAlign = ContentAlignment.MiddleLeft;
            btnComisiones.Location = new Point(3, 225);
            btnComisiones.Name = "btnComisiones";
            btnComisiones.Padding = new Padding(1, 0, 1, 1);
            btnComisiones.Size = new Size(149, 37);
            btnComisiones.TabIndex = 6;
            btnComisiones.Text = "Comisiones";
            btnComisiones.UseVisualStyleBackColor = true;
            btnComisiones.Click += btnComisiones_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackgroundImageLayout = ImageLayout.None;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(-3, 348);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(1, 0, 1, 1);
            btnEmpleados.Size = new Size(149, 33);
            btnEmpleados.TabIndex = 5;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackgroundImage = (Image)resources.GetObject("btnConfig.BackgroundImage");
            btnConfig.BackgroundImageLayout = ImageLayout.None;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(3, 609);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(1, 0, 1, 1);
            btnConfig.Size = new Size(149, 25);
            btnConfig.TabIndex = 4;
            btnConfig.Text = "Configuraciones";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = Properties.Resources.Power_Off;
            btnLogOut.BackgroundImageLayout = ImageLayout.None;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(3, 661);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(1, 0, 1, 1);
            btnLogOut.Size = new Size(149, 25);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 566);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Cuenta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Full_Colour;
            pictureBox1.Location = new Point(7, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 17);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "NOMINA";
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(PBMinimizar);
            panelContenedor.Controls.Add(PBCerrar);
            panelContenedor.Location = new Point(150, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1115, 680);
            panelContenedor.TabIndex = 1;
            // 
            // PBMinimizar
            // 
            PBMinimizar.BackColor = Color.White;
            PBMinimizar.Image = Properties.Resources.minimizar_signo;
            PBMinimizar.Location = new Point(996, 9);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(35, 29);
            PBMinimizar.TabIndex = 3;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click_1;
            // 
            // PBCerrar
            // 
            PBCerrar.BackColor = Color.White;
            PBCerrar.Image = Properties.Resources.cerrar;
            PBCerrar.Location = new Point(1047, 9);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(35, 29);
            PBCerrar.TabIndex = 2;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click_2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            MouseDown += FrmPrincipal_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            subMenuEmpleado.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnLogOut;
        private Button btnConfig;
        private Button btnEmpleados;
        private Button btnComisiones;
        private Button btnHome;
        private Button btnPlanilla;
        private Panel subMenuEmpleado;
        private Button btnAgregarEmp;
        private Panel panel2;
        private Button btnAggCargo;
        private Label label4;
        private Label lbNombres;
        private PictureBox pictureBox2;
        private Label lbRol;
        private Panel panel5;
        private Panel panelContenedor;
        private PictureBox PBMinimizar;
        private PictureBox PBCerrar;
        private Panel panel3;
    }
}