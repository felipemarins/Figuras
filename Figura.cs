using System;

public class Figura
{
    protected string _nomeDaFigura;
    protected double _area;
    protected double _perimetro;

    public string NomeDaFigura
    {
        get { return this._nomeDaFigura; }
    }
    public double Area
    {
        get { return this._area; }
    }
    public double Perimetro
    {
        get { return this._perimetro; }
    }

    public void ImprimirFigura()
    {
        Console.WriteLine("Nome da figura: {0}", this.NomeDaFigura);
        Console.WriteLine("Area: {0}", this.Area);
        Console.WriteLine("Perimetro: {0}", this.Perimetro);
    }
}