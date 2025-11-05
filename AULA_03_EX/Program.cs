/*Peça para o usuário inserir dois números inteiros e mostre-os no Console.
Peça para o usuário inserir dois números inteiros, mostre a soma dos números informados no Console.
Peça para o usuário inserir dois números inteiros, mostre a subtração dos números informados no Console.
Peça para o usuário inserir dois números inteiros, mostre a multiplicação dos números informados no Console.
Peça para o usuário inserir dois números inteiros, mostre a divisão dos números informados no Console (Cuidado com o tipo na hora de mostrar o resultado).*/



Console.WriteLine("Insira um número:");
string N1 = Console.ReadLine();

Console.WriteLine("Insira um outro número:");
string N2 = Console.ReadLine();

Console.WriteLine("Os números inseridos são: " + N1 + " e " + N2);

//ADIÇÃO

Console.WriteLine("Insira um número inteiro para soma: ");
string N3 = Console.ReadLine();

Console.WriteLine("Insira um segundo número inteiro para soma: ");
string N4 = Console.ReadLine();
int adicao = int.Parse(N3) + int.Parse(N4);
Console.WriteLine("O resultado da soma é: " + adicao);

//SUBTRAÇÃO

Console.WriteLine("Insira um número inteiro para SUBTRAÇÃO: ");
int N5 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira um segundo número inteiro para SUBTRAÇÃO: ");
int N6 = int.Parse(Console.ReadLine());
//int subtracao = int.Parse(N5) - int.Parse(N6);
Console.WriteLine("O resultado da SUBTRAÇÃO é: " + (N5 - N6));

//MULTIPLICAÇÃO

Console.WriteLine("Insira um número inteiro para multiplicação: ");
int N7 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira um segundo número inteiro para multiplicação: ");
N7 *= int.Parse(Console.ReadLine());
Console.WriteLine("O resultado da multiplicação é: " + N7);

//DIVISÃO 

Console.WriteLine("Insira um número inteiro para divisão: ");
int N9 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira um segundo número inteiro para divisão");
int N10 = double.Parse(Console.ReadLine());
int divisao = double.Parse(N9) /  double.Parse(N10);
Console.WriteLine("O resultado da divisão é: " + divisao); 