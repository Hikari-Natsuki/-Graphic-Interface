namespace Escuela
{
    partial class frmInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            panel1 = new Panel();
            lblCarrera = new Label();
            lblEdadEst = new Label();
            lblNombreEst = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnMenu = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(lblCarrera);
            panel1.Controls.Add(lblEdadEst);
            panel1.Controls.Add(lblNombreEst);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 266);
            panel1.TabIndex = 2;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Arial", 12F);
            lblCarrera.Location = new Point(471, 171);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(13, 18);
            lblCarrera.TabIndex = 14;
            lblCarrera.Text = "-";
            // 
            // lblEdadEst
            // 
            lblEdadEst.AutoSize = true;
            lblEdadEst.Font = new Font("Arial", 12F);
            lblEdadEst.Location = new Point(471, 118);
            lblEdadEst.Name = "lblEdadEst";
            lblEdadEst.Size = new Size(13, 18);
            lblEdadEst.TabIndex = 13;
            lblEdadEst.Text = "-";
            // 
            // lblNombreEst
            // 
            lblNombreEst.AutoSize = true;
            lblNombreEst.Font = new Font("Arial", 12F);
            lblNombreEst.Location = new Point(471, 70);
            lblNombreEst.Name = "lblNombreEst";
            lblNombreEst.Size = new Size(13, 18);
            lblNombreEst.TabIndex = 12;
            lblNombreEst.Text = "-";
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
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(524, 210);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(145, 51);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // frmInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 295);
            Controls.Add(panel1);
            Name = "frmInformacion";
            Text = "Informacion del estudiante";
            Load += frmInformacion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCarrera;
        private Label lblEdadEst;
        private Label lblNombreEst;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnMenu;
    }
}