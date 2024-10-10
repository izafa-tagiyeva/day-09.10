using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//1.Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.
            int[] numbers = { 900, 678, 234, 1, 5, 7, };
            int required_number = Min(numbers);
            Console.WriteLine(required_number);
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

    }
}
