/*6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final 
(média das notas das avaliações).
 * */

int alunos, qtdAvaliacoes;
double ava, avaTotal = 0;
double notaFinal = 0;
 

Console.WriteLine("Informe a quantidade de alunos da turma:");
alunos = int.Parse(Console.ReadLine());

Console.WriteLine("Informe quantidade de avaliações aplicadas:");
qtdAvaliacoes = int.Parse(Console.ReadLine());

for (int i = 0; i < alunos; i++)
{
    for(int j = 0; j < qtdAvaliacoes; j++)
    {
        Console.WriteLine("Informe a nota da ava " + (j+ 1) + " do aluno número " + (i+1));
        ava = double.Parse(Console.ReadLine());
        avaTotal += ava;
    }

    notaFinal = avaTotal / qtdAvaliacoes;
    Console.WriteLine("A nota final do aluno " + (i + 1) + " é " + notaFinal);
    avaTotal = 0;
}
