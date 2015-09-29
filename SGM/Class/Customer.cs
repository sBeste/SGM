using System;

namespace SGM
{
	public class Customer
	{
		private string firstName;
		private string lastName;
		private int age;
		private int money;

		public Customer ()
		{
		}

		public void setFirstName(string text)
		{
			this.firstName = text;
		}

		public string getFirstName()
		{
			return this.firstName;
		}

		public void setLastName(string text)
		{
			this.lastName = text;
		}

		public string getLastName()
		{
			return this.lastName;
		}

		public void setAge(int number){

			this.age = number;
		}

		public int getAge(){

			return this.age;
		}

		public void setMoney(int number){

			this.money = number;
		}

		public int getMoney(){

			return this.money;
		}
	}
}

