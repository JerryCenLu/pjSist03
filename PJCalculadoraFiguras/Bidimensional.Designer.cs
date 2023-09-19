namespace PJCalculadoraFiguras
{
    partial class Bidimensional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bidimensional));
            cboTipo = new ComboBox();
            btnCalcular = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtAltura = new TextBox();
            txt4 = new TextBox();
            txtBase = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            txtLado = new TextBox();
            txtRadio = new TextBox();
            txt1 = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtPerimetro = new TextBox();
            txtArea = new TextBox();
            txtResultado = new TextBox();
            txtFigura = new TextBox();
            btnLimpiar = new Button();
            btnAtras = new Button();
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
            // cboTipo
            // 
            cboTipo.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Circulo", "Cuadrado", "Triangulo" });
            cboTipo.Location = new Point(31, 100);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(132, 22);
            cboTipo.TabIndex = 0;
            cboTipo.Text = "(Seleccione la figura)";
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(51, 171);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 34);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urbani", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 50);
            label1.Name = "label1";
            label1.Size = new Size(429, 23);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a la calculadora de figuras geometricas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAltura);
            groupBox1.Controls.Add(txt4);
            groupBox1.Controls.Add(txtBase);
            groupBox1.Controls.Add(txt3);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txtLado);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(txt1);
            groupBox1.Location = new Point(238, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos ";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(461, 66);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 22);
            txtAltura.TabIndex = 7;
            txtAltura.EnabledChanged += btnCalcular_Click;
            // 
            // txt4
            // 
            txt4.Enabled = false;
            txt4.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txt4.Location = new Point(461, 37);
            txt4.Name = "txt4";
            txt4.Size = new Size(100, 22);
            txt4.TabIndex = 6;
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtBase.Location = new Point(326, 66);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 22);
            txtBase.TabIndex = 5;
            // 
            // txt3
            // 
            txt3.Enabled = false;
            txt3.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txt3.Location = new Point(326, 37);
            txt3.Name = "txt3";
            txt3.Size = new Size(100, 22);
            txt3.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Enabled = false;
            txt2.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(188, 37);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 22);
            txt2.TabIndex = 3;
            // 
            // txtLado
            // 
            txtLado.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtLado.Location = new Point(188, 66);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 22);
            txtLado.TabIndex = 2;
            // 
            // txtRadio
            // 
            txtRadio.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtRadio.Location = new Point(36, 66);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 22);
            txtRadio.TabIndex = 1;
            // 
            // txt1
            // 
            txt1.Enabled = false;
            txt1.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(36, 37);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 22);
            txt1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPerimetro);
            groupBox2.Controls.Add(txtArea);
            groupBox2.Controls.Add(txtResultado);
            groupBox2.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(238, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 116);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Area y perimetro calculados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 59);
            label3.Name = "label3";
            label3.Size = new Size(58, 14);
            label3.TabIndex = 5;
            label3.Text = "Perimetro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 14);
            label2.TabIndex = 4;
            label2.Text = "Area";
            // 
            // txtPerimetro
            // 
            txtPerimetro.Enabled = false;
            txtPerimetro.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPerimetro.Location = new Point(163, 77);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.Size = new Size(100, 22);
            txtPerimetro.TabIndex = 3;
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtArea.Location = new Point(36, 77);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(100, 22);
            txtArea.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(36, 33);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(227, 22);
            txtResultado.TabIndex = 0;
            // 
            // txtFigura
            // 
            txtFigura.Enabled = false;
            txtFigura.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtFigura.Location = new Point(238, 227);
            txtFigura.Name = "txtFigura";
            txtFigura.Size = new Size(100, 22);
            txtFigura.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(51, 222);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 34);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Cursor = Cursors.Hand;
            btnAtras.FlatAppearance.BorderColor = Color.FromArgb(156, 196, 217);
            btnAtras.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 240, 230);
            btnAtras.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 107, 138);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Urbani", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(51, 273);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(96, 34);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 333);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pExit
            // 
            pExit.Image = (Image)resources.GetObject("pExit.Image");
            pExit.Location = new Point(819, 8);
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
            pMinimized.Location = new Point(772, 8);
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
            pHome.Size = new Size(857, 40);
            pHome.TabIndex = 9;
            pHome.MouseDown += pHome_MouseDown;
            // 
            // Bidimensional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(857, 450);
            Controls.Add(pHome);
            Controls.Add(pictureBox1);
            Controls.Add(btnAtras);
            Controls.Add(btnLimpiar);
            Controls.Add(txtFigura);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(cboTipo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bidimensional";
            Text = "Bidimensional";
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

        private ComboBox cboTipo;
        private Button btnCalcular;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtBase;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txtLado;
        private TextBox txtRadio;
        private TextBox txt1;
        private GroupBox groupBox2;
        private TextBox txtPerimetro;
        private TextBox txtArea;
        private TextBox txtResultado;
        private TextBox txtAltura;
        private TextBox txt4;
        private TextBox txtFigura;
        private Label label3;
        private Label label2;
        private Button btnLimpiar;
        private Button btnAtras;
        private PictureBox pictureBox1;
        private PictureBox pExit;
        private PictureBox pMinimized;
        private Panel pHome;
    }
}