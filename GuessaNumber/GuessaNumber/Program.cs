// See https://aka.ms/new-console-template for more information
Random nRand = new Random();

int wNumber = nRand.Next(0, 25);

bool win = false;

do
{
    Console.Write("Guess a number between 0 and 25.");
    Console.WriteLine();
    string answer = Console.ReadLine();

    int pnum = int.Parse(answer);

    if (pnum > wNumber)
    {
        Console.WriteLine("Too high, guess again!");
    }
    else if (pnum < wNumber)
    {
        Console.WriteLine("Too Low, guess again!");
    }
    else if (pnum == wNumber)
    {
        Console.WriteLine("You win!");
        win = true;
    }

    Console.WriteLine();

} while (win == false);

Console.WriteLine("Thanks for playing!");
Console.Write("Press any key to finish");
Console.ReadKey(true);
