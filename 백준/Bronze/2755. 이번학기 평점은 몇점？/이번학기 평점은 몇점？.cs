using System;

namespace prob2755
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = 0, Grade_x_Mark = 0;
            int subjects = int.Parse(Console.ReadLine());
            for (int i = 0; i < subjects; i++)
            {
                string[] subjectScore = Console.ReadLine().Split();
                double mark = double.Parse(subjectScore[1]);
                grade += mark;
                switch (subjectScore[2])
                {
                    case "A+":
                        Grade_x_Mark += mark * 4.3;
                        break;
                    case "A0":
                        Grade_x_Mark += mark * 4.0;
                        break;
                    case "A-":
                        Grade_x_Mark += mark * 3.7;
                        break;
                    case "B+":
                        Grade_x_Mark += mark * 3.3;
                        break;
                    case "B0":
                        Grade_x_Mark += mark * 3.0;
                        break;
                    case "B-":
                        Grade_x_Mark += mark * 2.7;
                        break;
                    case "C+":
                        Grade_x_Mark += mark * 2.3;
                        break;
                    case "C0":
                        Grade_x_Mark += mark * 2.0;
                        break;
                    case "C-":
                        Grade_x_Mark += mark * 1.7;
                        break;
                    case "D+":
                        Grade_x_Mark += mark * 1.3;
                        break;
                    case "D0":
                        Grade_x_Mark += mark * 1.0;
                        break;
                    case "D-":
                        Grade_x_Mark += mark * 0.7;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("{0:0.00}", Math.Round(Grade_x_Mark / grade, 2));
        }
    }
}
