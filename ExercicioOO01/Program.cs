/*1 - Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e 
outro recebendo apenas a idade. Solicite ao usuário qual dos construtores ele gostaria de utilizar 
na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo 
dos parâmetros recebidos.
 * */
using ExercicioOO01;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qal dado quer exibir ? 1 - Nome e Idade, " +
            "2  - apenas idade:  ");
        string nome;
        int idade;
        int escolha = int.Parse(Console.ReadLine());
        if (escolha == 1)
        {
            Console.WriteLine("digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("digite a idade");
            idade = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(nome, idade);


        }
        else if (escolha ==2)
        {
            Console.WriteLine("digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(idade);
        }




    }

}