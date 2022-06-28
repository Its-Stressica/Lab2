using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Button //realization piano's button
    {
        private string color;
        public string Color { get; set; }
        public Button(string color)
        {
            this.color = color;
        }
        public static void Push(Button bt, int i)
        {
            string res = "Color of pressed button: "+ bt.color.ToString() +" number: " + i.ToString();
            Console.WriteLine(res);
        }
    }
}
