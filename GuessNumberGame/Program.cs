using System.Linq.Expressions;

class Game
{
    public void Start()
    {
        int firstNumber = 0, secondNumber = 0;
        int findNumber = 0;
        
        //start game
        Console.WriteLine("Enter first and last number in game");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        secondNumber = Convert.ToInt32(Console.ReadLine());
        //Exception
        if (firstNumber == secondNumber) 
        {
            Console.WriteLine("Error, enter the numbers again");
            Start();
        }
        //random
        Random rnd = new();
        findNumber = rnd.Next(firstNumber, secondNumber);
        GameIteration(findNumber);
    }

    private void GameIteration(int findNumber)
    {
        Console.WriteLine("Enter a random number");
        int guessNumber = Convert.ToInt32(Console.ReadLine());
        if (guessNumber == findNumber) 
            EndGame();
        else
            Console.WriteLine("that number" + (guessNumber > findNumber ? " bigger" : " lower"));
        GameIteration(findNumber);
    }

    private void EndGame()
    {
        Console.WriteLine("Win");
        Console.WriteLine("next? \n0 - yes, 1 - no");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 1)
            Environment.Exit(0);
        else if (answer == 0)
            Start();
        else Start();//////////
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}