//CALCULANDO O DOBRO DE UM NÚMERO

Console.WriteLine("Digite um número: ");
int N = int.Parse(Console.ReadLine());

const int dobro = 2;

int calcDobro = N * dobro;
Console.WriteLine("O dobro do número "+ N + " é: " +  calcDobro );


//CALCULANDO ÁREA E PERÍMETRO DE UM QUADRADO

Console.WriteLine("\n Digite o valor de um dos lados de um quadrado para calcular a área: ");
int lQuad = int.Parse(Console.ReadLine());

int areaQuad = lQuad * lQuad;
int perQuad = lQuad * 4;

Console.WriteLine("Á área do quadrado é: " + areaQuad);
Console.WriteLine("O perímetro do quadrado é: " + perQuad);

if (areaQuad > 1000 )
{
    Console.WriteLine("É um quadrado grande! Sua área é maior que 1000!");
}
else
{   
    Console.WriteLine("É um quadrado pequeno! Sua área é menor ou igual a 1000!");
}

//CALCULANDO UM NÚMERO E DESCOBRIR SE É PAR OU IMPAR

Console.WriteLine("\n Digite um número: ");

int nDis = int.Parse(Console.ReadLine());

int calcParImp = nDis % 2;

if (calcParImp > 0)
{
    Console.WriteLine("O número: " + nDis + " é ímpar!");
}
else
{
    Console.WriteLine("O número: " + nDis + " é par!");
}



