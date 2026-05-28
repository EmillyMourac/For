// Escolha uma das atividades anteriores e resolva de duas formas:

// - Uma usando `for`;
// - Outra usando `while`.

// Depois, escreva uma breve explicação dizendo qual das duas formas ficou mais organizada.



public static class Atv5for
{
    public static void Executar()
    {
        Console.WriteLine("Digite um número para mostrar a tabuada:");
        int numero = int.Parse(Console.ReadLine()!);

        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }
    }
}

public static class Atv5While
{
    public static void Executar()
    {
        Console.WriteLine("Digite um número para mostrar a tabuada:");
        int numero = int.Parse(Console.ReadLine()!);

        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
        }
    }
}


// A forma com for ficou mais organizada, porque ela deixa tudo em uma linha, Isso faz o código ficar mais limpo e fácil de entender.
// O while, precisa de mais linhas e mais atenção para não esquecer o incremento.
// Como a tabuada já tem uma quantidade fixa de repetições (de 1 a 10), o for acaba ficando mais fácil de usar.