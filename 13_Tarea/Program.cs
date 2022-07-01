using _13_Tarea.Version2;

namespace _13_Tarea {
    internal class Program {
        static void Main(string[] args) {

            var b1 = new Billetera();
            var bc2 = new BilleteraCarlos();
            b1.BilletesDe100 = 1;
            bc2.BilletesDe1000 = 1;
            
            Console.WriteLine($"La billetera 1 tiene {b1.Total()}");
            Console.WriteLine($"La billetera 2 de Carlos tiene {bc2.Total()}");
            Console.WriteLine("");

            IBilletera bc3 = b1.Combinar(bc2);
            
            Console.WriteLine($"La billetera 1 tiene {b1.Total()}");
            Console.WriteLine($"La billetera 2 de Carlos tiene {bc2.Total()}");
            Console.WriteLine($"La billetera 3 de Carlos tiene {bc3.Total()}");
        }
    }
}