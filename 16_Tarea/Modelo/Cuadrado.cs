using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Tarea.Modelo {
    public class Cuadrado : Cuadrilatero {
        public Cuadrado(int[] vertice1, int[] vertice2, int[] vertice3, int[] vertice4) : base(vertice1, vertice2, vertice3, vertice4) {
        }        
        public override double Area() {
            double lado1 = Math.Sqrt((Math.Pow((this.Vertice1[0] - this.Vertice2[0]), 2)) + (Math.Pow((this.Vertice1[1] - this.Vertice2[1]), 2)));
            return (Math.Pow(lado1,2));
        }        
    }
}