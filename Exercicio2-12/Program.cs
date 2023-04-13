/*Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.
 * */

string codigo;
int numeroHoras;
double salario, extra, salarioExtra;

Console.WriteLine("Informe o código do operário: ");
codigo = Console.ReadLine();
Console.WriteLine("Informe o número de horas trabalhadas: ");
numeroHoras = int.Parse(Console.ReadLine());

salario = 10 * numeroHoras;


if (numeroHoras > 50 )
{
    extra = (numeroHoras - 50);
    salarioExtra= extra * 20 ;
    salario = 10 * (numeroHoras - extra);
    Console.WriteLine("O salário excedente: R$ " + salarioExtra);
    Console.WriteLine("O salário total é de R$ " + (salario + salarioExtra));

}
else
{
    Console.WriteLine("O salário total é de R$ " + salario);
}


