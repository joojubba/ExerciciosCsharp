//Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
//Mostrar na tela qual dos professores tem o maior salário total.

using static System.Console;
using System.Globalization;

public class Program
{

    public static void Main(string[] args)
    {
        WriteLine("Informe a quantidade de hora aula do Professor 1: ");
        int aula1 = int.Parse(Console.ReadLine());
        WriteLine("Informe o vador da hora aula do Professor 1: ");
        double valorAula1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        WriteLine("Informe a quantidade de hora aula do Professor 2: ");
        int aula2 = int.Parse(Console.ReadLine());
        WriteLine("Informe o vador da hora aula do Professor 2: ");
        double valorAula2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double horaAula1 = aula1 * valorAula1;
        double horaAula2 = aula2 * valorAula2;

        if (horaAula1 > horaAula2)
        {
            WriteLine("Professor 1 recebe o maior salário total: R$ " + horaAula1);
        }
        else
        {
            WriteLine("Professor 2 recebe o maior salário total: R$ " + +horaAula2);
        }

    }
}