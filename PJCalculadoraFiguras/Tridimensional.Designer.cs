namespace PJCalculadoraFiguras
{
    partial class Tridimensional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tridimensional));
            btnCalcular = new Button();
            cboTipo = new ComboBox();
            groupBox1 = new GroupBox();
            txtLado = new TextBox();
            txtRadio = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtVolumen = new TextBox();
            txtArea = new TextBox();
            txtResultado = new TextBox();
            txtFigura = new TextBox();
            label3 = new Label();
            btnLimpiar = new Button();
            btAtras = new Button();
            pictureBox1 = new PictureBox();
            pExit = new PictureBox();
            pMinimized = new PictureBox();
            pHome = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pMinimized).BeginInit();
            pHome.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(78, 184);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 21);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Esfera", "Cubo", "Tetaedro" });
            cboTipo.Location = new Point(44, 144);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(146, 22);
            cboTipo.TabIndex = 3;
            cboTipo.Text = "(Seleccione la figura)";
            cboTipo.SelectedIndexChanged += cboTipo_SelctedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLado);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(294, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 112);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inserte los datos ";
            // 
            // txtLado
            // 
            txtLado.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtLado.Location = new Point(226, 74);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 22);
            txtLado.TabIndex = 7;
            // 
            // txtRadio
            // 
            txtRadio.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtRadio.Location = new Point(57, 74);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 22);
            txtRadio.TabIndex = 6;
            // 
            // txt2
            // 
            txt2.Enabled = false;
            txt2.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(226, 34);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 22);
            txt2.TabIndex = 5;
            // 
            // txt1
            // 
            txt1.Enabled = false;
            txt1.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(57, 34);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 22);
            txt1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtVolumen);
            groupBox2.Controls.Add(txtArea);
            groupBox2.Controls.Add(txtResultado);
            groupBox2.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(294, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 121);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrando los Resultados ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 59);
            label2.Name = "label2";
            label2.Size = new Size(53, 14);
            label2.TabIndex = 4;
            label2.Text = "Volumen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(31, 14);
            label1.TabIndex = 3;
            label1.Text = "Area";
            // 
            // txtVolumen
            // 
            txtVolumen.Enabled = false;
            txtVolumen.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtVolumen.Location = new Point(214, 77);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.Size = new Size(100, 22);
            txtVolumen.TabIndex = 2;
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtArea.Location = new Point(38, 77);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 22);
            txtArea.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(38, 32);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(160, 22);
            txtResultado.TabIndex = 0;
            // 
            // txtFigura
            // 
            txtFigura.Enabled = false;
            txtFigura.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtFigura.Location = new Point(294, 273);
            txtFigura.Name = "txtFigura";
            txtFigura.Size = new Size(100, 22);
            txtFigura.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Urbani", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(185, 58);
            label3.Name = "label3";
            label3.Size = new Size(513, 23);
            label3.TabIndex = 7;
            label3.Text = "Bienvenido a la super calculadora de figuras tridimensionales";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(78, 223);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 21);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btAtras
            // 
            btAtras.BackColor = SystemColors.ActiveCaption;
            btAtras.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btAtras.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btAtras.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btAtras.FlatStyle = FlatStyle.Flat;
            btAtras.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btAtras.Location = new Point(78, 261);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(94, 21);
            btAtras.TabIndex = 9;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pExit
            // 
            pExit.Image = (Image)resources.GetObject("pExit.Image");
            pExit.Location = new Point(798, 8);
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
            pMinimized.Location = new Point(751, 8);
            pMinimized.Name = "pMinimized";
            pMinimized.Size = new Size(25, 22);
            pMinimized.SizeMode = PictureBoxSizeMode.Zoom;
            pMinimized.TabIndex = 9;
            pMinimized.TabStop = false;
            pMinimized.Click += pMinimized_Click;
            // 
            // pHome
            // 
            pHome.BackColor = Color.FromArgb(51, 107, 138);
            pHome.Controls.Add(pExit);
            pHome.Controls.Add(pMinimized);
            pHome.Dock = DockStyle.Top;
            pHome.Location = new Point(0, 0);
            pHome.Name = "pHome";
            pHome.Size = new Size(836, 40);
            pHome.TabIndex = 11;
            pHome.MouseDown += pHome_MouseDown;
            // 
            // Tridimensional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(836, 450);
            Controls.Add(pHome);
            Controls.Add(pictureBox1);
            Controls.Add(btAtras);
            Controls.Add(btnLimpiar);
            Controls.Add(label3);
            Controls.Add(txtFigura);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cboTipo);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tridimensional";
            Text = "Tridimensional";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pMinimized).EndInit();
            pHome.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private ComboBox cboTipo;
        private GroupBox groupBox1;
        private TextBox txtLado;
        private TextBox txtRadio;
        private TextBox txt2;
        private TextBox txt1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox txtVolumen;
        private TextBox txtArea;
        private TextBox txtResultado;
        private TextBox txtFigura;
        private Label label3;
        private Button btnLimpiar;
        private Button btAtras;
        private PictureBox pictureBox1;
        private PictureBox pExit;
        private PictureBox pMinimized;
        private Panel pHome;
    }
}