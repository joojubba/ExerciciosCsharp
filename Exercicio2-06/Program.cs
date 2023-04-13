/*
 *  Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)
IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério
 * */

using System.Globalization;

public class Program
{

    public static void Main(string[] args)
    {
        string nome;
        double altura, peso, imc;

        Console.WriteLine("INFORME SEU NOME: ");
        nome = Console.ReadLine().ToUpper();

        Console.WriteLine("INFORME SUA ALTURA (EM METROS): ");
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("INFORME SEU PESO (EM KG): ");
        peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        imc = peso / (altura * altura);

        if (imc < 18)
        {
            Console.WriteLine(nome + ", Você está com baixo peso ");
        }
        if (imc > 18 && imc < 25)
        {
            Console.WriteLine(nome + " , Você está com peso normal ");

        }
        if (imc > 25 && imc < 30)
        {
            Console.WriteLine(nome + ", Você está com sobrepeso ");

        }
        if (imc > 30 && imc < 35)
        {
            Console.WriteLine(nome + ", Você está com obesidade ");

        }
        else if (imc > 35)
        {
            Console.WriteLine(nome + ", Você está com obesidade grau sério ");

        }

    }
}