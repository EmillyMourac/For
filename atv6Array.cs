// Crie um array para 5 números (digitado pelo usuário) e ordene os números no array, na sequencia
// apresente os números ordenados, utilizar somente recursos explicados em aula.


using System.ComponentModel;

public static class Atv6Array
{
    public static void Executar()
    {
        int[] numero = new int[5];
        double maior = 0;
        int suporte = 0;

        for (int contador = 0; contador < 5; contador++)
        {
            Console.WriteLine($"digite o {contador + 1}º numero:");
            numero[contador] = int.Parse(Console.ReadLine()!);

        }

        maior = numero[0];

        for (int verificar = 0; verificar < 4; verificar++)
        {
            for (int organizar = 0; organizar < 4; organizar++)
            {
                if (numero[organizar] > numero[organizar + 1])
                {
                    suporte = numero[organizar + 1];
                    numero[organizar + 1] = numero[organizar];
                    numero[organizar] = suporte;
                }
            }
        }
        for (int listar = 0; listar < 5; listar++)
        {
            Console.Write($"{numero[listar]} - ");
        }
    }
}