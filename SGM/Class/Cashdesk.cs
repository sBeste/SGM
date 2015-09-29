using System;
using System.Collections.Generic;
using SGM;

namespace SGM
{
	public class Cashdesk
	{
		/// <summary>
		/// Bargeldbestand der Kasse
		/// </summary>
		private float CashHoldings;

		/// <summary>
		/// Schlange der Kunden an der Kasse
		/// </summary>
		private Queue<Customer> CustomerQueue = new Queue<Customer> ();

		public Cashdesk (float CashHoldings)
		{
			this.CashHoldings = CashHoldings;
		}

		/// <summary>
		/// Fügt einen Kunden zur Schlange hinzu
		/// </summary>
		/// <returns>Liste aller Kunden an der Kasse</returns>
		/// <param name="customer">Kunde</param>
		public Queue<Customer> enqueueCustomer (Customer customer)
		{
			CustomerQueue.Enqueue(customer);
			return this.CustomerQueue;
		}

		/// <summary>
		/// Gibt die verfügbare Menge an Bargeld zurück
		/// </summary>
		/// <returns>Die verfügbare Menge an Bargeld</returns>
		public float getCashHoldings ()
		{
			return this.CashHoldings;
		}

		/// <summary>
		/// Bearbeitet den nächsten Kunden
		/// </summary>
		/// <returns>The customer.</returns>
		public Customer nextCustomer()
		{
			Customer customer = CustomerQueue.Dequeue ();

			List<Order> orderList = customer.getOrderList ();

			return customer;
		}

		public Customer finishCustomer ()
		{
			return customer;
		}

	}
}
