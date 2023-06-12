//Não queria manter um número fixo como número secreto sempre, então criei uma forma de gerar um número pseudo-aleatório:

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

//Agora, desenvolvendo a lógica do jogo, o seguinte código:

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }

} while (true); 

//Caso o chute seja igual ao número secreto, ira exibir a mensagem indicando que o jogo acabou:

Console.WriteLine("O jogo acabou. Você acertou o número secreto!"); 

