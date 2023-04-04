// Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula da conversão é F=(9*C+160)/ 5.

Console.WriteLine("Informe a temperatura em Celsius:");
double c = double.Parse(Console.ReadLine());
double f = (9 * c + 160) / 5;
Console.WriteLine("A temperatura convertida em Fahrenheit é: " + f);