namespace Escuela
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            panel1 = new Panel();
            btnSalir = new Button();
            btnListarEst = new Button();
            btnRegistrarEst = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnListarEst);
            panel1.Controls.Add(btnRegistrarEst);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 465);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Narrow", 12F);
            btnSalir.Image = Properties.Resources.Salir;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(20, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(258, 51);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnListarEst
            // 
            btnListarEst.Font = new Font("Arial Narrow", 12F);
            btnListarEst.Image = Properties.Resources.listar;
            btnListarEst.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarEst.Location = new Point(20, 332);
            btnListarEst.Name = "btnListarEst";
            btnListarEst.Size = new Size(258, 51);
            btnListarEst.TabIndex = 3;
            btnListarEst.Text = "Listar Manada";
            btnListarEst.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEst
            // 
            btnRegistrarEst.Font = new Font("Arial Narrow", 12F);
            btnRegistrarEst.Image = (Image)resources.GetObject("btnRegistrarEst.Image");
            btnRegistrarEst.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEst.Location = new Point(20, 275);
            btnRegistrarEst.Name = "btnRegistrarEst";
            btnRegistrarEst.Size = new Size(258, 51);
            btnRegistrarEst.TabIndex = 2;
            btnRegistrarEst.Text = "Registrar Lobo";
            btnRegistrarEst.UseVisualStyleBackColor = true;
            btnRegistrarEst.Click += btnRegistrarEst_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 31);
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
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 507);
            Controls.Add(panel1);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú de estudiantes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrarEst;
        private Label label1;
        private Panel panel2;
        private Button btnSalir;
        private Button btnListarEst;
    }
}
