/*Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
 * */


double tamanho, cobertura, latas, precoTotal;

Console.WriteLine("Informe o tamanho em metros quadrados da área a ser pintada:");
tamanho = double.Parse(Console.ReadLine());

cobertura = tamanho / 3;
latas = (int)cobertura / 18;

if (cobertura % 18 != 0)
{
    latas += 1;
}
precoTotal = latas * 80;
Console.WriteLine("A quantidade de latas de tinta a serem compradas: " +  latas +
    ". E o preço total é de R$ " + precoTotal);


