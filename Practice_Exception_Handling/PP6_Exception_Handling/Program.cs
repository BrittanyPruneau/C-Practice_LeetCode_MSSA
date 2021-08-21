
using System;

namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result; 

        DivNumbers()
        {
            result = 0;
        }

        public void division(int num1, int num2)  // void method that accepts two integers. 
        {
            try             //try is telling us to check out if this works. 
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)  // where is this exception? In the framework/class/namespace? 
            {
                Console.WriteLine("Exception caught: {0}", e); // looks like e is error (that triggered the exception)
            }
            finally
            {
                Console.WriteLine("Result: {0}", result); // if the exception is handled by the catch. 
                //Finally makes sure that something runs. 
                // That something is making sure that result is output. 
            }
        }

        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers(); // DivNumbers is a class in the error handling class. 
            d.division(25, 0); // looks like d is the class and division is a method that acccepts two integers. 
            Console.ReadKey();  // obtains the next character or function key pressed by the user. ...
        }
    }
}
