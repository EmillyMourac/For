// Crie um programa que peça um número ao usuário e mostre a tabuada desse 
// número de 1 até 10. (proíbido o uso de foreach ou qualquer outro tipo,
//  é permitido somente o uso de for)

public static class Atv4for
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