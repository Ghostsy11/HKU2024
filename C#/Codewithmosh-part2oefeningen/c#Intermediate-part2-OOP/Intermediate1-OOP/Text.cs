using System;
namespace Intermediate1_OOP
{

    internal partial class Program
    {
        public class Text : PresentationObject // Class can have only one paraent
        {
            public int Fontsize { get; set; }
            public string Fontname { get; set; }

            public void AddHyperLink(string url)
            {
                Console.WriteLine("We add a link: " + url);
            }
        }

    }
}
