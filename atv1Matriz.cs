/*
Crie uma matriz 2x2 de nomes (digitado pelo usuário) e exiba todos os nomes usando for aninhado.
*/

public static class Atv1Matriz
{
    public static void Executar()
    {
        string[,] nome = new string[2, 2];

        Console.WriteLine($"Digite o primeiro nome: ");
        nome[0, 0] = Console.ReadLine()!;

        Console.WriteLine($"digite o segundo nome: ");
        nome[0, 1] = Console.ReadLine()!;

        Console.WriteLine($"digite o terceiro nome: ");
        nome[1, 0] = Console.ReadLine()!;

        Console.WriteLine($"digite o terceiro nome: ");
        nome[1, 1] = Console.ReadLine()!;


        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {nome[linha, coluna]}");
            }
        }
    }
}