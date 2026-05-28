// Crie uma matriz 2x2 com números inteiros e calcule a soma de todos os valores.


public static class Atv3Matriz
{
    public static void Executar()
    {
        int[,] numero = new int[2, 2];

        Console.WriteLine($"Digite o primeiro numero: ");
        numero[0, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o segundo numero: ");
        numero[0, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o terceiro numero: ");
        numero[1, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o quarto numero: ");
        numero[1, 1] = int.Parse(Console.ReadLine()!);

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {numero[linha, coluna]}");
            }
        }

        int soma = 0;

        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                soma = soma + numero[linha, coluna];
            }
        }
        Console.WriteLine($"Soma: {soma}");

    }
}