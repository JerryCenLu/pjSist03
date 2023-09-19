using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigurasGeometricas;

namespace PJCalculadoraFiguras
{
    public partial class Tridimensional : Form
    {
        Esfera esfera = new Esfera(0, 0);
        Cubo cubo = new Cubo(0, 0);
        Tetaedro tetaedro = new Tetaedro(0, 0);
        string radio = "";
        string lado = "";
        double volumen;
        double area;
        string figura = "";
        string resultado = "";
        public Tridimensional()
        {
            InitializeComponent();
        }
        private void cboTipo_SelctedIndexChanged(object sender, EventArgs e)
        {

            // capturamos el tipo de figura 
            int tipo = cboTipo.SelectedIndex;

            // Asignamos el tipo seleccionado 
            switch (tipo)
            {
                case 0:
                    radio = "Radio"; lado = "No ingrese valor "; resultado = "El area y Volumen del circulo es:";
                    figura = "Esfera";
                    txtLado.Enabled = false;
                    break;
                case 1:
                    radio = "No ingrese valor "; lado = "Lado "; resultado = "El area y volumen del cubo es";
                    figura = "Cubo";
                    break;
                case 2:
                    radio = "No ingrese valor"; lado = "Lado "; resultado = "El area y volumen del tetaedro  es";
                    figura = "Tetaedro";
                    break;

            }

            // Mostramos lo info
            txt1.Text = radio.ToString();
            txt2.Text = lado.ToString();
            txtResultado.Text = resultado.ToString();
            txtFigura.Text = figura.ToString();


        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (figura)
            {
                case "Esfera":


                    esfera.Radio = float.Parse(txtRadio.Text);
                    //Realizando los calculos de las areas y perimetros del circulo 
                    area = esfera.CalcularArea();
                    volumen = esfera.CalcularVolumen();
                    //mandamos a imprimir 
                    txtArea.Text = area.ToString();
                    txtVolumen.Text = volumen.ToString();


                    break;
                case "Cubo":


                    cubo.Lado = float.Parse(txtLado.Text);
                    //Realizando los calculos de las areas y perimetros del cuadrado

                    area = cubo.CalcularArea();
                    volumen = cubo.CalcularVolumen();
                    //mandamos a imrprimir 
                    txtArea.Text = area.ToString();
                    txtVolumen.Text = volumen.ToString();


                    break;
                case "Tetaedro":

                    tetaedro.Lado = float.Parse(txtLado.Text);
                    //Realizando los calculos de las areas y perimetros del triangulo
                    area = tetaedro.CalcularArea();
                    volumen = tetaedro.CalcularVolumen();
                    //mandamos a imprimir
                    txtArea.Text = area.ToString();
                    txtVolumen.Text = volumen.ToString();
                    break;
            }


        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txt1.Clear();
            txt2.Clear();
            txtRadio.Clear();
            txtLado.Clear();
            txtFigura.Clear();
            txtResultado.Clear();
            txtArea.Clear();
            txtVolumen.Clear();

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.ShowDialog();

        }

        private void pMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }


}
