namespace UINomina
{
    partial class FrmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
            groupBox1 = new GroupBox();
            txtRol = new TextBox();
            cmbRol = new ComboBox();
            dtFecha = new DateTimePicker();
            txtConfirmPass = new TextBox();
            label1 = new Label();
            label11 = new Label();
            txtTelefono = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtCorreo = new TextBox();
            label8 = new Label();
            txtContraseña = new TextBox();
            label7 = new Label();
            txtUser = new TextBox();
            label6 = new Label();
            txtSegundoApellido = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label12 = new Label();
            pbEditar = new PictureBox();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRol);
            groupBox1.Controls.Add(cmbRol);
            groupBox1.Controls.Add(dtFecha);
            groupBox1.Controls.Add(txtConfirmPass);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSegundoApellido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSegundoNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 208);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Basicos";
            // 
            // txtRol
            // 
            txtRol.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRol.Location = new Point(497, 115);
            txtRol.Name = "txtRol";
            txtRol.ReadOnly = true;
            txtRol.Size = new Size(149, 22);
            txtRol.TabIndex = 29;
            txtRol.Click += txtRol_Click;
            // 
            // cmbRol
            // 
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Gerente", "Contador General", "Asistente Contable" });
            cmbRol.Location = new Point(497, 112);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(149, 25);
            cmbRol.TabIndex = 28;
            cmbRol.Visible = false;
            // 
            // dtFecha
            // 
            dtFecha.CustomFormat = "dd/MM/yyyy";
            dtFecha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtFecha.Location = new Point(652, 51);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(170, 22);
            dtFecha.TabIndex = 5;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.Location = new Point(186, 169);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(143, 22);
            txtConfirmPass.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(186, 149);
            label1.Name = "label1";
            label1.Size = new Size(130, 16);
            label1.TabIndex = 25;
            label1.Text = "Repetir contraseña";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(497, 93);
            label11.Name = "label11";
            label11.Size = new Size(31, 16);
            label11.TabIndex = 23;
            label11.Text = "Rol:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(348, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(143, 22);
            txtTelefono.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(348, 93);
            label10.Name = "label10";
            label10.Size = new Size(65, 16);
            label10.TabIndex = 21;
            label10.Text = "Telefono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(670, 31);
            label9.Name = "label9";
            label9.Size = new Size(150, 16);
            label9.TabIndex = 19;
            label9.Text = "Fecha de Nacimiento:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(186, 113);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(143, 22);
            txtCorreo.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(186, 93);
            label8.Name = "label8";
            label8.Size = new Size(55, 16);
            label8.TabIndex = 17;
            label8.Text = "Correo:";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(15, 169);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(143, 22);
            txtContraseña.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(15, 149);
            label7.Name = "label7";
            label7.Size = new Size(82, 16);
            label7.TabIndex = 15;
            label7.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(15, 113);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(143, 22);
            txtUser.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 93);
            label6.Name = "label6";
            label6.Size = new Size(136, 16);
            label6.TabIndex = 13;
            label6.Text = "Nombre de usuario:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoApellido.Location = new Point(503, 51);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(143, 22);
            txtSegundoApellido.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(503, 31);
            label5.Name = "label5";
            label5.Size = new Size(127, 16);
            label5.TabIndex = 11;
            label5.Text = "Segundo apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(346, 51);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(143, 22);
            txtApellido.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(346, 31);
            label4.Name = "label4";
            label4.Size = new Size(112, 16);
            label4.TabIndex = 9;
            label4.Text = "Primer Apellido:";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoNombre.Location = new Point(186, 51);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(143, 22);
            txtSegundoNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 31);
            label3.Name = "label3";
            label3.Size = new Size(122, 16);
            label3.TabIndex = 7;
            label3.Text = "Segundo nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(15, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 22);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 31);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(367, 9);
            label12.Name = "label12";
            label12.Size = new Size(136, 23);
            label12.TabIndex = 0;
            label12.Text = "Editar Usuario";
            // 
            // pbEditar
            // 
            pbEditar.Image = Properties.Resources.editar;
            pbEditar.Location = new Point(383, 271);
            pbEditar.Name = "pbEditar";
            pbEditar.Size = new Size(73, 32);
            pbEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEditar.TabIndex = 9;
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            // 
            // PBMinimizar
            // 
            PBMinimizar.Image = Properties.Resources.minimizar_signo;
            PBMinimizar.Location = new Point(798, 5);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(33, 27);
            PBMinimizar.TabIndex = 11;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click;
            // 
            // PBCerrar
            // 
            PBCerrar.Image = (Image)resources.GetObject("PBCerrar.Image");
            PBCerrar.Location = new Point(850, 5);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(32, 27);
            PBCerrar.TabIndex = 10;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(288, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 84, 252);
            ClientSize = new Size(903, 311);
            Controls.Add(pictureBox1);
            Controls.Add(PBMinimizar);
            Controls.Add(PBCerrar);
            Controls.Add(pbEditar);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarUsuario";
            Load += FrmEditarUsuario_Load;
            MouseDown += FrmEditarUsuario_MouseDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtTelefono;
        private Label label10;
        private Label label9;
        private TextBox txtCorreo;
        private Label label8;
        private TextBox txtContraseña;
        private Label label7;
        private TextBox txtUser;
        private Label label6;
        private TextBox txtSegundoApellido;
        private Label label5;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private DateTimePicker dtFecha;
        private TextBox txtConfirmPass;
        private Label label1;
        private Label label12;
        private PictureBox pbEditar;
        private PictureBox PBMinimizar;
        private PictureBox PBCerrar;
        private PictureBox pictureBox1;
        private ComboBox cmbRol;
        private TextBox txtRol;
    }
}