//SWITCHCASE COM 5 INPUTS S/ "FOR"

int votos1 = 0;
int votos2 = 0;
int votos3 = 0;
int votosNul = 0;

const string msgVoto = "\n\nVote em uma das opções abaixo para decidir e digite o número: \n\n 1 - Sair na hora do intervalo \n 2 - sair 30min mais cedo \n 3 - Sair no horário habitual \n 4 - extender a aula em 30min";

Console.WriteLine("VOTAÇÃO");
Console.WriteLine("VOTAÇÃO");

for (int count = 0; count < 5; count++)
{

    //VEZ 01

    Console.WriteLine(msgVoto);

    int voto = int.Parse(Console.ReadLine());


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


}

Console.WriteLine("\n\nVotação Encerrada!");

int vencedor = 0;

Console.WriteLine("\n\nVotos Opção 1: " + votos1);
Console.WriteLine("Votos Opção 2: " + votos2);
Console.WriteLine("Votos Opção 3: " + votos3);
Console.WriteLine("Votos nulos: " + votosNul);