/*
 * Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero
 * 
 * */

using static System.Console;
public class Program
{

    public static void Main(string[] args)
    {
        double area, b, altura;

        WriteLine("Informe o valor de base: ");
        b = double.Parse(Console.ReadLine());
        WriteLine("Informe o valor de altura: ");
        altura = double.Parse(Console.ReadLine());


        if (b == 0 || altura == 0)
        {
            WriteLine("Valor inválido");
        }
        else
        {
            area = b * altura / 2;
            WriteLine("Área do triângulo é  " + area);
        }
    }
}