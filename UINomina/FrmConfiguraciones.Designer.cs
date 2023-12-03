namespace UINomina
{
    partial class FrmConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguraciones));
            groupBox1 = new GroupBox();
            Esconder = new PictureBox();
            Ver = new PictureBox();
            txtRol = new TextBox();
            label11 = new Label();
            txtTelefono = new TextBox();
            label10 = new Label();
            txtFechaNacimiento = new TextBox();
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
            lstUsuarios = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            btnEditarUsuarios = new Button();
            pbEditar = new PictureBox();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            lbTituloEdit = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Esconder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Esconder);
            groupBox1.Controls.Add(Ver);
            groupBox1.Controls.Add(txtRol);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtFechaNacimiento);
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
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 177);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Basicos";
            // 
            // Esconder
            // 
            Esconder.Image = (Image)resources.GetObject("Esconder.Image");
            Esconder.Location = new Point(335, 113);
            Esconder.Name = "Esconder";
            Esconder.Size = new Size(27, 23);
            Esconder.TabIndex = 26;
            Esconder.TabStop = false;
            Esconder.Click += Esconder_Click;
            // 
            // Ver
            // 
            Ver.Image = Properties.Resources.ver;
            Ver.Location = new Point(335, 112);
            Ver.Name = "Ver";
            Ver.Size = new Size(27, 23);
            Ver.TabIndex = 25;
            Ver.TabStop = false;
            Ver.Visible = false;
            Ver.Click += Ver_Click;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(679, 113);
            txtRol.Name = "txtRol";
            txtRol.ReadOnly = true;
            txtRol.Size = new Size(143, 23);
            txtRol.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(679, 93);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 23;
            label11.Text = "Rol:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(530, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(143, 23);
            txtTelefono.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(530, 93);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 21;
            label10.Text = "Telefono:";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(670, 51);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.ReadOnly = true;
            txtFechaNacimiento.Size = new Size(143, 23);
            txtFechaNacimiento.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(670, 31);
            label9.Name = "label9";
            label9.Size = new Size(152, 17);
            label9.TabIndex = 19;
            label9.Text = "Fecha de Nacimiento:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(368, 113);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(143, 23);
            txtCorreo.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(368, 93);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 17;
            label8.Text = "Correo:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(186, 113);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ReadOnly = true;
            txtContraseña.Size = new Size(143, 23);
            txtContraseña.TabIndex = 16;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(186, 93);
            label7.Name = "label7";
            label7.Size = new Size(84, 17);
            label7.TabIndex = 15;
            label7.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(15, 113);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(143, 23);
            txtUser.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 93);
            label6.Name = "label6";
            label6.Size = new Size(136, 17);
            label6.TabIndex = 13;
            label6.Text = "Nombre de usuario:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(503, 51);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.ReadOnly = true;
            txtSegundoApellido.Size = new Size(143, 23);
            txtSegundoApellido.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(503, 31);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 11;
            label5.Text = "Segundo apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(346, 51);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(143, 23);
            txtApellido.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(346, 31);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 9;
            label4.Text = "Primer Apellido:";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(186, 51);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.ReadOnly = true;
            txtSegundoNombre.Size = new Size(143, 23);
            txtSegundoNombre.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(186, 31);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 7;
            label3.Text = "Segundo nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // lstUsuarios
            // 
            lstUsuarios.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            lstUsuarios.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsuarios.GridLines = true;
            lstUsuarios.Location = new Point(12, 358);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(1102, 276);
            lstUsuarios.TabIndex = 3;
            lstUsuarios.UseCompatibleStateImageBehavior = false;
            lstUsuarios.View = View.Details;
            lstUsuarios.Visible = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Segundo Nombre";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Primer Apellido";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Segundo Apellido";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Usuario";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Correo Electronico";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 180;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fecha Nacimiento";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fecha de Registro";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Ultimo Acceso";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 180;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Rol";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 140;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Telefono";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 80;
            // 
            // btnEditarUsuarios
            // 
            btnEditarUsuarios.FlatAppearance.BorderSize = 0;
            btnEditarUsuarios.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnEditarUsuarios.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditarUsuarios.FlatStyle = FlatStyle.Flat;
            btnEditarUsuarios.Image = Properties.Resources.editar__1___1_;
            btnEditarUsuarios.Location = new Point(478, 640);
            btnEditarUsuarios.Name = "btnEditarUsuarios";
            btnEditarUsuarios.Size = new Size(83, 40);
            btnEditarUsuarios.TabIndex = 4;
            btnEditarUsuarios.UseVisualStyleBackColor = true;
            btnEditarUsuarios.Visible = false;
            btnEditarUsuarios.Click += btnEditarUsuarios_Click;
            // 
            // pbEditar
            // 
            pbEditar.Image = Properties.Resources.editar;
            pbEditar.Location = new Point(898, 161);
            pbEditar.Name = "pbEditar";
            pbEditar.Size = new Size(73, 36);
            pbEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEditar.TabIndex = 10;
            pbEditar.TabStop = false;
            pbEditar.Click += pbEditar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario__3_;
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 64);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(501, 21);
            label12.Name = "label12";
            label12.Size = new Size(60, 25);
            label12.TabIndex = 13;
            label12.Text = "Perfil";
            // 
            // lbTituloEdit
            // 
            lbTituloEdit.AutoSize = true;
            lbTituloEdit.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloEdit.Location = new Point(452, 292);
            lbTituloEdit.Name = "lbTituloEdit";
            lbTituloEdit.Size = new Size(159, 25);
            lbTituloEdit.TabIndex = 14;
            lbTituloEdit.Text = "Editar Usuarios";
            lbTituloEdit.Visible = false;
            // 
            // FrmConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1115, 683);
            Controls.Add(lbTituloEdit);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(pbEditar);
            Controls.Add(btnEditarUsuarios);
            Controls.Add(lstUsuarios);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguraciones";
            Text = "FrmConfiguraciones";
            Load += FrmConfiguraciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Esconder).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ListView lstUsuarios;
        private TextBox txtNombre;
        private Label label2;
        private Button btnEditarUsuarios;
        private TextBox txtSegundoApellido;
        private Label label5;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label3;
        private TextBox txtTelefono;
        private Label label10;
        private TextBox txtFechaNacimiento;
        private Label label9;
        private TextBox txtCorreo;
        private Label label8;
        private TextBox txtContraseña;
        private Label label7;
        private TextBox txtUser;
        private Label label6;
        private TextBox txtRol;
        private Label label11;
        private PictureBox Esconder;
        private PictureBox Ver;
        private PictureBox pbEditar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private PictureBox pictureBox1;
        private Label label12;
        private Label lbTituloEdit;
    }
}