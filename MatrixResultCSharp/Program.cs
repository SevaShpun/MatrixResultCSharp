using System;

namespace MatrixResultCSharp
{
    class Program
    {
        // Создаем переменные
        static int[] cell = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int r = 0;
        static void TemplateText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t=================");
            Console.WriteLine("\t\t\t\t   Template 3x3");
            Console.WriteLine("\t\t\t\t=================");
            Console.WriteLine("\t\t\t\t    1 | 2 | 3");
            Console.WriteLine("\t\t\t\t    4 | 5 | 6");
            Console.WriteLine("\t\t\t\t    7 | 8 | 9");
            Console.WriteLine("\t\t\t\t=================");
        }

        static void MatrixFillingText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\tFill in the cells");
            Console.WriteLine("\t\t\t\t=================");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t\t{0}\t{1}\t{2}", cell[0], cell[1], cell[2]);
            Console.WriteLine("\t\t\t\t{0}\t{1}\t{2}", cell[3], cell[4], cell[5]);
            Console.WriteLine("\t\t\t\t{0}\t{1}\t{2}", cell[6], cell[7], cell[8]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t=================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        static void Main(string[] args)
        {
            Console.Title = "Solving a Matrix by a Simple Method (C#)";
            int Num;
            int i = 0;
            while(cell.Length > i )
            {
                TemplateText();
                MatrixFillingText();

                Console.Write("cell {0}> ", i + 1);
                string[] input = Console.ReadLine().Split(' ');
                bool isNum = int.TryParse(input[0], out Num);
                Console.Clear();

                if (isNum)
                {
                    cell[i] = Num;
                    i++;
                }
            }
            TemplateText();
            MatrixFillingText();
            r = cell[0] * (cell[4] * cell[8] - cell[5] * cell[7]) - cell[1] * (cell[3] * cell[8] - cell[5] * cell[6]) + cell[2] * (cell[3] * cell[7] - cell[4] * cell[6]);
            if (r < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tResult: {0}", r);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\tResult: {0}", r);
            }
            Console.Read();
        }
    }
}
