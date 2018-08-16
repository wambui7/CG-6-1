using System;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your first name!");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name!");
            string lastname = Console.ReadLine();

            string fullnames = Combine(firstname, lastname);

            Console.WriteLine(fullnames);

        }
        private static string Combine(string firstname, string lastname)
        {
            StringBuilder fullnames = new StringBuilder();

            fullnames.Append(firstname);
            fullnames.Append(lastname);

            Console.WriteLine("fullnames");
            Console.ReadLine();
        }
    }
}
