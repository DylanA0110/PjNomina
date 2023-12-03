namespace UINomina
{
    partial class FrmEditarComision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarComision));
            panel3 = new Panel();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            btnEditar = new Button();
            label1 = new Label();
            cmbPorcentajeComisiones = new ComboBox();
            label4 = new Label();
            cmbMetaventas = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cmbCargo = new ComboBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(233, 92, 116);
            panel3.Controls.Add(PBMinimizar);
            panel3.Controls.Add(PBCerrar);
            panel3.Location = new Point(2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(912, 29);
            panel3.TabIndex = 64;
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
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 92, 116);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 92, 116);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(421, 248);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(63, 39);
            btnEditar.TabIndex = 59;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(388, 53);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 61;
            label1.Text = "Editar Comision";
            // 
            // cmbPorcentajeComisiones
            // 
            cmbPorcentajeComisiones.BackColor = Color.FromArgb(233, 92, 116);
            cmbPorcentajeComisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPorcentajeComisiones.FlatStyle = FlatStyle.Flat;
            cmbPorcentajeComisiones.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPorcentajeComisiones.ForeColor = Color.White;
            cmbPorcentajeComisiones.FormattingEnabled = true;
            cmbPorcentajeComisiones.Location = new Point(602, 151);
            cmbPorcentajeComisiones.Name = "cmbPorcentajeComisiones";
            cmbPorcentajeComisiones.Size = new Size(161, 24);
            cmbPorcentajeComisiones.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(602, 123);
            label4.Name = "label4";
            label4.Size = new Size(159, 16);
            label4.TabIndex = 69;
            label4.Text = "Porcentaje de comision";
            // 
            // cmbMetaventas
            // 
            cmbMetaventas.BackColor = Color.FromArgb(233, 92, 116);
            cmbMetaventas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetaventas.FlatStyle = FlatStyle.Flat;
            cmbMetaventas.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMetaventas.ForeColor = Color.White;
            cmbMetaventas.FormattingEnabled = true;
            cmbMetaventas.Location = new Point(371, 151);
            cmbMetaventas.Name = "cmbMetaventas";
            cmbMetaventas.Size = new Size(161, 24);
            cmbMetaventas.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(399, 123);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 67;
            label3.Text = "Meta ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 123);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 66;
            label2.Text = "Cargo";
            // 
            // cmbCargo
            // 
            cmbCargo.BackColor = Color.FromArgb(233, 92, 116);
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FlatStyle = FlatStyle.Flat;
            cmbCargo.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCargo.ForeColor = Color.White;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(149, 151);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(161, 24);
            cmbCargo.TabIndex = 65;
            // 
            // FrmEditarComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(913, 299);
            Controls.Add(cmbPorcentajeComisiones);
            Controls.Add(label4);
            Controls.Add(cmbMetaventas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCargo);
            Controls.Add(panel3);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarComision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarComision";
            Load += FrmEditarComision_Load;
            MouseDown += FrmEditarComision_MouseDown;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private PictureBox PBMinimizar;
        private PictureBox PBCerrar;
        private Button btnEditar;
        private Label label1;
        private ComboBox cmbPorcentajeComisiones;
        private Label label4;
        private ComboBox cmbMetaventas;
        private Label label3;
        private Label label2;
        private ComboBox cmbCargo;
    }
}