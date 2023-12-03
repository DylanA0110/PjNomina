namespace UINomina
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            PBCerrar = new PictureBox();
            PBMinimizar = new PictureBox();
            label1 = new Label();
            btnRegsitrar = new Button();
            txtPrimerNombre = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtSegundoNombre = new TextBox();
            pictureBox4 = new PictureBox();
            txtPrimerApellido = new TextBox();
            pictureBox5 = new PictureBox();
            txtSegundoApellido = new TextBox();
            dtpFechaNac = new DateTimePicker();
            pictureBox6 = new PictureBox();
            txtCorreo = new TextBox();
            pictureBox7 = new PictureBox();
            txtUserRegist = new TextBox();
            pictureBox8 = new PictureBox();
            txtPass = new TextBox();
            pictureBox9 = new PictureBox();
            txtConfirmPass = new TextBox();
            label2 = new Label();
            pictureBox10 = new PictureBox();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // PBCerrar
            // 
            PBCerrar.BackColor = Color.FromArgb(38, 78, 202);
            PBCerrar.Image = Properties.Resources.cerrar;
            PBCerrar.Location = new Point(762, 2);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(35, 29);
            PBCerrar.TabIndex = 0;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click;
            // 
            // PBMinimizar
            // 
            PBMinimizar.BackColor = Color.FromArgb(38, 78, 202);
            PBMinimizar.Image = Properties.Resources.minimizar_signo;
            PBMinimizar.Location = new Point(721, 2);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(35, 29);
            PBMinimizar.TabIndex = 1;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 34);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 2;
            label1.Text = "Registro de Usuario";
            // 
            // btnRegsitrar
            // 
            btnRegsitrar.FlatAppearance.BorderSize = 0;
            btnRegsitrar.FlatStyle = FlatStyle.Flat;
            btnRegsitrar.Image = Properties.Resources.boton_agregar;
            btnRegsitrar.Location = new Point(372, 347);
            btnRegsitrar.Name = "btnRegsitrar";
            btnRegsitrar.Size = new Size(73, 36);
            btnRegsitrar.TabIndex = 0;
            btnRegsitrar.UseVisualStyleBackColor = true;
            btnRegsitrar.Click += btnRegsitrar_Click;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.BackColor = Color.FromArgb(33, 72, 193);
            txtPrimerNombre.BorderStyle = BorderStyle.None;
            txtPrimerNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerNombre.ForeColor = SystemColors.ButtonHighlight;
            txtPrimerNombre.Location = new Point(40, 114);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(147, 15);
            txtPrimerNombre.TabIndex = 1;
            txtPrimerNombre.Text = "Primer nombre";
            txtPrimerNombre.Enter += txtPrimerNombre_Enter;
            txtPrimerNombre.Leave += txtPrimerNombre_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.agregar_usuario;
            pictureBox3.Location = new Point(238, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 74);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 10);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(238, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 10);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.BackColor = Color.FromArgb(33, 72, 193);
            txtSegundoNombre.BorderStyle = BorderStyle.None;
            txtSegundoNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoNombre.ForeColor = SystemColors.ButtonHighlight;
            txtSegundoNombre.Location = new Point(238, 114);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(147, 15);
            txtSegundoNombre.TabIndex = 2;
            txtSegundoNombre.Text = "Segundo nombre";
            txtSegundoNombre.Enter += txtSegundoNombre_Enter;
            txtSegundoNombre.Leave += txtSegundoNombre_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(429, 143);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 10);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(33, 72, 193);
            txtPrimerApellido.BorderStyle = BorderStyle.None;
            txtPrimerApellido.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerApellido.ForeColor = SystemColors.ButtonHighlight;
            txtPrimerApellido.Location = new Point(429, 114);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(147, 15);
            txtPrimerApellido.TabIndex = 3;
            txtPrimerApellido.Text = "Primer apellido";
            txtPrimerApellido.Enter += txtPrimerApellido_Enter;
            txtPrimerApellido.Leave += txtPrimerApellido_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(623, 143);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(173, 10);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.BackColor = Color.FromArgb(33, 72, 193);
            txtSegundoApellido.BorderStyle = BorderStyle.None;
            txtSegundoApellido.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoApellido.ForeColor = SystemColors.ButtonHighlight;
            txtSegundoApellido.Location = new Point(623, 114);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(147, 15);
            txtSegundoApellido.TabIndex = 4;
            txtSegundoApellido.Text = "Segundo apellido";
            txtSegundoApellido.Enter += txtSegundoApellido_Enter;
            txtSegundoApellido.Leave += txtSegundoApellido_Leave;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarForeColor = SystemColors.ButtonHighlight;
            dtpFechaNac.CalendarMonthBackground = Color.FromArgb(38, 78, 202);
            dtpFechaNac.Location = new Point(432, 280);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(170, 23);
            dtpFechaNac.TabIndex = 10;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(40, 219);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(173, 10);
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(33, 72, 193);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = SystemColors.ButtonHighlight;
            txtCorreo.Location = new Point(40, 190);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(147, 15);
            txtCorreo.TabIndex = 5;
            txtCorreo.Text = "Correo electronico";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(238, 219);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(173, 10);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // txtUserRegist
            // 
            txtUserRegist.BackColor = Color.FromArgb(33, 72, 193);
            txtUserRegist.BorderStyle = BorderStyle.None;
            txtUserRegist.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserRegist.ForeColor = SystemColors.ButtonHighlight;
            txtUserRegist.Location = new Point(238, 190);
            txtUserRegist.Name = "txtUserRegist";
            txtUserRegist.Size = new Size(147, 15);
            txtUserRegist.TabIndex = 6;
            txtUserRegist.Text = "Usuario";
            txtUserRegist.Enter += txtUserRegist_Enter;
            txtUserRegist.Leave += txtUserRegist_Leave;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(418, 219);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(173, 10);
            pictureBox8.TabIndex = 25;
            pictureBox8.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(33, 72, 193);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = SystemColors.ButtonHighlight;
            txtPass.Location = new Point(418, 190);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(147, 15);
            txtPass.TabIndex = 7;
            txtPass.Text = "Contraseña";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(609, 219);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(173, 10);
            pictureBox9.TabIndex = 27;
            pictureBox9.TabStop = false;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.FromArgb(33, 72, 193);
            txtConfirmPass.BorderStyle = BorderStyle.None;
            txtConfirmPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.ForeColor = SystemColors.ButtonHighlight;
            txtConfirmPass.Location = new Point(609, 190);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(147, 15);
            txtConfirmPass.TabIndex = 8;
            txtConfirmPass.Text = "Repetir contraseña";
            txtConfirmPass.Enter += txtConfirmPass_Enter;
            txtConfirmPass.Leave += txtConfirmPass_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(429, 257);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 28;
            label2.Text = "Fecha de nacimiento";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(247, 287);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(173, 10);
            pictureBox10.TabIndex = 30;
            pictureBox10.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(33, 72, 193);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = SystemColors.ButtonHighlight;
            txtTelefono.Location = new Point(247, 258);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(147, 15);
            txtTelefono.TabIndex = 9;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 72, 193);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(807, 406);
            Controls.Add(pictureBox10);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(pictureBox9);
            Controls.Add(txtConfirmPass);
            Controls.Add(pictureBox8);
            Controls.Add(txtPass);
            Controls.Add(pictureBox7);
            Controls.Add(txtUserRegist);
            Controls.Add(pictureBox6);
            Controls.Add(txtCorreo);
            Controls.Add(dtpFechaNac);
            Controls.Add(pictureBox5);
            Controls.Add(txtSegundoApellido);
            Controls.Add(pictureBox4);
            Controls.Add(txtPrimerApellido);
            Controls.Add(pictureBox2);
            Controls.Add(txtSegundoNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegsitrar);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(PBMinimizar);
            Controls.Add(PBCerrar);
            Controls.Add(txtPrimerNombre);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            MouseDown += FrmRegister_MouseDown;
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBCerrar;
        private PictureBox PBMinimizar;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox txtPrimerNombre;
        private Button btnRegsitrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtSegundoNombre;
        private PictureBox pictureBox4;
        private TextBox txtPrimerApellido;
        private PictureBox pictureBox5;
        private TextBox txtSegundoApellido;
        private DateTimePicker dtpFechaNac;
        private PictureBox pictureBox6;
        private TextBox txtCorreo;
        private PictureBox pictureBox7;
        private TextBox txtUserRegist;
        private PictureBox pictureBox8;
        private TextBox txtPass;
        private PictureBox pictureBox9;
        private TextBox txtConfirmPass;
        private Label label2;
        private PictureBox pictureBox10;
        private TextBox txtTelefono;
    }
}