
## Important stuff to keep in mind as developer

```Visual studio IDE: is where you can code, make projects and build the programs. That is called Inetgrated development environment.```

``` In Solution you can find the project and there could be more than one project if you want to.```

``` When you pres F5 the visual studio will run and build your program. A notification will pop up and says for example "C:\Users\abood\Desktop\C#-progress\PorgressCharp\PorgressCharp\bin\Debug\net7.0\PorgressCharp.exe (process 31348) exited with code 0." (0 mean your program exited successfully.) ```

``` Rule 1 : Using directives and statement most end with semicolon. Rule 2 : Namespaces, classes, methods use buly braces {} ```

```c#
using System; // Using directive

namespace PorgressCharp // Namespace declaration
{// Start class block
    internal class Program // Create clss
    { //Start class block
        static void Main(string[] args) // Create method
        { // Start method block
            Console.WriteLine("Hello, World!"); // Expression statement
        } // End method block
    } //End class block
}// End Namespace block
```
```Different ways to write the same code```
```c#
using System;
namespace PorgressCharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // counter is operanders and +-/% are operators.
            int counter = 5;
            Console.WriteLine("counter is " + counter);
            counter += 2; // output 7
            Console.WriteLine("counter is " + counter);
            counter = 5;
            counter= counter + 2; // output 7
            Console.WriteLine("counter is " + counter);

            counter = 3; // set vaule to 3
            Console.WriteLine("counter is " + counter);
            counter++; // output 4
            Console.WriteLine("counter is " + counter);
            counter--; // output 3
            Console.WriteLine("counter is " + counter);

            counter = 10; // set vaule to 10
            Console.WriteLine("counter is " + counter);
            counter *= 3; // output 30
            Console.WriteLine("counter is " + counter);

            counter = 10;
            counter = counter * 3; // output 30
            Console.WriteLine("counter is " + counter);


            // different ways to write the operanders and the operators ^^
        }
    }
}
```

## Data types
```Each type has its own limits and own function. You can use the type you wish to prevent data collapse or errors```


| IntegerTypes  | Min-Max vaule | Default value| Represents |
| :----- | :----- |:----- |:----- |
| sbyte | -128 to 127 |0| 8-bit signed integer type|
| byte | 0 to 255 |Geen|8-bit unsigned integer|
| short | -32,768 to 32,767 |0| 16-bit signed integer type|
| ushort | 0 to 65,535 |0|16-bit unsigned integer type|
| int | -2,147,483,648 to 2,147,483,647|0|32-bit signed integer type |
| uint | 0 to 4,294,967,295|0| 32-bit unsigned integer type |
| long | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |0L|64-bit signed integer type |
| ulong | 0 to 18,446,744,073,709,551,615 |0|64-bit unsigned integer type |

```Float type does't has a unsigned float type```

| FloatType  | Min-Max vaule |Default value |Represents |
| :----- | :----- |:----- |:----- |
| float |approximtely 6-9 digits| 0.0F |32-bit single-precision floating point type|
| double |approximtely 15-17 digits| 0.0D |64-bit double-precision floating point type|
| decimal |approximtely 28-29 digits| 0.0M |128-bit precise decimal values with 28-29 significant digits|


| DataTypes  | Default value |Represents |
| :----- | :----- |:----- |
| Bool | False |Boolean value|
| Char | '\0' |0 to 65,535|
| string | |Depeands on size of the array|

`Suffix`
```c#
            // Suffix 
            // when you use datatypes each datatype has it own suffix that you can see down in example
            // using var keyword prevent you to repeat the code and make it easier and cleaner to read.
            // Behind the scenes when its compiled to IL code var does not exist the  code simply gets changed back to the explicit variable.
            var myByte = 0b0101;
            var mySbyte = -0b0101;
            // (short)1 that call casting.
            var myShort = (short)1;
            var myUshort = (ushort)1;
            var myInt = 1;
            var myUint = (uint)1;
            var myLong = 1L;
            var myUlong = 1UL;
            var myFloat = 1.1F;
            var myDouble = 1.1;
            var myDecimal = 1.1M;            
            
```

## Important to keep in mind

``` To find out about the size of given types you use Sizeof().. that will give you the size of the given types in bytes for example:```

```c#
using System;

namespace PorgressCharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we multiple by 8 so we get the size in bits
            // otherwise if we want it in byte you can remove the 8.
            //in bits
            bool myBool;
            int myInt;
            float myFloat;
            Console.WriteLine($"A bool is{sizeof(bool) * 8 }");
            Console.WriteLine($"A int is{sizeof(int) * 8 }");
            Console.WriteLine($"A float is{sizeof(float) * 8 }");

            // in bytes
            Console.WriteLine($"A bool is{sizeof(bool)} bytes");
            Console.WriteLine($"A int is{sizeof(int)}bytes");
            Console.WriteLine($"A float is{sizeof(float)}bytes");

        }
    }
}
```
## Methods

`Why we use the Methods for? and what are the benefits of the Methods`
-
- To self-contain units of reuseable code
- To reduce repetitive code
- To make code easier to read
  
## Access modifiers
`What are Access modifiers and what we use them for?`
- 
- 



```c#
using System;

namespace Methods
{
    internal class Program
    {
        // VOID returns nothing
        static void Main(string[] args)
        {
            // first way to call the method 
            Console.WriteLine(GetUserDateOfBirth("Ghost")); //WrtieLine is an method
            string Result = GetUserDateOfBirth("Leo"); //second way to call the method
            Console.WriteLine(Result);// 2
        }

        // (Pascal case) is way to write method in certin way.. that way is obvious and most preferred naming convention cor methods names.
        // To use PascalCase you write first letter capitalletter on  beginning  of word.
        // Method is GetUserDateOfBirth() in that case
        // Parameters/arguments can be found in method in that case it is (String FullName)
        // to separate parameters you use a ,
        // CamelCase is also other way to write parameters where you write first letter of beginning of word smallletter and rest of world capitalletter such as (fullName)  
        public static string GetUserDateOfBirth(String FullName)
        {
            return FullName + " Was born on Monday ";
        }
         
    }
}
 ```
 ## Debuger/Debugging
`Why we debug our code?`
- Developer use debuger to investigating a problem in code or testing code out
- Debuger is almost the most powerful tool in VS it help us insaily to find and fix problems in code
- Debuging represent 50% of softwear development I most master debuging because its such important tool

## Debugging shortcuts and functions
| first  | second |kenmerk |
| :----- | :----- |:----- |
| How do we start debugging | F5 |answer |
| How do set a breakpoint | Single click grey bar to the left of line | Red |
| What color is a line with breakpoint when it is hit | hover over the line |Yellow |
| What color is a line with breakpoint when its set but not hit | | Red |
| How do we step over code | F10 |answer |
| How do we run our code  to continue  until the next breakpoint | F5 |answer |
| What does a red value in the watch window mean| The value has changed snice the last step evaluation |answer |
| What does the locals window show |  | The variables available in the current scope |
| How do we start debugging | F5 |answer |
| How To step into method line by line| F11 | |

- example of debugging
```c#
using System;

namespace Debuging
{
    internal class Program
    {
        // VOID returns nothing
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            double a = 1;
            double b = 0;

            double result = a / b;
            Console.WriteLine(result);// The result when you run the program will be 8 which is clearly wrong.
            // for that reason we use the debuger.
            // in debugger you can watch the locals and add watch the line you select to find out in tablet what is happening and fix the problem.
            // once you find out the problem you can fix it in that case we will
            // convert double number to string result coz after we debug it the result says word (infinity) and that is string
            // to change double to string we will use (.Tostring method) that you can see here down.

            //Console.WriteLine(result.ToString()); // if we print it that way will the result be 8 that way is wrong for that reason we will use another way.

            string resultString = result.ToString();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(resultString);
            // the result will be still 8 even though our code is correct but if we look in locals it says we have formating problem. 
            // in that case we have to encoding.utf8 to able to see the result is infinity.
        }
    }
}
``` 
## Parse Methods
`Parsing means that text into specific type for storing dates and its also means to take some information and interpret it in other way`

- What does parsing do? It vonverts strings to various types
- What input types do parse methods support? Strings
- Where is the result of a successful TryPase stored? A local variable is passed in and modified through Out word.
--- 
```c#
using System.Globalization;

namespace BirthDayCalculator
{// how to use parsing and .Parse and .TryPase 
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();
            var userDateOfBirth = AskForDateOfBirth();
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy." + "I,m really good at guessing the" + "day of the week you were born on.");
        }
        public static DateTimeOffset AskForDateOfBirth()
        {
            Console.WriteLine($"Can i start by asking you " +
                $"what your date of birth is ? { CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns } ");
            var userText = Console.ReadLine();
            return DateTimeOffset.Parse(userText);// if you write the code here it will thorow a exacption and crush your program. for that reason in that case we will use Tryparse
            var parsedDate = DateTimeOffset.MinValue; // here we set value to parsedDate.
           var succeeded = DateTimeOffset.TryParse(userText, out parsedDate); // we used trypase to prevent crushing the program but instead give us false value.
            return parsedDate;
        }

    }
} 
```

## string Interpolation
- $ Symbol
- .ToString
---
```C#
using System.Globalization;

namespace BirthDayCalculator
{//string Interpolation  
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();
            var userDateOfBirth = AskForDateOfBirth();
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy." + "I,m really good at guessing the" + "day of the week you were born on.");
        }
        public static DateTimeOffset AskForDateOfBirth()
        {
            // example 3
            var someString = "Some string"; // string type 
            var someString2 = "Some" + "string"; // string type 
            var someString3 = 5.ToString(); // integer type which is converted to string thorugh .ToString method
            var someString4 = "I got " + 400.ToString() + " today"; // that line of code is works fine but there is better and more pro way to write just like i mentioned in example 3
            var someString5 = $"I got {400} today";// if i run the code it will show me locals that 400
                                                   // is string type without I have to converted by Tostring. that is because when I use curly braces it does that from its self
                                                   // that is just same result as someString4 its only clearen and better way to write code

            // the code here is vaild and works fine but when you have more line it will becomes messy. messy code is not pro work which you can see in example 1.
            Console.WriteLine("Can I start by asking you" + "what your date of birth is?"
                + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
            // By using the $ symbol you will be able to make the strings looks better and cleaner. which you can see in example 2.

            // Inside the curly braces you will retrun the vaule of the data that you   used in that case was it  CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns. 

            // Because c# is powerful programming language when you add the vaule inside carlybraces the cyrly braces will
            // convent the data to the type its requer from it self. that you can see in example 3

            // Here is the way how to use parsing CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns
            Console.WriteLine($"Can i start by asking you " +
                $"what your date of birth is ? { CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns } ");
            var userText = Console.ReadLine();
            return DateTimeOffset.Parse(userText);

        }
    }
} 
```
## if - else if - else
``
- What is expected inside of an if parentheses? A value of true or false or an expression that evaluates to true or flase.
- When should we prefer if/ else statements over if statement? if both statements can never e truth.
- What is the diffrence between else and else if?  Else if has to have an expression.
- When would you use an else statement? to catch anything not caught by the previous if else statement.
- You can have if statement and inside if  you can have also more condations it depends how you want it if you also want more agrument you can use if else if that also and if and else if does are not true or the way you code the agrument you can use else.
- 
```c#
using System.Globalization;

namespace BirthDayCalculator
{// how to use parsing and .Parse and .TryPase 
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();
            var userDateOfBirth = AskForDateOfBirth();
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy." + "I,m really good at guessing the" + "day of the week you were born on.");
        }
        public static DateTimeOffset AskForDateOfBirth()
        {
            Console.WriteLine($"Can i start by asking you " +
                $"what your date of birth is ? {CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns} ");
            var userText = Console.ReadLine();
            //var parsedDate = DateTimeOffset.MinValue;
            //var succeeded = DateTimeOffset.TryParse(userText, out parsedDate); 
            // The upper lines are fine line but to write the code in better and cleaner way you can just put the expression rightway in argument.

            if (DateTimeOffset.TryParse(userText, out var parsedDate)) // adding the expression in argument right way.
                return parsedDate;
            else
                Console.WriteLine("You did not enter a vaild date");

            return AskForDateOfBirth();

        }
    }
}
```
## While loop
```c#
            // example how to run WhileLoop
            // var myVariable = 0;
            // while (myVariable < 10)
            // {
            //     Console.WriteLine($"The value is {myVariable}");
            //     myVariable++;
            // }

            // while (myVariable < 10)
            // {
            //     myVariable++;
            //     Console.WriteLine($"The value is {myVariable}");
            // }

            // while (myVariable++ < 10)
            // {
            //     Console.WriteLine($"The value is {myVariable}");
            // }
```
`While In a argument`
```c#
using System.Globalization;

namespace BirthDayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();
            var userDateOfBirth = AskForDateOfBirth();
        }
        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy." + "I,m really good at guessing the" + "day of the week you were born on.");
        }
        public static DateTimeOffset AskForDateOfBirth()
        {
            var dateOfBirth = DateTimeOffset.MaxValue;
            while (dateOfBirth > DateTimeOffset.UtcNow)
            {
                Console.WriteLine($"Can i start by asking you " +
                    $"what your date of birth is ? {CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns} ");
                var userText = Console.ReadLine();
                if (DateTimeOffset.TryParse(userText, out var parsedDate))
                {
                    dateOfBirth = parsedDate;
                }
                else

                    Console.WriteLine("You did not enter a vaild date");
            }
            return dateOfBirth;
        }
    }
}
```

```c#
using System.Globalization;

namespace BirthDayCalculator
{
    internal class Program
    {

        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
        static void Main(string[] args)
        {
            // Introduce our Savvy robot
            IntroduceSavvy();

            // Ask the user for their date of birth
            var userDateOfBirth = AskForDateOfBirth();


        }
        /// <summary>
        /// Introduce Savvy the robot to our user
        /// </summary>
        public static void IntroduceSavvy()
        {
            // Output message to user
            Console.WriteLine("Hi, I'm Savvy." + "I,m really good at guessing the" + "day of the week you were born on.");
        }

        /// <summary>
        /// Ask the user for their date of birth, until it is given in a correct format
        /// </summary>
        /// <remarks>This call will not return until a valid date is entered or the application is terminated.</remarks>
        /// <returns>The date of birth the user entered</returns>
        public static DateTimeOffset AskForDateOfBirth()
        {
            // Create out of range initial value
            var dateOfBirth = DateTimeOffset.MaxValue;

            // Until the date of birth is greater than today...
            while (dateOfBirth > DateTimeOffset.UtcNow)
            {
                // Tell the user  to enter their date of birth
                Console.WriteLine($"Can i start by asking you " +
                    $"what your date of birth is ? {CultureInfo.CurrentCulture.DateTimeFormat.SetAllDateTimePatterns} ");

                // Read their response
                var userText = Console.ReadLine();

                // if the user entered  a vaild date...
                if (DateTimeOffset.TryParse(userText, out var parsedDate))
                {
                    // Set the checked date to users given date
                    dateOfBirth = parsedDate;
                }
                // Otherwise....
                else
                    // Inform user they entered invalid date
                    Console.WriteLine("You did not enter a vaild date");
            }
            // Return the result
            return dateOfBirth;

        }
    }
}

```

```c#

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

```
## End course