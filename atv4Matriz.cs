// Crie uma matriz 3x2 de notas e calcule a média geral de todas as notas. Encontre uma forma que o
// divisor (do cálculo da média) seja uma variável incrementada (não atribuir um valor fixo)


using System.ComponentModel.DataAnnotations.Schema;

public static class Atv4Matriz
{
    public static void Executar()
    {
        int[,] notas = new int[3, 2];

        double divisor = 0;

        Console.WriteLine($"Digite a primeiro notas: ");
        notas[0, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite a segundo notas: ");
        notas[0, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite a terceiro notas: ");
        notas[1, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite a quarto notas: ");
        notas[1, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite a quinto notas: ");
        notas[2, 0] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite a sexto notas: ");
        notas[2, 1] = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"digite o divisor: ");
        divisor = int.Parse(Console.ReadLine()!);


        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                Console.WriteLine($"Linha {linha}, Coluna {coluna}: {notas[linha, coluna]}");
            }
        }

        double media = 0;

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                media += notas[linha, coluna];
            }
        }

        Console.WriteLine($"media é: {media / divisor}");
    }
}