using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirst.Modelo
{
    public class Domicilio
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}
