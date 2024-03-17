using Amazon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTime_;
using System;
using System.Threading;
using static Intermediate1_OOP.Program.DbConnection;

namespace Intermediate1_OOP
{
    internal partial class Program
    {


        static void Main(string[] args)
        {


            //(Calling Post Class#1)
            //var amountoflikes = 0;
            //var amountofdislikes = 0;
            //var post = new Post();
            //var now = post.DateOfCreating = DateTime.Now;
            //Console.WriteLine("post was posted at {0} ", now);

            //while (true)
            //{
            //    Console.WriteLine("Please enter l or d to like or dislike");
            //    var input = Console.ReadLine();

            //    if (input == string.Empty)
            //    {
            //        break;
            //    }
            //    if (input == "l")
            //    {
            //        amountoflikes++;
            //        post.voteS(amountoflikes);

            //    }
            //    if (input == "d")
            //    {
            //        amountofdislikes++;
            //        post.voteSD(amountofdislikes);
            //    }
            //    Console.WriteLine("the amount of like you have atm: {0} ", amountoflikes);
            //    Console.WriteLine("the amount of like you have atm: {0} ", amountofdislikes);
            //}


            //(Stack exriscies#2)
            //Stack stack = new Stack();
            // First testing.
            //stack.push(1);
            //stack.push(2);
            //stack.push(3);
            //Console.WriteLine();
            //Console.WriteLine(stack.pop());
            //Console.WriteLine(stack.pop());
            //Console.WriteLine(stack.pop());

            // Secound Testig better way. 
            //int number = 0;
            //int number1 = 5;

            //for (int i = number; i <= number1; i++)
            //{
            //    stack.push(i);
            //}

            //for (int i = number; i <= number1; i++)
            //{
            //    Console.WriteLine(stack.pop());

            //    Console.ReadLine();
            //}
            //stack.Clear();
            //Console.WriteLine("Stack is Cleared");



            //(2)
            // Inheritance and Composition
            //var dbmigrtor = new Dbmigrator(new Logger());

            //(Calling using three Classes together and coprating)
            //var logger = new Logger();
            //var dbmigrotr = new Dbmigrator(logger);
            //var installer = new Installer(logger);
            //dbmigrotr.Migrate();
            //installer.Install();

            //(Inhertiance)
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();




            //(Calling Person Class, training on classes)
            //var peson = new Person();
            //peson.SetBirthDate(new DateTime(2000, 8, 1));
            //peson.PersonName("AbdulRahman");
            //Console.WriteLine(peson.Name);
            //Console.WriteLine(peson.GetBirthDate());

            //var person1 = new Person();
            //person1.birthDate = new DateTime(2002, 7, 1);
            //person1.PersonName("Byan");
            //Console.WriteLine(person1.Name);
            //Console.WriteLine(person1.age);

            //var action = new TheTime();
            //action.TimeNow();

        }

    }
}
