/* Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse 
valor para a unidade de saída selecionada.
 * */


int medidaEntrada, medidaSaida;
double valor, conversao;

Console.WriteLine("Informe uma medida:\n" +
    "1 -> para metros\n2 -> para centímetros\n3 -> para polegadas\n4 - > para pés");
medidaEntrada = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a medida para converter:\n" +
    "1 -> para metros\n2 -> para centímetros\n3 -> para polegadas\n4 - > para pés");
medidaSaida = int.Parse(Console.ReadLine()); ;

Console.WriteLine("Informe o valor: ");
valor = double.Parse(Console.ReadLine());
conversao = 0;


switch (medidaEntrada )
{
    case 1:
        switch (medidaSaida)
        {
            case 1:
                conversao = valor;
                break;
            case 2:
                conversao = valor * 100;
                break;
            case 3:
                conversao = valor * 39.37;
                break;
            case 4:
                conversao = valor * 3.281;
                break;

        }
        break;

    case 2:
        switch (medidaSaida)
        {
            case 1:
                conversao = valor / 100;
                break;
            case 2:
                conversao = valor;
                break;
            case 3:
                conversao = valor * 0.3937;
                break;
            case 4:
                conversao = valor * 0.03281;
                break;
        }
        break;

    case 3:
        switch (medidaSaida)
        {
            case 1:
                conversao = valor / 39.37;
                break;
            case 2:
                conversao = valor / 0.3937;
                break;
            case 3:
                conversao = valor;
                break;
            case 4:
                conversao = valor / 0.08333;
                break;
        }
        break;

    case 4:
        switch (medidaSaida)
        {
            case 1:
                conversao = valor / 3.281;
                break;
            case 2:
                conversao = valor / 0.03281;
                break;
            case 3:
                conversao = valor / 0.08333;
                break;
            case 4:
                conversao = valor;
                break;
        }
        break;

        
}

Console.WriteLine("Valor convertido: " + conversao);
