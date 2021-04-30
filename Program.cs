using System;
using System.Collections.Generic;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaDeFiguras = new List<Figura>();

            Menu menuPrincipal = new Menu("Menu principal\n",
                new List<String>
                {
                    "Criar uma nova figura",
                    "Listar figuras armazenadas",
                    "Sair"
                }
            );
            while (menuPrincipal.ContinuarMenu)
            {
                menuPrincipal.IniciarMenuPadrao();
                if (menuPrincipal.Selecao != 0)
                {
                    if (menuPrincipal.Selecao == 1)
                    {
                        Menu menuCriacao = new Menu("Menu de criação de figuras\n",
                            new List<String>
                            {
                                "Criar retângulo",
                                "Voltar"
                            }
                        );
                        while (menuCriacao.ContinuarMenu)
                        {
                            menuCriacao.IniciarMenuPadrao();
                            if (menuCriacao.Selecao != 0)
                            {
                                if (menuCriacao.Selecao == 1)
                                {
                                    Console.Clear();

                                    Menu.DestacarSelecao();
                                    Console.WriteLine("Criando um novo retângulo\n");
                                    Console.ResetColor();

                                    Console.Write("Altura: ");
                                    double altura = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Largura: ");
                                    double largura = Convert.ToDouble(Console.ReadLine());

                                    Retangulo novoRetangulo = new Retangulo(altura, largura, Convert.ToString(listaDeFiguras.Count + 1));
                                    listaDeFiguras.Add(novoRetangulo);

                                    Menu.EsperarPorTecla();
                                }
                                menuCriacao.ContinuarMenu = true;
                            }
                        }
                    }
                    else if (menuPrincipal.Selecao == 2)
                    {
                        Console.Clear();

                        Menu.DestacarSelecao();
                        Console.WriteLine("Figuras armazenadas:\n");
                        Console.ResetColor();

                        if (listaDeFiguras.Count == 0)
                        {
                            Console.WriteLine("Parece que não há figuras armazenadas!");
                        }
                        else
                        {
                            foreach (Figura figura in listaDeFiguras)
                            {
                                figura.ImprimirFigura();
                                Console.WriteLine();
                            }
                        }

                        Menu.EsperarPorTecla();
                    }
                    menuPrincipal.ContinuarMenu = true;
                }
            }
        }
    }
}
