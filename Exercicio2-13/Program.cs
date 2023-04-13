/*Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7
 * 
 * */

double h, homem, mulher;

Console.WriteLine("Informe a altura: ");
h = double.Parse(Console.ReadLine());

homem = (72.7 * h) - 58;
Console.WriteLine("Peso ideal para homens: " + homem);
mulher = (62.1 * h) - 44.7;
Console.WriteLine("Peso ideal para mulheres: " + mulher);