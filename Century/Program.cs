using System;

namespace Century
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            CenturyFromYear(year);
        }

        static void CenturyFromYear(int year)
        {
            int century = year % 100 == 0 ? year / 100 : year / 100 + 1;
            Console.WriteLine($"The century is: {century}");
        }
    }
}
