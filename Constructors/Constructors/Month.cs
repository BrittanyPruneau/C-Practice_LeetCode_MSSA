using System;
using System.Collections.Generic;
using System.Text;

namespace PP6_Udemy_class_constuctor_method
{
    public class Month // 
    {
       public int number;    // we created FIELDS associated with each Month object. -
       public string name;    
       public int numberOfDays;

        public Month(int monthNumber) // constructor (property being passed in) "notice it doesnt return anything". 

        {                       // WE TAKE monthNumber from TestMonth INTO THE OBJECT/CONSTRUCTOR CALLED Month.
                                //    MonthNumber = monthNumber;  //  NOW MonthNumber is equal to what the user input from TestMonth. 
            number = monthNumber;  // rememeber the field was called number on line 9.
        }
        // public int MonthNumber { get; set; } // this property will hold monthNumber, it is accessable from methods of this constructor/class. 


        public string GetMonthName()   
        {
            string monthName = "";
            switch (number)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "Invalid Input";
                    break;
            }

            return monthName;
        }

        //public int GetMonthDays()
        //{
        //    if (MonthNumber == 1 || MonthNumber == 3 || MonthNumber == 5 || MonthNumber == 7 || MonthNumber == 8 ||
        //        MonthNumber == 10 || MonthNumber == 12)
        //        return 31;
        //    else if (MonthNumber == 4 || MonthNumber == 5 || MonthNumber == 9 || MonthNumber == 11)
        //        return 30;
        //    else if (MonthNumber == 2)
        //        return 28;
        //    else
        //        return 0;
        //}

        public override string ToString()  // IN THIS METHOD WE ARE RETURNING WHATS INSIDE THE TWO METHODS WE CREATED
        {
            return String.Format("Month of {0} has {1} days", GetMonthName(), numberOfDays); // COOOL!! WHEN I TYPE "get" the available methods pop up!
        }
    }
}
