/*
 * Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
se a média das duas notas for maior ou igual a 7,0. 
Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
é a média entre a nota do exame e a média das 2 notas. 
Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
escrever “Reprovado”.
 * */
using System.Globalization;

public class Program
{

    public static void Main(string[] args)
    {
        double nota1,nota2, nota3, media, mediaFinal;

        Console.WriteLine("Informe a nota 1: ");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Informe a nota 2: ");
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = (nota1 + nota2) / 2;

        if(media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Informe a nota do exame: ");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mediaFinal = (nota3+media) / 2;

            if(mediaFinal >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}