namespace _13_Tarea {
    internal class Program {
        static void Main(string[] args) {
            /*
            Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:
                * BilletesDe10
                * BilletesDe20
                * BilletesDe50
                * BilletesDe100
                * BilletesDe200
                * BilletesDe500
                * BilletesDe1000

            Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total
            en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

            Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera
            y que devuelva una nueva Billetera con la suma o combinacion del dinero
            de ambas billeteras.  
            Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras
            deberan quedar en cero. (Sin billetes)            
            */

            var b1 = new Billetera();
            var b2 = new Billetera();

            b1.BilletesDe100 = 1;
            b2.BilletesDe1000 = 1;

            Console.WriteLine($"La billetera 1 tiene {b1.Total()}");
            Console.WriteLine($"La billetera 2 tiene {b2.Total()}");
            Console.WriteLine("");

            var b3 = b1.Combinar(b2);

            Console.WriteLine($"La billetera 1 tiene {b1.Total()}");
            Console.WriteLine($"La billetera 2 tiene {b2.Total()}");
            Console.WriteLine($"La billetera 3 tiene {b3.Total()}");
        }
    }
}