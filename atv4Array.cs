// Crie um array para 4 notas (digitado pelo usuário) e calcule a média final.


using System.Net.Http.Headers;
using System.Reflection.Metadata;

public static class Atv4Array
{
    public static void Executar()
    {
        int[] nota = new int[4];
        double media = 0;

        for (int contador = 0; contador < 4; contador++)
        {
            Console.WriteLine($"o {contador + 1}º nota:");
            nota[contador] = int.Parse(Console.ReadLine()!);
            media += nota[contador];
        }

        Console.WriteLine($" A media final é {media / 4}");

    }
}