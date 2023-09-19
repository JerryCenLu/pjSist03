namespace PJCalculadoraFiguras
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnTridimensional = new Button();
            btnBidimensional = new Button();
            label1 = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pHome = new Panel();
            pExit = new PictureBox();
            pMinimized = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pMinimized).BeginInit();
            SuspendLayout();
            // 
            // btnTridimensional
            // 
            btnTridimensional.Cursor = Cursors.Hand;
            btnTridimensional.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnTridimensional.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnTridimensional.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnTridimensional.FlatStyle = FlatStyle.Flat;
            btnTridimensional.Font = new Font("Urbani", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTridimensional.Location = new Point(124, 170);
            btnTridimensional.Name = "btnTridimensional";
            btnTridimensional.Size = new Size(115, 37);
            btnTridimensional.TabIndex = 0;
            btnTridimensional.Text = "Tridimensional ";
            btnTridimensional.UseVisualStyleBackColor = true;
            btnTridimensional.Click += button1_Click;
            // 
            // btnBidimensional
            // 
            btnBidimensional.Cursor = Cursors.Hand;
            btnBidimensional.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnBidimensional.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnBidimensional.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnBidimensional.FlatStyle = FlatStyle.Flat;
            btnBidimensional.Font = new Font("Urbani", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBidimensional.Location = new Point(562, 173);
            btnBidimensional.Name = "btnBidimensional";
            btnBidimensional.Size = new Size(124, 34);
            btnBidimensional.TabIndex = 1;
            btnBidimensional.Text = "Bidimensional ";
            btnBidimensional.UseVisualStyleBackColor = true;
            btnBidimensional.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urbani", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 71);
            label1.Name = "label1";
            label1.Size = new Size(406, 19);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a la super calculadora de figuras geometricas";
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Urbani", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(713, 401);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 37);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Urbani", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 113);
            label2.Name = "label2";
            label2.Size = new Size(320, 18);
            label2.TabIndex = 6;
            label2.Text = "Pulse un boton para la opcion que desea realizar ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(494, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pHome
            // 
            pHome.BackColor = Color.FromArgb(51, 107, 138);
            pHome.Controls.Add(pExit);
            pHome.Controls.Add(pMinimized);
            pHome.Dock = DockStyle.Top;
            pHome.Location = new Point(0, 0);
            pHome.Name = "pHome";
            pHome.Size = new Size(800, 40);
            pHome.TabIndex = 8;
            pHome.MouseDown += pHome_MouseDown;
            // 
            // pExit
            // 
            pExit.Image = (Image)resources.GetObject("pExit.Image");
            pExit.Location = new Point(762, 9);
            pExit.Name = "pExit";
            pExit.Size = new Size(25, 22);
            pExit.SizeMode = PictureBoxSizeMode.Zoom;
            pExit.TabIndex = 10;
            pExit.TabStop = false;
            pExit.Click += pExit_Click;
            // 
            // pMinimized
            // 
            pMinimized.Image = (Image)resources.GetObject("pMinimized.Image");
            pMinimized.Location = new Point(715, 9);
            pMinimized.Name = "pMinimized";
            pMinimized.Size = new Size(25, 22);
            pMinimized.SizeMode = PictureBoxSizeMode.Zoom;
            pMinimized.TabIndex = 9;
            pMinimized.TabStop = false;
            pMinimized.Click += pMinimized_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pHome);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnBidimensional);
            Controls.Add(btnTridimensional);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pMinimized).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTridimensional;
        private Button btnBidimensional;
        private Label label1;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel pHome;
        private PictureBox pExit;
        private PictureBox pMinimized;
    }
}