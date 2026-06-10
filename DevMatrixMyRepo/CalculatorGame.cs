using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class CalculatorGame
    {
        string StudentName;
        int StudentScore;

        public CalculatorGame(string Sname, int Sscore)
        {
            StudentName = Sname;
            StudentScore = Sscore;
        }

        public void StudentCalcGame()
        {
            Console.WriteLine($"Student name is {StudentName}");
            Console.WriteLine("Student score is {0}", StudentScore);

            if (StudentScore >= 70 && StudentScore <= 100) 
            {
                Console.WriteLine("The student score is " + StudentScore + " and it's A");
            }else if(StudentScore >= 60 && StudentScore <= 69)
            {
                Console.WriteLine($"The student score is {StudentScore} and it's B");
            }
            else if (StudentScore >= 50 && StudentScore <= 59)
            {
                Console.WriteLine($"The student score is {StudentScore} and it's C");
            }
            else if (StudentScore >= 45 && StudentScore <= 49)
            {
                Console.WriteLine($"The student score is {StudentScore} and it's D");
            }
            else if (StudentScore >= 40 && StudentScore <= 45)
            {
                Console.WriteLine($"The student score is {StudentScore} and it's E");
            }
            else
            {
                Console.WriteLine($"The student score is {StudentScore} and it's F");
            }
        }
    }
}
