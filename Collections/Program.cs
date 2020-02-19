using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();

            do
            {
                Console.WriteLine("Enter an exam grade.");
                double examGrade = Convert.ToDouble(Console.ReadKey());
                examGrades.Add(examGrade);

                Console.WriteLine("Do you want to enter another exam grade? Yes or no.");
                String answer = Console.ReadLine();

            }
            while (answer == "yes");


    }
}
