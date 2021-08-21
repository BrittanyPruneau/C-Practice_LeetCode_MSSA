using System;

namespace PP6_Udemy_class_constuctor_method
{
    class TestMonth

        // went over this with Paul. 
        // whenever you create a new instance of a class, that object will contain all of the properties the class contains 
        // in which YOU created. 
        // In the class you created Month. You created two objects below: 
        // January  and February both contain the fields 
    {
        static void Main(string[] args)
        {                                           // HERE IN THE CLASS TestMonth... 
            Console.WriteLine("Please enter the month number: ");   // We will accept an integer from the user. 
            int monthNumber = Convert.ToInt32(Console.ReadLine()); // monthNumber will be passed into the class called Month below, 
            // NOW WE CAN SEND monthNumber to the month OBJECT!     // which we instantiated with an object below as well. 

            Month january = new Month(monthNumber); // passing the monthNumber into the CONSTRUCTOR we created called Month, with thE class we created Month. 
            january.name = "January";
            january.number = 1;
            january.numberOfDays = 31;   // 
            Month february = new Month(2);
            february.name = "february"; 


           // Console.WriteLine(month);  // Here we write the class and everything in it. 


        }
    }
}
