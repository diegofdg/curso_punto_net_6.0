using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Tarea.Modelo {
    public abstract class Cuadrilatero {
        private int[] _vertice1;
        private int[] _vertice2;
        private int[] _vertice3;
        private int[] _vertice4;

        public int[] Vertice1 { get { return _vertice1; } set { _vertice1 = value; } }
        public int[] Vertice2 { get { return _vertice2; } set { _vertice2 = value; } }
        public int[] Vertice3 { get { return _vertice3; } set { _vertice3 = value; } }
        public int[] Vertice4 { get { return _vertice4; } set { _vertice4 = value; } }        

        public Cuadrilatero(int[] vertice1, int[] vertice2, int[] vertice3, int[] vertice4) {
            Vertice1 = vertice1;
            Vertice2 = vertice2;
            Vertice3 = vertice3;
            Vertice4 = vertice4;
        }
        public abstract double Area();
    }
}