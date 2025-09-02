//create student class extending Person class
namespace Model
{
public class Student : Person
{
   public string rollNumber { get; set; }

   public Student(string firstName, string lastName, int age, string rollNum): base(firstName, lastName,age) {
      this.rollNumber = rollNum;
   }

   public void IntroduceStudent() {
      Console.WriteLine($"I am a student, My name is {FirstName}, My Roll number is {rollNumber}");
   }
}
}
