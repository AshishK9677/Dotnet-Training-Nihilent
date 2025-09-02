//create Person Class
namespace Model
{
    public class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //method

        public Person(string firstName, string lastName, int age) {
         FirstName = firstName;
         LastName = lastName;
         Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I am {Age} years old.");
        }
    }
}