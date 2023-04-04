// Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel  (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível consumido para percorrê-la (medido em l).



Console.WriteLine("Informe a distância que foi percorrida em km:");
double km = double.Parse(Console.ReadLine());

Console.WriteLine("Informe quantos litros gastos:");
double l = double.Parse(Console.ReadLine());

double consumoMedio = km / l;
Console.WriteLine("Consumo médio de um automóvel (medido em Km / l): " + consumoMedio);
