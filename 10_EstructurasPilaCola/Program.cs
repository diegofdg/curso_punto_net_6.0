//Pilas - LIFO (Last In First Out)
var miPila = new Stack<int>();

miPila.Push(1);
miPila.Push(2);
miPila.Push(3);
miPila.Push(4);

Console.WriteLine("Pila");

Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());
Console.WriteLine(miPila.Pop());

Console.WriteLine("");

//Colas - FIFO (First In First Out)
var miCola = new Queue<int>();

miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);

Console.WriteLine("Cola");

Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());