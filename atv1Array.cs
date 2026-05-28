// Crie um array para 5 nomes de alunos (digitados pelo usuário) e exiba todos usando for .


public static class Atv1Array
{
    public static void Executar()
    {
        string[] nome = new string[5];
        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"o {contador + 1}º nome:");
            nome[contador] = Console.ReadLine()!;
        }
        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"o {contador + 1}º nome é {nome[contador]} ");
        }

    }
}