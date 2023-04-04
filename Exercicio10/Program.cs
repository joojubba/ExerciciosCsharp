/*Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.*/

Console.WriteLine("Informe o valor que deseja sacar:");
int saque = int.Parse(Console.ReadLine());



Console.WriteLine(saque / 100 + " nota(s) de R$ 100,00");
saque = saque % 100;
Console.WriteLine(saque / 50 + " nota(s) de R$ 50,00");
saque = saque % 50;
Console.WriteLine(saque / 20 + " nota(s) de R$ 20,00");
saque = saque % 20;
Console.WriteLine(saque / 10 + " nota(s) de R$ 10,00");
saque = saque % 10;
Console.WriteLine(saque / 5 + " nota(s) de R$ 5,00");
saque = saque % 5;
Console.WriteLine(saque / 2 + " nota(s) de R$ 2,00");
saque = saque % 2;
Console.WriteLine(saque / 1 + " nota(s) de R$ 1,00");


