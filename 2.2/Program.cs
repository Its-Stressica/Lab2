using System;
using System.Collections.Generic;

namespace _2_2
{
    class Program
    {
        private static List<Stone> necklace = new List<Stone>();

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of types of stones: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Stone.Create_Necklace();
            }
            Stone.Our_Necklace();
            Stone.Weight_Price();
            Stone.Sort();
            Stone.Find();
        }
    }
}
