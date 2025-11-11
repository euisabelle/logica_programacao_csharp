//

const int maioridade = 18;
const int ZERO = 0;

Console.WriteLine("Qual a sua idade? ");

string resposta = Console.ReadLine();

bool ehValido = int.TryParse(resposta, out int idade);

if (ehValido)
{
    if (idade >= maioridade)
    {
        Console.WriteLine("Usuário é maior de idade");
    }
    else if (idade < ZERO)
    {
        Console.WriteLine("Idade Inválida");
    }
    else
    {
        Console.WriteLine("Usuário é menor de idade");
    }
}
else
{
    Console.WriteLine("Valor Inválido");
}























