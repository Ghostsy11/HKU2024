using System.Globalization;

namespace FeedmeMiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome contestant
            // Create a variable to store the guess
            // Ask the user for their guess
            // parse the resualt as an integer
            // While loop until we get our desired outcome
            // We end thanks messagez
            Console.WriteLine("Hi Feedme Welcome in Ghost MiniGame would like to play a mini gussing number game?" + "You can simplay type yes or no");
            var numberToGuess = new Random().Next(101);
            var Answer = Console.ReadLine();
            while (Answer != "yes")
            {
                if (Answer == "no")
                {
                    Console.WriteLine("Sad!");
                    break;
                }
                else Console.WriteLine($" you have to choose yes or no feedme not {Answer} ");
                Answer = Console.ReadLine();

            }
            if (Answer == "yes")
            {
                Console.WriteLine("Thank you For playing with me lets starts");
                Console.WriteLine("Feedme Gusse number between 0-100");
                Console.WriteLine("If you want to change the number type Change");

                while (true)
                {
                    var FeedmeGussedNumber = Console.ReadLine();
                    if (FeedmeGussedNumber == "Cheat")
                    {
                        Console.WriteLine($"oh feedme why you cheating {numberToGuess}");
                        FeedmeGussedNumber = Console.ReadLine();
                    }
                    if (FeedmeGussedNumber == "Change")
                    {
                        numberToGuess = new Random().Next(101);
                        Console.WriteLine("Number has been changed try now");
                        FeedmeGussedNumber = Console.ReadLine();
                    }
                    int.TryParse(FeedmeGussedNumber, out var newGussedNumber);
                    if (newGussedNumber == numberToGuess)
                    {
                        Console.WriteLine("You got it right dumb ass");
                        break;
                    }
                    else if (newGussedNumber > numberToGuess)
                    {
                        Console.WriteLine("You gussed to high try again");
                    }
                    else if (newGussedNumber < numberToGuess)
                    {
                        Console.WriteLine("Your gussed is to low try bit higher");
                    }
                    else Console.WriteLine($"That is invaild answer please gusse a number you can't answer like that  {FeedmeGussedNumber}");
                }
            }
        }
    }
}