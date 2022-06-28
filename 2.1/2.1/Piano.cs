using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Piano //realization piano 
    {
        private List<Button> button_list;
        private List<Pedals> footboard;
        private int amountWhite, amountBlack;
        public int AmountWhite {
            get {
                return amountWhite;
            }
            set { 
                amountWhite = value; 
            } 
        }
        public int AmountBlack { 
            get { 
                return amountBlack; 
            }
            set {
                amountBlack = value; 
            } 
        }
        public List<Pedals> Footboard {get; set; }
        public List<Button> Button_list { 
            get {
                return button_list; 
            }
            set {
                button_list = value; 
            }
        }

        public Piano(List<Button> button_list, List<Pedals> footboard, int amountWhite, int amountBlack)
        {
            this.button_list = button_list;
            this.footboard = footboard;
            this.amountBlack = amountBlack;
            this.amountWhite = amountWhite;
        }

        public override string ToString()
        {
            string res = "";
            res += "Piano has " + Convert.ToString(button_list.Count()) + " buttons\n";
            res += "White buttons: " + Convert.ToString(amountWhite) + " black buttons : " + Convert.ToString(amountBlack) + "\n";
            res += "Piano has " + this.footboard.Count() + " pedals. Pedals types: ";
            foreach(var ft in footboard)
            {
                res += ft.Oriention + " ";
            }

            return res;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Piano)) return false;
            if (this.footboard.Count != ((Piano)obj).footboard.Count) return false;
            for (int i = 0; i < this.footboard.Count; i++)
            {
                if (this.footboard[i].Oriention != ((Piano)obj).footboard[i].Oriention) return false;
            }
            return (this.amountBlack == ((Piano)obj).amountBlack) && (this.amountWhite == ((Piano)obj).amountWhite);

        }

        public override int GetHashCode()
        {
            return this.footboard.GetHashCode() ^ this.amountWhite.GetHashCode() ^ this.amountBlack.GetHashCode();
        }

        public void Configure()
        {
            Console.WriteLine("Piano is configured!");
        }

        public void Play()
        {
            Console.WriteLine("*you hear piano music*");
        }
    }
}
