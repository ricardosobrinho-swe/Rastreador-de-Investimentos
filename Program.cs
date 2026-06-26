/*
Funcionalidades iniciais
Cadastrar ativo
Informar quantidade
Informar preço médio
Listar carteira

Exemplo:

1 - Adicionar ativo
2 - Ver carteira
3 - Sair
*/
using RastreadorDeInvestimentos;

public class RastrearInvestimentos
{
    private static string? nomeAtivo;
    private static decimal precoAtivo;
    private static int quantidade;
    private static decimal dividendosMensais;

    public static void Main()
    {
        int opcao;
        while (true)
        {
            Console.Write("1 - Adicionar ativo\n2 - Ver carteira\n3 - Sair\nSUA ESCOLHA: ");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("ADICIONAR ATIVO");

                    Console.Write("NOME: ");
                    nomeAtivo = Console.ReadLine()!;
                    Console.Write("PRECO: ");
                    precoAtivo = decimal.Parse(Console.ReadLine()!);
                    Console.Write("QUANTIDADE: ");
                    quantidade = int.Parse(Console.ReadLine()!);
                    Console.Write("DIVIDENDOS MENSAIS: ");
                    dividendosMensais = decimal.Parse(Console.ReadLine()!);

                    Ativo ativo = new Ativo(nomeAtivo, precoAtivo, quantidade, dividendosMensais);

                    Carteira.AdicionarAtivo(ativo);

                    break;
                case 2:
                    Console.WriteLine("VER CARTEIRA");
                    Carteira.MostrarCarteira();
                    break;
                case 3:
                    Console.WriteLine("SAINDO...");
                    return;
            }
        }
    }
}