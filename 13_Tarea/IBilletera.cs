using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Tarea {
    public interface IBilletera {
        int BilletesDe10 { get; set; }
        int BilletesDe100 { get; set; }
        int BilletesDe1000 { get; set; }
        int BilletesDe20 { get; set; }
        int BilletesDe200 { get; set; }
        int BilletesDe50 { get; set; }
        int BilletesDe500 { get; set; }

        IBilletera Combinar(IBilletera b);
        decimal Total();
    }
}