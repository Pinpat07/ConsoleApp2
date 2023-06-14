using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfStudent = 1;
            int[] midScore, finalScore, Scoresum;
            string[] Name;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityOfStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            Name = new string[quantityOfStudent];
            midScore = new int[quantityOfStudent];
            finalScore = new int[quantityOfStudent];
            Scoresum = new int[quantityOfStudent];
            
            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iterator = 0; iterator < quantityOfStudent; iterator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({iterator + 1} of {quantityOfStudent}) name : ");
                Name[iterator] = Console.ReadLine();

                Console.Write($"Please key {Name[iterator]}'s middle score : ");
                midScore[iterator] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {Name[iterator]}'s final score : ");
                finalScore[iterator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                Scoresum[iterator] = midScore[iterator] + finalScore[iterator];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int _itas = 0;

            do
            {
                float Scoregrades = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (Scoresum[_itas] <= 49) Scoregrades = 0f;
                else if (Scoresum[_itas] <= 54) Scoregrades = 1f;
                else if (Scoresum[_itas] <= 59) Scoregrades = 1.5f;
                else if (Scoresum[_itas] <= 64) Scoregrades = 2f;
                else if (Scoresum[_itas] <= 69) Scoregrades = 2.5f;
                else if (Scoresum[_itas] <= 74) Scoregrades = 3f;
                else if (Scoresum[_itas] <= 79) Scoregrades = 3.5f;
                else if (Scoresum[_itas] >= 80) Scoregrades = 4f;

                #endregion

                #region Writing an if..else..if code with curly brackets.

                #endregion

                Console.WriteLine($"{_itas + 1}. {Name[_itas]} have a" +
                                $" total {Scoresum[_itas]} score or {Scoregrades} grades.");
                _itas++;
            } while (_itas < quantityOfStudent);

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}
