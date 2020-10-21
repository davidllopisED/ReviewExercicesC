using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("John");
            names.Add("Mary");
            names.Add("Sue");
            names.Add("Greg");
            names.Add("Yolanda");
            names.Add("Jose");
            names.Add("Bill");
            names.Add("Gates");
            foreach (string name in names)
            {
                Console.WriteLine("Hello Ms/Sir " + name);
            }

            Console.WriteLine("");
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
            Console.WriteLine("");

            List<PersonModel> namesSurnames = new List<PersonModel>();
            namesSurnames.Add(new PersonModel("Tim", "Corey"));
            namesSurnames.Add(new PersonModel("Bill", "McOy"));
            namesSurnames.Add(new PersonModel("Mary", "Jones"));
            namesSurnames.Add(new PersonModel("Steve", "Works"));
            namesSurnames.Add(new PersonModel("Sue", "Smith"));
            foreach (PersonModel person in namesSurnames)
            {
                Console.WriteLine("Hello Ms/Sir " + person.FirstName + " " + person.LastName);
            }
            Console.ReadKey();
        }
    }
}
