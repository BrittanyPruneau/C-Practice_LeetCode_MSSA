using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEMY_Class_Instantiation
{
    class StudentDetails
    {
        Student st = new Student("Pavol", "Smith", 3.9f); // instantiating the object(constructor)
        // Student is the class of st. 
        public void displayOutput()
        {
            Console.WriteLine("{0}{1}'s GPA is {2:F2}", st.FirstName, st.LastName, st.GPA);
        }
    }
}