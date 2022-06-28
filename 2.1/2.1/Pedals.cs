using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Pedals //realization piano's pedals
    {
        private string oriention;
        public string Oriention { 
            get {
                return oriention; 
            } 
            set {
                oriention = value;
            }
        }
        public Pedals(string oriention)
        {
            this.oriention = oriention;
        }
    }
}
