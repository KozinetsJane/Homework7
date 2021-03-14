using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> mylist = test(new List<int>(new int[] { 25, 36, 35, 51 }));
            //foreach (var i in mylist)
            //{
            //Console.Write(i.ToString() + " ");
            //}
            //}
            //public static List<int> test(List<int> nums)
            //{
            //IEnumerable<int> digits = nums.Select(x => x % 10);
            //return digits.ToList();
            //}

            List<int> list = new List<int>() { 5, 2, 6, 1, 2, 3, 1, 5, 7, 2, 2 };

            foreach (var number in list.GroupBy(x => x))
            {
                Console.WriteLine("num : " + number.Key + "  count : " + number.Count());
            }

        }
    }
}

