/*16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
 * */

int timeCasa, timaFora, difPlacar;


while (true)
{
    Console.WriteLine("Informe o placar do jogo!");
    Console.WriteLine("time da casa x  time de fora: "); 
    string[] placar = Console.ReadLine().Split('x');
    timeCasa = int.Parse(placar[0]);
    timaFora = int.Parse(placar[1]);

    difPlacar =  timaFora - timeCasa;
    if (difPlacar <= 1)
    {
        Console.WriteLine("Os dois times se enfrentarão em um novo jogo");
        continue;
    }
    else if(difPlacar >= 2)
    {
        Console.WriteLine("O time de fora já se classificou");
        break;
    }
}
