// Crie uma matriz 2x3 com números inteiros e mostre qual é o maior valor da matriz.


using System.Diagnostics.Contracts;

public static class Atv6Matriz
{
    public static void Executar()
    {
        int[,] valor = new int[2, 3];
        double maior = 0;

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write("digite o numero: ");
                valor[linha, coluna] = int.Parse(Console.ReadLine()!);
            }
        }

        maior = valor[0, 0];

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (maior < valor[linha, coluna])
                {
                    maior = valor[linha, coluna];
                }
            }
        }
        Console.WriteLine($"o maior valor é: {maior}");


    }
}