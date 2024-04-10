using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            MulTable mulTable = new MulTable();
            mulTable.PrintTable();
        }
    }

    public class MulTable
    {
        public void PrintTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}