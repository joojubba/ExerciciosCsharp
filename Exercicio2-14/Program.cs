/*Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).
 * */

double tamMb, velMbps, tempoSeg, velMb, tempoAprox;

Console.WriteLine("Informe o tamanho de um arquivo para download (em MB):");
tamMb = double.Parse(Console.ReadLine());

Console.WriteLine("Informe velocidade do link de Internet(em Mbps):");
velMbps = double.Parse(Console.ReadLine());

velMb = velMbps / 8;
tempoSeg = tamMb / velMb;
tempoAprox = tempoSeg / 60;

Console.WriteLine("O tempo aproximado de download do arquivo " +
    "usando este link(em minutos): " + tempoAprox);
