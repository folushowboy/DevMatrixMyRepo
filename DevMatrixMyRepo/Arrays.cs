using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Arrays
    {
        public static void ArraysOperation()
        {
            string[] students = { "Mayowa", "Mike", "Sam", "Eze", "Eni"};
            foreach(string name in students)
            {
                Console.WriteLine(name);
            }
            
            int sum = 0;
            int[] numbers = new int[5];
            numbers[0] = 10; 
            numbers[1] = 20; 
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            int total = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];           
            Console.WriteLine(total);
        }
    }
}
