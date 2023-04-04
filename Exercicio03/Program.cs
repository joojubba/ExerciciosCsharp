// 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.


Console.WriteLine("Informe valor A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe valor B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("valor A: " + a + " e B: " + b);

int c = a;
a = b;
b = c;

Console.WriteLine("Novo valor convertido A: " + a + " e B: " + b);

