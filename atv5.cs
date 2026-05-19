// Escolha uma das atividades anteriores e resolva de duas formas:

// - Uma usando `for`;
// - Outra usando `while`.

// Depois, escreva uma breve explicação dizendo qual das duas formas ficou mais organizada.



public static class Atv5
{
    public static void Executar()
    {
        Console.WriteLine("Digite um número para mostrar a tabuada:");
        int numero = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Usando for:");
        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }

        Console.WriteLine("\nUsando while:");
        int contadorWhile = 1;
        while (contadorWhile <= 10)
        {
            Console.WriteLine($"{numero} x {contadorWhile} = {numero * contadorWhile}");
            contadorWhile++;
        }
    }
}