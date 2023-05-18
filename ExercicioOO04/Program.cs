

using ExercicioOO04;

public class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        p.Nome = "Jo";
        p.Idade = 26;
        Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
    }
}
