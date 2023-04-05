//Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

using static System.Console;
public class Program
{

    public static void Main(string[] args)
    {
        int num;

        WriteLine("Informe um número: ");
        num = int.Parse(Console.ReadLine());

        if(num % 2 == 0)
        {
            WriteLine("Número é par");
        }
        else
        {
            WriteLine("Número é impar");
        }

    }
}