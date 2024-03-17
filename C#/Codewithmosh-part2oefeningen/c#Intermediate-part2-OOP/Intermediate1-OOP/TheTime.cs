using System;

namespace TheTime_
{


    // Exercise 1 
    // Class exercies
    public class TheTime
    {
        public void TimeNow()
        {
            Console.WriteLine("Pls Enter S for start than press s to stop when ever you wish to. Otherwise press enter to exit the program");
            var Start = DateTime.Now;
            while (true)
            {

                var userInput = Console.ReadLine();
                if (userInput == string.Empty)
                {
                    Console.WriteLine("Sad not to count the time");
                    break;
                }

                if (userInput == "S" || userInput == "s")
                {
                    if (userInput == "S")
                    {
                        Console.WriteLine("You time is started: " + Start + " " + "\nPres now s if you wish to go to the next step of counting time");
                        continue;
                    }
                    if (userInput == "s")
                    {
                        var later = DateTime.Now - Start;
                        Console.WriteLine("If you want the duration type yes else no to continue counting");
                        var userInput1 = Console.ReadLine();
                        if (userInput1 == string.Empty)
                        {
                            Console.WriteLine("Sad not to count the time");
                            break;
                        }
                        if (userInput1.ToLower() == "yes")
                        {
                            Console.WriteLine(later);
                            break;

                        }
                        if (userInput1.ToLower() == "no")
                        {
                            Console.WriteLine("That is fine are you done now?: Pls Enter S for start than press s to stop when ever you wish too");

                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You have to enter vaild answer either S or s else press enter to exit");
                }

            }
        }
    }
}
