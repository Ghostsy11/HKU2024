namespace Intermediate1_OOP
{

    internal partial class Program
    {
        public class PresentationObject // working with inheritance
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public void Copy()
            {
                System.Console.WriteLine("Object copyed");
            }

            public void Duplicate()
            {
                System.Console.WriteLine("Object Duplicated");
            }
        }
    }
}
