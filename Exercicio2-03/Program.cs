
//Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.



using static System.Console;
public class Program
{

    public static void Main(string[] args)
    {
        WriteLine("Informe o valor 1: ");
        double valor1 = double.Parse(Console.ReadLine());
        WriteLine("Informe o valor 2: ");
        double valor2 = double.Parse(Console.ReadLine());
        WriteLine("Informe o valor 3: ");
        double valor3 = double.Parse(Console.ReadLine());
        WriteLine("Informe o valor 4: ");
        double valor4 = double.Parse(Console.ReadLine());

        double media = (valor1 + valor2 + valor3 + valor4) / 4;

        if (valor1 > media)
        {
            WriteLine("Valor 1 é maior que a média");
        }
        if (valor2 > media)
        {
            WriteLine("Valor 2 é maior que a média");
        }
        if (valor3 > media)
        {
            WriteLine("Valor 3 é maior que a média");
        }
        if (valor4 > media)
        {
            WriteLine("Valor 4 é maior que a média");
        }

    }
}