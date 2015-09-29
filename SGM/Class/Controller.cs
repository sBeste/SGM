using System;
using System.Collections.Generic;
using SGM;

namespace SGM
{
	public class Controller
	{
		private List <Customer> CustomerList = new List <Customer> ();
		private List <Product> ProductList = new List <Product> ();
		private Input input = new Input ();
		private Output output = new Output ();
		private int controlValue = 0;
		private bool exit = true;

		public Controller (List <Product> Products)
		{
			this.ProductList = Products;
		}

		public void MainMenu ()
		{

			do {

				output.OutputText ("VERSION 0.1b\n(1) =>\tAdd Customer\n(2) =>\tEdit Customer\n(3) =>\tShow All Customers\n(4) =>\tShow All Products\n(5) =>\tMake an Order\n(0) =>\tExit\n");

				controlValue = input.InputNumber ();

				switch (controlValue) {

				case 1:
					CustomerList.Add (CreateCustomer ());
					break;

				case 2:
					ShowAllCustomers ();
					output.OutputText ("Which Customer do you want to edit?\nCustomer's ID:");
					controlValue = GetCustomerID ();
					ShowCustomer (controlValue);
					CustomerList [controlValue] = CreateCustomer ();

					break;

				case 3:

					ShowAllCustomers ();

					break;

				case 4:

					ShowAllProducts ();
					break;

				case 0:
					output.OutputText ("Exit");
					exit = false;
					break;

				default:
					Console.WriteLine ("Input Wrong\tTry Again!\n");
					break;
				}

			} while(exit);

		}

		public Customer CreateCustomer ()
		{

			string buffer;
			Customer customer = new Customer ();

			output.OutputText ("Enter Customer's Fullname:");
			buffer = input.InputText();
			customer.setName (buffer);
			buffer = customer.getName ();
			output.OutputText ("Customer's Full Name:" + buffer);

			output.OutputText ("Enter Budget:");
			buffer = input.InputText();
			customer.setBudget (double.Parse(buffer));
			buffer = customer.getBudget().ToString();
			output.OutputText (string.Format ("Customer's Money:\t{0}", buffer));

			return customer;
		}

		public void ShowAllCustomers ()
		{

			for (int i = 0; i<CustomerList.Count; i++) {

				Customer customer = CustomerList [i];
				output.OutputText (string.Format ("Customer's ID:\t\t{0}\nCustomer's Name:\t{1}\nCustomer's Budget:\t{2}\n", i, customer.getName (), customer.getBudget()));
			}

		}

		public void ShowCustomer (int id)
		{
			Customer customer = CustomerList [id];
			output.OutputText (string.Format ("Customer's ID:\t\t{0}\nCustomer's Name:\t{1}\nCustomer's Budget:\t{2}\n", id, customer.getName (), customer.getBudget()));
			}

		public void ShowAllProducts ()
		{

			for (int i = 0; i<ProductList.Count; i++) {

				Product product = ProductList [i];
				output.OutputText (string.Format ("Product's ID:\t\t{0}\nProduct's Description:\t{1}\nProduct's Price:\t{2}\nProduct's Amount:\t{3}\n", i, product.getName (), product.getPrice (), product.getAmount ()));
			}

		}

		public int GetCustomerID ()
		{

			int value = -1;

			do {

				value = input.InputNumber ();

				if (value >= CustomerList.Count) {

					output.OutputText ("No Customer found by this ID");
					value = -1;
				}

			} while(value<0);

			return value;
		}
	}
}

