using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piano is building.. Enter the number of white and black kyes.");
            int whiteBut=0, blackBut=0;
            string input = Console.ReadLine();
            string[] nums = input.Split(" ");
            try {
                whiteBut = Convert.ToInt32(nums[0]);
                blackBut = Convert.ToInt32(nums[1]);
            }
            catch{
                Console.WriteLine("ERROR!");
            }
            List<Button> btnlist = new List<Button>();
            for(int i = 0; i < whiteBut; i++)
            {    
                Button tmp = new Button("white");
                btnlist.Add(tmp);
            }
            for (int i = 0; i < blackBut; i++)
            {
                Button tmp = new Button("black");
                btnlist.Add(tmp);
            }
            Console.WriteLine("Enter number and type of pedals: ");
            string inp = Console.ReadLine();
            string[] buff = inp.Split(" ");
            List<Pedals> ftblist = new List<Pedals>();
            try
            {
                int n = Convert.ToInt32(buff[0]);
               
                for(int i = 1; i <= n; i++)
                {
                    Pedals ftb = new Pedals(buff[i]);
                    ftblist.Add(ftb);
                }
                
            }
            catch
            {
                Console.WriteLine("ERROR!");
            }
            Piano piano = new Piano(btnlist, ftblist, whiteBut, blackBut);
            Console.WriteLine("The piano has been created.");

            Console.WriteLine(piano.ToString());
            List<Button> test_1 = new List<Button>();
            for (int i = 0; i < 3; i++)
            {
                Button tmp = new Button("white");
                test_1.Add(tmp);
            }
            for (int i = 0; i < 3; i++)
            {
                Button tmp = new Button("black");
                test_1.Add(tmp);
            }
            List<Pedals> test_2 = new List<Pedals>(); 
            Pedals f = new Pedals("f");

            test_2.Add(f);

            Piano test = new Piano(test_1, test_2, 3, 3);
            Console.WriteLine(test.ToString());

            //Equals method
            Console.WriteLine(Convert.ToString(piano.Equals(test)));
            Console.WriteLine("Method Equals is finish!");
            while (true)
            {
                Console.WriteLine("Enter 1 to tune the piano, 2 to play, 3 to press a key, 4 to exit");
                int t = 0;
                try
                {
                    t = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("ERROR");
                }
                if (t == 1) piano.Configure();
                if (t == 2) piano.Play();
                if (t == 3)
                {
                    var rnd = new Random();
                    int i = rnd.Next(piano.AmountBlack + piano.AmountWhite - 1);
                    Button.Push(piano.Button_list[i], i+1);
                }

                if (t == 4) Process.GetCurrentProcess().Kill();
            }
        }
    }
}
