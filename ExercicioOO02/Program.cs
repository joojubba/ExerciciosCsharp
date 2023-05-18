/*Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matrícula
do aluno, o segundo recebe apenas a data de nascimento do aluno e o terceiro construtor recebe o nome
do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.
 * */




using ExercicioOO02;

public class Program
{
    static void Main(string[] args)
    {

        Aluno aluno1 = new Aluno("jo", 25369);

        Aluno aluno2 = new Aluno(new DateTime(2000,07,13));

        Aluno aluno3 = new Aluno("lana", new DateTime(2001, 08, 01), 2023);
    }

}

