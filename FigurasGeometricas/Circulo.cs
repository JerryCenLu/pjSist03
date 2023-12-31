﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Circulo : Bidimensional
    {
 
        public Circulo(float lado, float radio, float altura) : base(lado, radio, altura)
        {
            this.Radio = radio;

        }

        public override double CalcularArea()
        {
            double area = 0;
            area = (Math.PI * (Math.Pow((double)Radio, 2)));
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 0;
            perimetro = 2 * Math.PI * Radio;
            return perimetro;
        }
    }
}
