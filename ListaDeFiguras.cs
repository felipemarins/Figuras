using System;
using System.Collections.Generic;

public class ListaDeFiguras : List<Figura>
{
    public int ContarFiguraEspecifica(Type tipo)
    {
        int contagem = 0;
        foreach (Figura figura in this)
        {
            if (figura.GetType() == tipo)
            {
                contagem++;
            }
        }
        return contagem;
    }
}