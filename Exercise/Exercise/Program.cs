const int Scirrors = 1;
const int Paper = 2;
const int Rock = 3;
const int Lizard = 4;
const int Spock = 5;

Console.WriteLine("Player1: ");
int player1 = int.Parse(Console.ReadLine());
Console.WriteLine("Player2: ");
int player2 = int.Parse(Console.ReadLine());

bool playerWin = ((player1 == Scirrors) && (player2 == Paper))
    || ((player1 == Scirrors) && (player2 == Lizard))
    || ((player1 == Paper) && (player2 == Rock))
    || ((player1 == Paper && (player2 == Spock))
    || ((player1 == Rock) && (player2 == Lizard))
    || ((player1 == Rock) && (player2 == Scirrors))
    || ((player1 == Lizard) && (player2 == Spock))
    || ((player1 == Lizard) && (player2 == Paper))
    || ((player1 == Spock) && (player2 == Rock))
    || (player1 == Spock) && (player2 == Lizard));

if (player1 == player2)
{
    Console.WriteLine("Hoa");
}else if (playerWin)
{
    Console.WriteLine("Player1 Win!");
} else
{
    Console.WriteLine("Player2 Win!");
}