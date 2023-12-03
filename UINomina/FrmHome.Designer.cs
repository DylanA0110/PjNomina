namespace UINomina
{
    partial class FrmHome
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
            label2 = new Label();
            lbCantidadUser = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lbCantidadEmp = new Label();
            panelCantidades = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCantidades.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(505, 24);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Home";
            // 
            // lbCantidadUser
            // 
            lbCantidadUser.AutoSize = true;
            lbCantidadUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbCantidadUser.Location = new Point(397, 86);
            lbCantidadUser.Margin = new Padding(6, 0, 6, 0);
            lbCantidadUser.Name = "lbCantidadUser";
            lbCantidadUser.Size = new Size(24, 25);
            lbCantidadUser.TabIndex = 2;
            lbCantidadUser.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario__1_;
            pictureBox1.Location = new Point(28, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 64);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 86);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(357, 25);
            label3.TabIndex = 14;
            label3.Text = "Usuarios registrados en el sistema:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(508, 86);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 17;
            label1.Text = "Empleados registrados:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.empleado;
            pictureBox2.Location = new Point(548, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 64);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // lbCantidadEmp
            // 
            lbCantidadEmp.AutoSize = true;
            lbCantidadEmp.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbCantidadEmp.Location = new Point(768, 86);
            lbCantidadEmp.Margin = new Padding(6, 0, 6, 0);
            lbCantidadEmp.Name = "lbCantidadEmp";
            lbCantidadEmp.Size = new Size(24, 25);
            lbCantidadEmp.TabIndex = 15;
            lbCantidadEmp.Text = "0";
            // 
            // panelCantidades
            // 
            panelCantidades.Controls.Add(label3);
            panelCantidades.Controls.Add(pictureBox2);
            panelCantidades.Controls.Add(label1);
            panelCantidades.Controls.Add(pictureBox1);
            panelCantidades.Controls.Add(lbCantidadUser);
            panelCantidades.Controls.Add(lbCantidadEmp);
            panelCantidades.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelCantidades.ForeColor = Color.Black;
            panelCantidades.Location = new Point(110, 148);
            panelCantidades.Name = "panelCantidades";
            panelCantidades.Size = new Size(913, 168);
            panelCantidades.TabIndex = 18;
            panelCantidades.Visible = false;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1115, 683);
            Controls.Add(panelCantidades);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FrmHome";
            Text = "FrmHome";
            Load += FrmHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCantidades.ResumeLayout(false);
            panelCantidades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private Button button1;
        private Label label2;
        private Label lbCantidadUser;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Label lbCantidadEmp;
        private Panel panelCantidades;
    }
}