using System;

public class Circulo : Figura
{
    private double _raio;

    public double Raio
    {
        get { return this._raio; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Valor inválido para raio!");
            }
            else
            {
                this._raio = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }

    public Circulo(double raio, string nome)
    {
        this.Raio = raio;
        this._nomeDaFigura = "Círculo " + nome;
    }

    private void AtualizarArea()
    {
        this._area = Math.PI * Math.Pow(this._raio, 2);
    }

    private void AtualizarPerimetro()
    {
        this._perimetro = 2 * Math.PI * this._raio;
    }
}