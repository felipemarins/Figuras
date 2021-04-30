using System;

public class Figura
{
    protected double _area;
    protected double _perimetro;
    
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
        Console.WriteLine("Area: {0}", this.Area);
        Console.WriteLine("Perimetro: {0}", this.Perimetro);
    }
}