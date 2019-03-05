using System;
using System.Linq;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please, enter a number, preferably with more than one digit.");
            int number = Convert.ToInt32(Console.ReadLine());

            DescendingOrderTransformation(number);
        }
        
        static void DescendingOrderTransformation(int number)
        {
            number = int.Parse(string.Concat(number.ToString()
                .OrderByDescending(num => num)));
                
            Console.WriteLine($"This is your number transformed: {number}");
        }
    }
}
