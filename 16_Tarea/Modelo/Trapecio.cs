using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Tarea.Modelo {
    public class Trapecio : Cuadrilatero {
        public Trapecio(int[] vertice1, int[] vertice2, int[] vertice3, int[] vertice4) : base(vertice1, vertice2, vertice3, vertice4) {
        }

        public override double Area() {
            double suma1 = this.Vertice4[0] * this.Vertice1[1];            
            double suma2 = this.Vertice1[0] * this.Vertice2[1];            
            double suma3 = this.Vertice2[0] * this.Vertice3[1];            
            double suma4 = this.Vertice3[0] * this.Vertice4[1];            
            double subtotal1 = suma1 + suma2 + suma3 + suma4;            

            double suma5 = this.Vertice4[1] * this.Vertice1[0];                        
            double suma6 = this.Vertice1[1] * this.Vertice2[0];
            double suma7 = this.Vertice2[1] * this.Vertice3[0];            
            double suma8 = this.Vertice3[1] * this.Vertice4[0];            
            double subtotal2 = suma5 + suma6 + suma7 + suma8;
            
            return (0.5 * (subtotal1 - subtotal2));            
        }
    }
}