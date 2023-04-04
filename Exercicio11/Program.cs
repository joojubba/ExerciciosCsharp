//Escreva um algoritmo para ler o número de eleitores de um município,  o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

int numeroEleitores;
int votoBranco;
int votoNulo;
int votoValido;

Console.WriteLine("Informe a quantidade de eleitores:");
numeroEleitores = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de votos em branco:");
votoBranco = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de votos nulos:");
votoNulo = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de votos válidos:");
votoValido = int.Parse(Console.ReadLine());

int totalBranco = (votoBranco * 100) / numeroEleitores;
int totalNulo = (votoNulo * 100) / numeroEleitores; ;
int totalValido = (votoValido * 100) / numeroEleitores; 

Console.WriteLine("O percentual de votos brancos foi:" + totalBranco + " % de " + numeroEleitores + " votos");
Console.WriteLine("O percentual de votos nulos foi:" + totalNulo + " % de " + numeroEleitores + " votos");
Console.WriteLine("O percentual de votos válidos foi:" + totalValido + " % de " + numeroEleitores + " votos");