using System;
using System.Collections.Generic;

namespace SGM
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List <Product> ProductList = initProduct ();
			Controller control = new Controller (ProductList);
			control.MainMenu ();
		}

		public static List<Product> initProduct(){

			List <Product> ProductList = new List <Product>() ;

			ProductList.Add (new Product ("Hamburger", 3, 100));
			ProductList.Add (new Product ("Cheeseburger", 4, 75));
			ProductList.Add (new Product ("Whopper", 5, 50));
			ProductList.Add (new Product ("Doppel Whopper", 6, 50));
			ProductList.Add (new Product ("Pommes", 2, 150));
			ProductList.Add (new Product ("Nuggets", 3, 100));
			ProductList.Add (new Product ("Cola", 1, 200));
			ProductList.Add (new Product ("Sprite", 1, 200));
			ProductList.Add (new Product ("Fanta", 1, 200));
			ProductList.Add (new Product ("Pepsi", 1, 200));
			ProductList.Add (new Product ("Menu 1: Hamburger + Pommes + Cola", 5, 100));
			ProductList.Add (new Product ("Menu 2: Cheeseburger + Pommes + Cola", 6, 75));
			ProductList.Add (new Product ("Menu 3: Whopper + Pommes + Cola", 7, 50));

			return ProductList;
		}

	}
}
