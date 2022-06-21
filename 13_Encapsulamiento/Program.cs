using _13_Encapsulamiento.Modelo;

namespace _13_Encapsulamiento {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Estamos creando un nuevo Auto. Ingrese Tipo de Motor:");
            var tipoMotor = Console.ReadLine();

            var miAuto = new Auto();
            miAuto.TipoDeMotor = tipoMotor;

            Console.WriteLine(miAuto.TipoDeMotor);
        }
    }
}