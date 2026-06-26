using System.ComponentModel;

namespace RastreadorDeInvestimentos;

public class Ativo
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;
    public decimal DividendosMensais;
    public Ativo(string nomeAtivo, decimal precoAtivo, int quantidade, decimal dividendosMensais)
    {
        this.Nome = nomeAtivo;
        this.Preco = precoAtivo;
        this.Quantidade = quantidade;
        this.DividendosMensais = dividendosMensais;
    }
    public void CadastrarAtivo()
    {
        Ativo ativo = new(Nome, Preco, Quantidade, DividendosMensais);
    }
    public void MostrarAtivo()
    {
        Console.WriteLine($"Nome: {Nome}\nPreco: {Preco:F2}\nQuantidade: {Quantidade}\n\n");
    }
}