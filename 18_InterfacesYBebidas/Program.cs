var Quilmes = new Cerveza();

var CocaCola = new Gaseosa();


public interface IBebida {
    decimal Volumen { get; set; }
    bool Gasificada { get; set; }
    string Color { get; set; }
    decimal Caloria { get; set; }
}

public interface IBebidasAlcoholicas {
    decimal Graduacion { get; set; }
}

public class Gaseosa : IBebida
{
    public decimal Volumen { get; set; }
    public bool Gasificada { get; set; }
    public string Color { get; set; }
    public decimal Caloria { get; set; }
}

public interface ICerveza : IBebidasAlcoholicas {
    public int IBU {get; set;}
}

public class Cerveza : IBebida, ICerveza
{
    public decimal Volumen { get; set; }
    public bool Gasificada { get; set; }
    public string Color { get; set; }
    public decimal Caloria { get; set; }
    public int IBU { get; set; }
    public decimal Graduacion { get; set; }
}

