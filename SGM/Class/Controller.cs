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


			output.OutputText ("Enter Customer's First Name:");
			buffer = input.InputText ();
			customer.setFirstName (buffer);
			buffer = customer.getFirstName ();
			output.OutputText ("First Name:	" + buffer);

			output.OutputText ("Enter Customer's Last Name:");
			customer.setLastName (input.InputText ());
			buffer = customer.getLastName ();
			output.OutputText ("Last Name:	" + buffer);

			buffer = customer.getFirstName () + " " + customer.getLastName ();
			output.OutputText ("Customer's Full Name:" + buffer);

			output.OutputText ("Enter Customer's Age:");
			customer.setAge (input.InputNumber ());
			output.OutputText (string.Format ("Customer's Age:\t{0}", customer.getAge ()));

			output.OutputText ("Enter Customer's Money:");
			customer.setMoney (input.InputNumber ());
			output.OutputText (string.Format ("Customer's Money:\t{0}", customer.getMoney ()));

			return customer;

		}

		public void ShowAllCustomers ()
		{

			for (int i = 0; i<CustomerList.Count; i++) {

				Customer customer = CustomerList [i];
				output.OutputText (string.Format ("Customer's ID:\t\t{0}\nCustomer's First Name:\t{1}\nCustomer's Last Name:\t{2}\nCustomer's Age:\t\t{3}\nCustomer's Money:\t{4}\n", i, customer.getFirstName (), customer.getLastName (), customer.getAge (), customer.getMoney ()));
			}

		}

		public void ShowCustomer (int id)
		{
			Customer customer = CustomerList [id];
			output.OutputText (string.Format ("Customer's ID:\t\t{0}\nCustomer's First Name:\t{1}\nCustomer's Last Name:\t{2}\nCustomer's Age:\t\t{3}\nCustomer's Money:\t{4}\n", id, customer.getFirstName (), customer.getLastName (), customer.getAge (), customer.getMoney ()));
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

