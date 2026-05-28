// Crie um array para 5 números (digitado pelo usuário) e mostre qual é o maior valor digitado


using System.Diagnostics.Contracts;

public static class Atv5Array
{
    public static void Executar()
    {
        int[] valor = new int[5];
        double maior = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"o {contador + 1}º numero:");
            valor[contador] = int.Parse(Console.ReadLine()!);

        }

        maior = valor[0];
        for (int verificar = 0; verificar < 4; verificar++)
        {
            if (maior < valor[verificar + 1])
            {
                maior = valor[verificar + 1];
            }
        }
        Console.WriteLine($"o valor maior é:{maior}");

    }
}