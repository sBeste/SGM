using System;

namespace SGM
{
	public class Product
	{
		string name;
		int price;
		int amount;

		public Product (string s, int i, int j)
		{
			this.name  = s;
			this.price = i;
			this.amount = j;
		}

		public string getName(){

			return this.name;
		}

		public int getPrice(){

			return this.price;
		}

		public int getAmount(){

			return this.amount;
		}
	}
}

