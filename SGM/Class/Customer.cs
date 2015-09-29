using System;

namespace SGM
{
	public class Customer
	{
		public string name;
		protected double budget;
		protected static int customerNumber;



		/**
		 * Kundenbudget wird gesetzt
         * Kundennamne setzen, falls kein Name gesetzt wird,
         * wird eine Kundenzahl/Id zugeordnet.
         */
		public Customer (double budget, string name = "")
		{
			this.budget = budget;

			if (!name || name == "") {
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
		public void costs(double price){
			double budget = this.budget;
			budget = budget - price;
			this.budget = budget;
		}

		/**
         * Gibt Budget zurück 
         */
		public double getBudget(){
			return this.budget;
		}
	}
}

