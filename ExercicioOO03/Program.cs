/*Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo 
double e os métodos definirSaldoInicial, depositar e sacar. O método definirSaldoInicial deve atribuir o
valor passado por parâmetro ao atribuito saldo O método depositar, deve adicionar o valor passado por
parâmetro ao atributo saldo O método sacar deve reduzir o valor passado por parâmetro do saldo já 
existente Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
quando não for possível
 * */
using ExercicioOO03;

public class Program
{
    static void Main(string[] args)
    {
        
       
        ContaCorrente conta = new ContaCorrente();
        conta.DefinirSaldoInicial(1000);
        conta.Depositar(500);
        bool saque = conta.Sacar(10);
        Console.WriteLine($"foi possível realizar o saque? {saque}");

    }

}