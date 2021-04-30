using System;

public class Retangulo : Figura
{
    private double _altura;
    private double _largura;
    public double Altura
    {
        get { return this._altura; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Valor inválido para altura!");
            }
            else
            {
                this._altura = value;
                if (this._largura > 0)
                {
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
    }
    public double Largura
    {
        get { return this._largura; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Valor inválido para largura!");
            }
            else
            {
                this._largura = value;
                if (this._altura > 0)
                {
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
    }

    public Retangulo(double altura, double largura, string nome)
    {
        this.Altura = altura;
        this.Largura = largura;
        this._nomeDaFigura = "Retângulo " + nome;
        this.AtualizarArea();
        this.AtualizarPerimetro();
    }

    private void AtualizarArea()
    {
        this._area = this._altura * this._largura;
    }

    private void AtualizarPerimetro()
    {
        this._perimetro = this._altura * 2 + this._largura * 2;
    }
}