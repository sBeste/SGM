using System;
using System.Collections.Generic;
using SGM;

namespace SGM
{
	public class Cashdesk
	{
		private float CashHoldings;
		private Queue<Customer> CustomerQueue = new Queue<Customer> ();
		private Dictionary<Customer, Order> orderQueue = new Dictionary<Customer, Order> ();

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
		///
		/// </summary>
		/// <returns>The order.</returns>
		public Dictionary<Customer, Order> nextOrder ()
		{
			//Daten holen
			Customer customer = CustomerQueue.Dequeue();
			OrderList<Order> orderList = customer.getOrderList();

			//Daten

		}

		/// <summary>
		/// Vollendet die Bestellung. Der Kunde muss nun Zahlen
		/// </summary>
		/// <returns>Die Bestellung</returns>
		public Order completeOrder (Order order, Customer customer)
		{
			customer.pay (order.getPrice ());

			return order;
		}
	}
}
