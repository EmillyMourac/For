// Crie um array para 6 números inteiros (digitados pelo usuário) e exiba todos usando for .


public static class Atv2Array
{
    public static void Executar()
    {
        string[] numero = new string[6];
        for (int contador = 0; contador < 6; contador++)
        {
            Console.WriteLine($"o {contador + 1}º numero:");
            numero[contador] = Console.ReadLine()!;
        }
        for (int contador = 0; contador < 6; contador++)
        {
            Console.WriteLine($"o {contador + 1}º numero é {numero[contador]} ");
        }

    }
}