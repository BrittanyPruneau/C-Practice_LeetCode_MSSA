using System;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEMY_Class_Instantiation
{
    class Student       // class 
    {
        public Student(string firstName, string lastName, float gpa) // constructor 
        { // instantiates an object with firstName  lastName  gpa
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;

        }

        public Student(int id, string firstName, string lastName, float gpa) // constructor                                                            // instantiates an object with id, firstName.. etc 
        {
            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
        }

        // the following are the properties 
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float GPA { get; set; }
    }
}

