//SWITCHCASE COM 5 INPUTS S/ "FOR"

const string msgVoto = "\n\nVote em uma das opções abaixo para decidir e digite o número: \n\n 1 - Sair na hora do intervalo \n 2 - sair 30min mais cedo \n 3 - Sair no horário habitual \n 4 - extender a aula em 30min";

Console.WriteLine("VOTAÇÃO");

//VEZ 01

Console.WriteLine(msgVoto);

int voto = int.Parse(Console.ReadLine());

int votos1 = 0;
int votos2 = 0;
int votos3 = 0;
int votosNul = 0;

switch (voto)
{
    case 1:
        votos1++;
        break;
    case 2: 
        votos2++;
        break;  
    case 3: 
        votos3++;
        break;
    default:
        votosNul++;
        Console.WriteLine("\n\nVocê anulou seu voto!");
        break;
}


//VEZ 02

Console.WriteLine(msgVoto);

voto = int.Parse(Console.ReadLine());

switch (voto)
{
    case 1:
        votos1++;
        break;
    case 2:
        votos2++;
        break;
    case 3:
        votos3++;
        break;
    default:
        votosNul++;
        Console.WriteLine("\n\nVocê anulou seu voto!");
        break;
}


//VEZ 03

Console.WriteLine(msgVoto);

voto = int.Parse(Console.ReadLine());

switch (voto)
{
    case 1:
        votos1++;
        break;
    case 2:
        votos2++;
        break;
    case 3:
        votos3++;
        break;
    default:
        votosNul++;
        Console.WriteLine("\n\nVocê anulou seu voto!");
        break;
}


//VEZ 04

Console.WriteLine(msgVoto);

voto = int.Parse(Console.ReadLine());

switch (voto)
{
    case 1:
        votos1++;
        break;
    case 2:
        votos2++;
        break;
    case 3:
        votos3++;
        break;
    default:
        votosNul++;
        Console.WriteLine("\n\nVocê anulou seu voto!");
        break;
}



//VEZ 05

Console.WriteLine(msgVoto);

voto = int.Parse(Console.ReadLine());

switch (voto)
{
    case 1:
        votos1++;
        break;
    case 2:
        votos2++;
        break;
    case 3:
        votos3++;
        break;
    default:
        votosNul++;
        Console.WriteLine("\n\nVocê anulou seu voto!");
        break;
}

Console.WriteLine("\n\nVotação Encerrada!");

int vencedor = 0;

Console.WriteLine("\n\nVotos Opção 1: " + votos1);
Console.WriteLine("Votos Opção 2: " + votos2);
Console.WriteLine("Votos Opção 3: " + votos3);
Console.WriteLine("Votos nulos: " + votosNul);
