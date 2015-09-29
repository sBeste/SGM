using System;

namespace SGM
{
	public class Customer
	{
		public string name;
		protected double budget;
		protected static int customerNumber = 1;



		public Customer ()
		{
			//this.budget = budget;

		}

		/**
         * Kundennamne setzen, falls kein Name gesetzt wird,
         * wird eine Kundenzahl/Id zugeordnet.
         */
		public void setName(string name){
			if (name == "") {
				string number = customerNumber.ToString();
				this.name = number;
				customerNumber ++;
			} else {
				this.name = name;
			}			
		}

		/**
         * Kundennamne wird zurückgegeben
         * bzw. ID
         */
		public string getName(){
			return this.name;
		}

		/**
         * Berechnung neues Budget nach ausgaben
         */
		public void pay(double price){
			double budget = this.budget;
			if (price > budget) {
				throw new CustomerNotEnoughMoneyException();
			} else {
				budget = budget - price;
				this.budget = budget;
			}
		}

		/**
		 * Setzt das Budget des Kunden
		 */
		public void setBudget(double budget){
			this.budget = budget;		
		}

		/**
         * Gibt Budget zurück 
         */
		public double getBudget(){
			return this.budget;
		}

		/**
		 * Gibt Bestllungsliste zurück
		 */

		/**
		public OrderList<Order> getOrderList(){
			return orderList;
		}
		*/
	}
}

