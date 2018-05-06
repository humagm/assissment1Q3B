using System;
namespace assessment1Q3B

{

        class Person {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}

        public Person(string firstName, string lastName, DateTime dob) {

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;



            Console.WriteLine("Creating a Person...");

        }

        public string GetFullName() {

        return $"{FirstName} {LastName}";

        }
        public int GetAge() {
        var age = DateTime.Now.Year - DateOfBirth.Year;  
                    

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear) {
                age = age - 1;  
            }  
            return age;  
        }
        public virtual string PersonInfo() {
        return $"FullName: {GetFullName()} \nAge: {GetAge()} years old";

        }

    }

}