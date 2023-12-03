namespace UINomina
{
    partial class FrmEditarCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCargo));
            btnEditar = new Button();
            panel1 = new Panel();
            RBFalseRiesgoLaboral = new RadioButton();
            RBTrueRiesgoLaboral = new RadioButton();
            label2 = new Label();
            panel2 = new Panel();
            RBFalseComisiones = new RadioButton();
            RBTrueComisiones = new RadioButton();
            label6 = new Label();
            txtCargo = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 92, 116);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 92, 116);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(423, 236);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(63, 39);
            btnEditar.TabIndex = 0;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(RBFalseRiesgoLaboral);
            panel1.Controls.Add(RBTrueRiesgoLaboral);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(582, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 115);
            panel1.TabIndex = 55;
            // 
            // RBFalseRiesgoLaboral
            // 
            RBFalseRiesgoLaboral.AutoSize = true;
            RBFalseRiesgoLaboral.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RBFalseRiesgoLaboral.Location = new Point(28, 75);
            RBFalseRiesgoLaboral.Name = "RBFalseRiesgoLaboral";
            RBFalseRiesgoLaboral.Size = new Size(43, 20);
            RBFalseRiesgoLaboral.TabIndex = 5;
            RBFalseRiesgoLaboral.TabStop = true;
            RBFalseRiesgoLaboral.Text = "No";
            RBFalseRiesgoLaboral.UseVisualStyleBackColor = true;
            // 
            // RBTrueRiesgoLaboral
            // 
            RBTrueRiesgoLaboral.AutoSize = true;
            RBTrueRiesgoLaboral.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RBTrueRiesgoLaboral.Location = new Point(28, 46);
            RBTrueRiesgoLaboral.Name = "RBTrueRiesgoLaboral";
            RBTrueRiesgoLaboral.Size = new Size(35, 20);
            RBTrueRiesgoLaboral.TabIndex = 4;
            RBTrueRiesgoLaboral.TabStop = true;
            RBTrueRiesgoLaboral.Text = "Sí";
            RBTrueRiesgoLaboral.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(222, 18);
            label2.TabIndex = 32;
            label2.Text = "¿Se le aplica Riesgo laboral?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(RBFalseComisiones);
            panel2.Controls.Add(RBTrueComisiones);
            panel2.Controls.Add(label6);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(326, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 115);
            panel2.TabIndex = 54;
            // 
            // RBFalseComisiones
            // 
            RBFalseComisiones.AutoSize = true;
            RBFalseComisiones.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RBFalseComisiones.Location = new Point(22, 75);
            RBFalseComisiones.Name = "RBFalseComisiones";
            RBFalseComisiones.Size = new Size(42, 20);
            RBFalseComisiones.TabIndex = 3;
            RBFalseComisiones.TabStop = true;
            RBFalseComisiones.Text = "No";
            RBFalseComisiones.UseVisualStyleBackColor = true;
            // 
            // RBTrueComisiones
            // 
            RBTrueComisiones.AutoSize = true;
            RBTrueComisiones.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RBTrueComisiones.Location = new Point(22, 46);
            RBTrueComisiones.Name = "RBTrueComisiones";
            RBTrueComisiones.Size = new Size(34, 20);
            RBTrueComisiones.TabIndex = 2;
            RBTrueComisiones.TabStop = true;
            RBTrueComisiones.Text = "Sí";
            RBTrueComisiones.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 9);
            label6.Name = "label6";
            label6.Size = new Size(199, 18);
            label6.TabIndex = 32;
            label6.Text = "¿Se le aplica comisiones?";
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.Black;
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.ForeColor = Color.White;
            txtCargo.Location = new Point(103, 118);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(168, 16);
            txtCargo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(390, 41);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 6;
            label1.Text = "Editar cargo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(233, 92, 116);
            panel3.Controls.Add(PBMinimizar);
            panel3.Controls.Add(PBCerrar);
            panel3.Location = new Point(2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(912, 29);
            panel3.TabIndex = 57;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // PBMinimizar
            // 
            PBMinimizar.BackColor = Color.FromArgb(233, 92, 116);
            PBMinimizar.Image = Properties.Resources.minimizar_signo;
            PBMinimizar.Location = new Point(833, 0);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(35, 29);
            PBMinimizar.TabIndex = 3;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click;
            // 
            // PBCerrar
            // 
            PBCerrar.BackColor = Color.FromArgb(233, 92, 116);
            PBCerrar.Image = Properties.Resources.cerrar;
            PBCerrar.Location = new Point(874, 0);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(35, 29);
            PBCerrar.TabIndex = 2;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(103, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // FrmEditarCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(913, 299);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(btnEditar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txtCargo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEditarCargo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarCargo";
            Load += FrmEditarCargo_Load;
            MouseDown += FrmEditarCargo_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Panel panel1;
        private RadioButton RBFalseRiesgoLaboral;
        private RadioButton RBTrueRiesgoLaboral;
        private Label label2;
        private Panel panel2;
        private RadioButton RBFalseComisiones;
        private RadioButton RBTrueComisiones;
        private Label label6;
        private TextBox txtCargo;
        private Label label1;
        private Panel panel3;
        private PictureBox PBMinimizar;
        private PictureBox PBCerrar;
        private PictureBox pictureBox2;
    }
}