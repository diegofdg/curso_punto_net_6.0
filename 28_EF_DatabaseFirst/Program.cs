using _28_EF_DatabaseFirst.Context;
using _28_EF_DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

var ctx = new NorthwindContext();

/*
// Creamos un customer
var newCustomer = new Customer()
{
    CustomerId = "RUBEN",
    CompanyName = "Ruben Benegas",
    Orders = new List<Order>()
};

// Le agregamos orders al customer recien creado
newCustomer.Orders.Add(new Order()
{
    CustomerId = "RUBEN",
    OrderDate = DateTime.Now,
});

// Agregamos el customer a la base de datos
ctx.Add(newCustomer);
ctx.SaveChanges();
*/


/*
var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == "RUBEN");
if (reg != null)
{
    reg.CompanyName = "Ruben Benegas Editado";
    ctx.SaveChanges();
}
*/

/*
var regOrders = ctx.Orders.Where(r => r.CustomerId == "RUBEN");
ctx.RemoveRange(regOrders);
var regCustomer = ctx.Customers.FirstOrDefault(r => r.CustomerId == "RUBEN");
ctx.Remove(regCustomer);
ctx.SaveChanges();
*/

Console.WriteLine("Lista de Customers");
Console.WriteLine();
Console.WriteLine("==================");

var customers = ctx.Customers.Select(selector => new { IdCustomer = selector.CustomerId, NameCustomer = selector.CompanyName});

// var sqlraw = ctx.Customers.FromSqlRaw("SELECT * FROM Customers");  Consulta directa utilizando 


foreach (var customer in customers)
{
    Console.WriteLine($"{customer.IdCustomer} - {customer.NameCustomer}");
}

Console.WriteLine("==================");
Console.WriteLine();
Console.WriteLine("Ingrese el IdCustomer que desea consultar:");
string idCustomer = Console.ReadLine();

// Consulta si existe en la Base de Datos (Any)
bool anyCustomer = ctx.Customers.Any(x => x.CustomerId == idCustomer.ToUpper());

if (anyCustomer)
{
    Console.WriteLine("Existe. Todo OK");
    // Select Top (1)
    var customer = ctx.Customers.Include(i => i.Orders).FirstOrDefault(c => c.CustomerId == idCustomer);
    Console.WriteLine();
    Console.WriteLine($"IdCustomer: {customer.CustomerId} - CompanyName: {customer.CompanyName}");
    Console.WriteLine();
    Console.WriteLine("Orders");

    foreach( var item in customer.Orders)
    {
        Console.WriteLine($"OrderId: {item.OrderId} - OrderDate: {item.OrderDate}");
    }
    Console.WriteLine("==================");
    Console.WriteLine();
} 
else
{
    Console.WriteLine("No Existe. Todo Mal");
}