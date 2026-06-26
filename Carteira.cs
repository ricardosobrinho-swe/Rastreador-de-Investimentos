using System;
using RastreadorDeInvestimentos;
public class Carteira
{
    static List<Ativo> carteira = new();
    public static void AdicionarAtivo(Ativo ativo)
    {
        carteira.Add(ativo);
    }
    public static void MostrarCarteira()
    {
        foreach (Ativo ativo in carteira)
        {
            ativo.MostrarAtivo();
        }
    }
}