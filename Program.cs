using System;
namespace assessment1Q3B
{

    class Program

    {

        static void Main(string[] args)

        {
            var person1 = new Person("Milan", "Humagain", new DateTime(1996, 07, 12));

            Console.WriteLine(person1.PersonInfo());

            var adduser = false;
            do {
                Console.WriteLine("Do you wany to add another user? (y/n)");
                var willContinue = Console.ReadLine();
                if (willContinue == "y") {

                    adduser = true;

                    AddUser();

                } else {

                    Console.WriteLine("Thanks for using program, please any key to exit the program");
                    adduser = false;
                    Console.ReadKey();

                }
            } 
            while(adduser);
            }
        static void AddUser() {
        Console.WriteLine("Please type in your first name");
        var fn = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Please type in your last name");

        var ln = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is your date of birth? (format: dd/mm/yyyy");

        var dob = Console.ReadLine();
        var date = DateTime.Parse(dob);

        Console.WriteLine();
        var person1 = new Person(fn, ln, date);

        Console.WriteLine();
        Console.WriteLine(person1.PersonInfo());
        Console.WriteLine();

        }

    }

}
