using System;
using System.Collections.Generic;

public class Menu
{
    private int _selecao;

    private string _textoDeCima;

    private List<string> _opcoes = new List<string>();

    private bool _continuarMenu;

    public int Selecao
    {
        get { return this._selecao; }
    }

    public string TextoDeCima
    {
        get { return this._textoDeCima; }
    }

    public List<string> Opcoes
    {
        get { return this._opcoes; }
    }

    public bool ContinuarMenu
    {
        get { return this._continuarMenu; }
        set { this._continuarMenu = value; }
    }

    public Menu(string textoAcima, List<string> opcoes)
    {
        this.ContinuarMenu = true;
        this._opcoes = opcoes;
        this._selecao = 0;
        this._textoDeCima = textoAcima;
    }

    public void IniciarMenuPadrao()
    {
        while (this.ContinuarMenu != false)
        {
            this.AtualizarMenu();
            this.PegarTecla();
        }
        if (this._selecao == this._opcoes.Count - 1)
            this._selecao = 0;
        else
            this._selecao++;
    }

    public void AtualizarMenu()
    {
        Console.Clear();
        int i = 0;
        Console.WriteLine(this._textoDeCima);
        foreach (string opcao in this._opcoes)
        {
            if (i == this._selecao)
            {
                DestacarSelecao();
            }

            Console.WriteLine(opcao);

            if (i == this._selecao)
            {
                Console.ResetColor();
            }

            i++;
        }
    }

    public void PegarTecla()
    {
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Enter)
            this.SairMenu();
        else if (tecla.Key == ConsoleKey.DownArrow && this._selecao + 1 < this._opcoes.Count)
            this._selecao++;
        else if (tecla.Key == ConsoleKey.UpArrow && this._selecao - 1 >= 0)
            this._selecao--;
    }

    public void SairMenu()
    {
        this.ContinuarMenu = false;
    }

    public static void DestacarSelecao()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
    }

    public static void EsperarPorTecla()
    {
        Console.WriteLine("\nPressione qualquer tecla para retornar ao menu");
        Console.ReadKey();
    }
}