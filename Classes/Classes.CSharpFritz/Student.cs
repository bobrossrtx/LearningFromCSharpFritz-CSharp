using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.CSharpFritz
{
  internal class Student
  {
    public Student(string firstName, string lastName, int age)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Age = age;

      if (this.Age <= 18)
      {
        // Every student is enrolled by default if age 18 or less
        this.IsEnrolled = true;
      } else
      {
        this.IsEnrolled = false;
      }
    }

    // Publicly accessable properties that define the FirstName, LastName
    // and age of our Student.
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsEnrolled { get; private set; }
     
  }
}
