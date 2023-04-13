﻿/*
 * Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
 *Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.

 **/

using System.Globalization;


double a, b, c;

Console.WriteLine("Informe o 1º valor de glicemia em jejum: ");
a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
if (a < 65)
{
    Console.WriteLine("Atenção: corre risco de hipoglicemia");
}
if (a > 250)
{
    Console.WriteLine("Atenção: corre risco de hiperglicemia");
}

Console.WriteLine("Informe o 2º valor de glicemia em jejum: ");
b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
if  (b < 65 )
{
    Console.WriteLine("Atenção: corre risco de hipoglicemia");
}
if (b > 250)
{
    Console.WriteLine("Atenção: corre risco de hiperglicemia");
}
Console.WriteLine("Informe o 3º valor de glicemia em jejum: ");
c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (c < 65)
{
    Console.WriteLine("Atenção: corre risco de hipoglicemia");
}
if (c > 250)
{
    Console.WriteLine("Atenção: corre risco de hiperglicemia");
}

double media = (a + b + c) / 3;
Console.WriteLine("Média dos 3 valores de glicemia coletados: " + media);
if (media < 80)
{
    Console.WriteLine("Atenção: é preciso diminuir 2 unidades de insulina");
}
if(media > 150)
{
    Console.WriteLine("Atenção: é necessário adicionar 2 unidades de insulina");
    
}