// Crie um array para 5 números inteiros (digitados pelo usuário) e calcule a soma de todos os valores.


public static class Atv3Array
{
    public static void Executar()
    {
        int[] numero = new int[5];
        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"o {contador + 1}º numero:");
            numero[contador] = int.Parse(Console.ReadLine()!);
        }
        int soma = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            soma = soma + numero[contador];
        }
        Console.WriteLine($"Soma: {soma}");


        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"o {contador + 1}º numero é {numero[contador]} ");
        }

    }
}