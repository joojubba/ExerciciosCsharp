/* Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#).
 * */



int tentativas = 0;
int num = 0;
int numRandom;

Random random = new Random();
random.Next(100);

numRandom = random.Next(0,100);

Console.WriteLine("Jogo de adivinhação do número secreto");

while (true)
{
    tentativas++;


    Console.WriteLine("Informe um número de 0 a 100: ");
    num = int.Parse(Console.ReadLine());

    if(tentativas < 3)
    {
        if (num < numRandom)
        {
            Console.WriteLine("Dica: é maior");
        }
        else if (num > numRandom)
        {
            Console.WriteLine("Dica: é menor");
        }
        if (num == numRandom)
        {
            Console.WriteLine("Acertou! O número secreto é o " + numRandom);
            break;

        }
    }
    else
    {
        Console.WriteLine("Sem mais tentativas! O número secreto era o " + numRandom);
        break;
    }
   
}

