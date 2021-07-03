using System;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      #region "Old Student object creation"
      //var s = new Student();
      //s.FirstName = "Owen";
      //s.LastName = "Boreham";
      //s.Age = 15;

      //var codex = new Student()
      //{
      //  FirstName = "nfg",
      //  LastName = "Codex",
      //  Age = 20,
      //};

      //if (codex.Age > 18)
      //{
      //  codex.IsEnrolled = false;
      //}
      #endregion

      // Create new students
      var owen = new Student("Owen", "boreham", 14);
      var bob = new Student("Bob", "Ross", 17);

      // Add all the students to a list
      Student[] students = { owen, bob };

      foreach(Student student in students)
      {
        Console.WriteLine($"Name: {student.FirstName} {student.LastName}, \r\nAge: {student.Age}, \r\nEnrolled: {student.IsEnrolled}\r\n");
      }
      
      Console.ReadLine();
    }
  }
}