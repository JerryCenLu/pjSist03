using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Esfera : Tridimensional
    {
       

        public Esfera(float lado, float radio) : base(lado, radio)
        {
        }

        public override double CalcularArea()
        {
            double area = (4 * Math.PI* Math.Pow(Radio,2));
            return area;
        }

        public override double CalcularVolumen()
        {
            double Volumen = (4/3*(Math.PI * Math.Pow(Radio, 2)));
            return Volumen;
        }
    }
}
