
using GuessNumberGame;
using System.Xml;


Random rnd = new Random();
int bottom, top;
int trialNumber;

do
{
    int answer;

    Console.WriteLine("1 - play, 0 - exit");
    if(!int.TryParse(Console.ReadLine(), out answer))
    {
        Console.WriteLine("Error");
        continue;
    }    

    if (answer != 1)
        break;
    

    Console.WriteLine("Enter borders");
    if (!int.TryParse(Console.ReadLine(), out bottom))
    {
        Console.WriteLine("Error");
        continue;
    }
    if (!int.TryParse(Console.ReadLine(), out top))
    {
        Console.WriteLine("Error");
        continue;
    }

    IDesiredNumber desiredNumber = new DesiredNumber(rnd.Next(bottom, top));

    do
    {
        Console.WriteLine("Enter you number");

        if (!int.TryParse(Console.ReadLine(), out trialNumber))
        {
            Console.WriteLine("Error");
            continue;
        }

        CompareTypes typeOfNumber = desiredNumber.CompareNumber(trialNumber);
        //logic
        if (typeOfNumber == CompareTypes.Bigger)
            Console.WriteLine("bigger");
        else if (typeOfNumber == CompareTypes.less)
            Console.WriteLine("less");
        else
        {
            Console.WriteLine("win");
            break;
        }

    } while (true);


    

} while (true);