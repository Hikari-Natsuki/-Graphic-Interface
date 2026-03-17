namespace Escuela
{
    partial class frmRegistroEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEstudiantes));
            panel1 = new Panel();
            btnMenu = new Button();
            cboCarrera = new ComboBox();
            label4 = new Label();
            txtEdadEst = new TextBox();
            label3 = new Label();
            txtNombreEst = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(cboCarrera);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEdadEst);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombreEst);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 266);
            panel1.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(473, 199);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(145, 51);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // cboCarrera
            // 
            cboCarrera.Font = new Font("Arial Narrow", 12F);
            cboCarrera.FormattingEnabled = true;
            cboCarrera.Location = new Point(445, 161);
            cboCarrera.Name = "cboCarrera";
            cboCarrera.Size = new Size(208, 28);
            cboCarrera.TabIndex = 10;
            cboCarrera.Text = "Seleccione...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(295, 169);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 9;
            label4.Text = "Carrera";
            // 
            // txtEdadEst
            // 
            txtEdadEst.Font = new Font("Arial Narrow", 12F);
            txtEdadEst.Location = new Point(445, 111);
            txtEdadEst.Name = "txtEdadEst";
            txtEdadEst.Size = new Size(208, 26);
            txtEdadEst.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(295, 117);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "Edad Estudiante";
            // 
            // txtNombreEst
            // 
            txtNombreEst.Font = new Font("Arial Narrow", 12F);
            txtNombreEst.Location = new Point(446, 60);
            txtNombreEst.Name = "txtNombreEst";
            txtNombreEst.Size = new Size(208, 26);
            txtNombreEst.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(295, 66);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre del estudiante";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(322, 199);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 51);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 31);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 1;
            label1.Text = "Gestión de Estudiantes";
            // 
            // panel2
            // 
            panel2.Location = new Point(20, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 184);
            panel2.TabIndex = 0;
            // 
            // frmRegistroEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 292);
            Controls.Add(panel1);
            Name = "frmRegistroEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistroEstudiantes";
            Load += frmRegistroEstudiantes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGuardar;
        private Label label1;
        private Panel panel2;
        private ComboBox cboCarrera;
        private Label label4;
        private TextBox txtEdadEst;
        private Label label3;
        private TextBox txtNombreEst;
        private Label label2;
        private Button btnMenu;
    }
}