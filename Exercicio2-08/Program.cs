/*
 *  Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas.
 * */

using System.Globalization;

public class Program
{

    public static void Main(string[] args)
    {
        string nome, codigo;
        double salarioBase, totalVendas, aumento, salarioFinal;

        Console.WriteLine("Informe o código do funcionário:");
        codigo = Console.ReadLine();
        Console.WriteLine("Informe o nome do funcionário:");
        nome = Console.ReadLine();  
        Console.WriteLine("Informe o salário base do funcionário:");
        salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Informe o total de vendas do funcionário:");
        totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(totalVendas > 500 && totalVendas <= 1000)
        {
            aumento = totalVendas * 0.05;
            salarioFinal = aumento + salarioBase;
            Console.WriteLine("O salário base do funcionário " + nome + " (cód.  " + codigo + " ) " + " é R$" + salarioBase
                + " com o aumento de 5%, o total final é de R$ " + salarioFinal);
            
        }
        if(totalVendas > 1000 && totalVendas <= 5000)
        {
            aumento = totalVendas * 0.07;
            salarioFinal = aumento + salarioBase;
            Console.WriteLine("O salário base do funcionário " + nome + " (cód.  " + codigo + " ) " + " é R$" + salarioBase
                + " com o aumento de 7%, o total final é de R$ " + salarioFinal);

        }
        else if(totalVendas > 5000)
        {
            aumento = totalVendas * 0.1;
            salarioFinal = aumento + salarioBase;
            Console.WriteLine("O salário base do funcionário " + nome + " (cód.  " + codigo + " ) " + " é R$" + salarioBase
                + " com o aumento de 10%, o total final é de R$ " + salarioFinal);

        }


    }
}