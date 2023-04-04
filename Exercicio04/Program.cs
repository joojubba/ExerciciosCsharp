// 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

Console.WriteLine("Informe o dia:");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o mês:");
int mes = int.Parse(Console.ReadLine());


Console.WriteLine("Informe o ano:");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine("Data recebida: "  + ano + " / " + mes + " / " + dia);


