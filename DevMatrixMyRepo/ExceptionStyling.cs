using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    //Exception handling is for handling unforeseen errors at runtime
    public class ExceptionStyling
    {
        //This exception is used to check for runtime error and handle it

        public static void MyCalculator()
        {
            try
            {
                double[] figures = { 3.34, 4.0, 6.7, 54 };
                Console.WriteLine(figures[8]); // To get the value
                Console.WriteLine(figures.Length - 1); //To get the last position
            }
            catch (Exception ex)
            {
                Console.WriteLine("Value not found");
            }
            finally
            {

            }
        }

        //This exception is used to throw error message
        public static void ValueCheck()
        {
            if(45 > 20)
            {
                Console.WriteLine("Age matters");
            }
            else
            {
                throw new Exception("Age does not matter");
            }
        }
    }
}
