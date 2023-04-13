/*
 *  Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

 * */


public class Program
{

    public static void Main(string[] args)
    {
        string frase, palavra;

        Console.WriteLine("Informe uma frase: ");
        frase = Console.ReadLine();
        Console.WriteLine("Informe uma palavra");
        palavra = Console.ReadLine();   

        if(frase.Contains(palavra))
        {
            Console.WriteLine("A palavra encontra-se na frase");
        }
        else
        {
            Console.WriteLine("A palavra não se encontra na frase");
        }
    }
}