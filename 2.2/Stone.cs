using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    public class Stone
    {
		public string name;			//ім'я каменю
		public double weight;		//вага каменю
		public int price;			//ціна
		public string transparency;	//параметр прозорості
		public int number;			//цінність


		public Stone(string name, int weight, int price, string transperency, int numb)
		{
			this.name = name;
			this.weight = weight;
			this.price = price;
			this.transparency = transperency;
			this.number = numb;

		}
		public static List<Stone> necklace =new List<Stone>();

		public static void Create_Necklace()
		{
			Console.WriteLine("Choose a type of stone (Diamond/Emerald/Ruby/Sapphire:");
			string name = Console.ReadLine();
			
			if (name == "Diamond")
			{
				Console.WriteLine("Count of stones: ");
				int dia = Convert.ToInt32(Console.ReadLine());
				Diamond diamond = new Diamond("Diamond", 1, 100, "transperent", dia);
				necklace.Add(diamond);
			}
			else if (name == "Ruby")
			{
				Console.WriteLine("Count of stones: ");
				int rub = Convert.ToInt32(Console.ReadLine());
				Ruby ruby = new Ruby("Ruby", 4, 50, "opaque", rub);
				necklace.Add(ruby);
			}
			else if (name == "Emerald")
			{
				Console.WriteLine("Count of stones: ");
				int eme = Convert.ToInt32(Console.ReadLine());
				Emerald emerald = new Emerald("Emerald", 3, 75, "translucent", eme);
				necklace.Add(emerald);
			}
			else if(name== "Sapphire")
            {
				Console.WriteLine("Count of stones: ");
				int sap = Convert.ToInt32(Console.ReadLine());
				Sapphire sapphire = new Sapphire("Sapphire", 3, 200, "opaque", sap);
				necklace.Add(sapphire);
			}				
			else
			{
				Console.WriteLine("ERROR");
			}
		}

		public static void Our_Necklace()
		{
			Console.WriteLine();
			Console.WriteLine("Jewellery:\nTypes of stone\t\t\t\tWeight\t\t\tPrice");
			for (int i = 0; i < necklace.Count; i++)
			{
				Console.WriteLine(necklace[i].name + "\t - \t" + necklace[i].number + " stone(s) \t- \t" + necklace[i].weight + " carats \t- \t" + necklace[i].price + " $");
			}
		}

		public static void Weight_Price()
		{
			Console.WriteLine();
			double summ_weight = 0;
			double summ_price = 0;
			for (int i = 0; i < necklace.Count; i++)
			{
				summ_weight += necklace[i].number * necklace[i].weight;
				summ_price += necklace[i].number * necklace[i].weight * necklace[i].price;
			}
			Console.WriteLine("Total weight: " + summ_weight + " karats");
			Console.WriteLine("Total price: " + summ_price + " $");
		}

		public static void Sort()
		{
			for (int i = necklace.Count - 1; i > -1; i--)
			{
				for (int j = 0; j < i; j++)
				{
					if (necklace[j].price > necklace[j + 1].price)
					{
						(necklace[j], necklace[j + 1]) = (necklace[j + 1], necklace[j]);
					}
				}
			}
			Console.WriteLine("Sorted stones by value: ");
			for (int i = 0; i < necklace.Count; i++)
			{
				Console.WriteLine(necklace[i].name + " " + necklace[i].price + " $");
			}
		}

		public static void Find()
		{
			bool flag = false;
			Console.WriteLine();
			Console.WriteLine("Введiть дiапазон прозоростi: ");
			string diapasone = Console.ReadLine();
			for (int i = 0; i < necklace.Count; i++)
			{
				if (diapasone == necklace[i].transparency)
				{
					Console.WriteLine("Result: " + necklace[i].name);
					flag = true;
				}
			}
			if (flag == false)
			{
				Console.WriteLine("ERROR");
			}

		}

	}
}

