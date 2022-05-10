/****** Ejemplo de while ******/

Console.WriteLine("Cuantas vueltas quiere dar?");

var totalVueltas = int.Parse(Console.ReadLine());

var contador = 0;

while (contador < totalVueltas) {
    contador++; // contador = contador + 1;
    Console.WriteLine("Seguimos dando vueltas, vuelta número " + contador);
}

Console.WriteLine("Cuantas vueltas quiere dar?");

var respuesta = "S";

contador = 0;

while (respuesta.ToUpper() != "N") {
    contador++;
    Console.WriteLine("Segunda tanda de vueltas, vuelta número " + contador);

    Console.WriteLine("¿Seguimos? (S/N)");
    respuesta = Console.ReadLine();
}


/****** Ejemplo de for ******/

for (var cantCara = 0; cantCara <= 12; cantCara += 2) {
    Console.WriteLine($"Mi bolsita tiene {cantCara} caramelos");
    //RECORDAR !!!! el paso lo hace al finalizar la ejecución
}