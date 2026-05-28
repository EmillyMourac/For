// Crie uma matriz 2x3 com números inteiros (digitado pelo usuário) e exiba todos em formato de
// tabela.


public static class Atv2Matriz
{
    public static void Executar()
    {
        int[,] numero = new int[2, 3];

        Console.WriteLine($"Digite o primeiro numero: ");
        numero[0, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o segundo numero: ");
        numero[0, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o terceiro numero: ");
        numero[0, 2] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o quarto numero: ");
        numero[1, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o quinto numero: ");
        numero[1, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o sexto numero: ");
        numero[1, 2] = int.Parse(Console.ReadLine()!);




        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {numero[linha, coluna]}");
            }
        }
    }
}