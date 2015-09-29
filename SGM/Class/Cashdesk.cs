using System;
using System.Collections.Generic;
using SGM;

namespace SGM
{
	public class Cashdesk
	{
		private float CashHoldings;
		private List<Customer> CustomerList = new List<Customer> ();

		public Cashdesk (float CashHoldings, List<Customer> CustomerList)
		{
			this.CashHoldings = CashHoldings;
		}

		/// <summary>
		/// Fügt einen Kunden zur Schlange hinzu
		/// </summary>
		/// <returns>Liste aller Kunden an der Kasse</returns>
		/// <param name="customer">Kunde</param>
		public List<Customer> enqueueCustomer (Customer customer)
		{
			CustomerList.Add(customer);
			return this.CustomerList;
		}

		/// <summary>
		/// Gibt die verfügbare Menge an Bargeld zurück
		/// </summary>
		/// <returns>Die verfügbare Menge an Bargeld</returns>
		public float getCashHoldings ()
		{
			return this.CashHoldings;
		}
	}
}
