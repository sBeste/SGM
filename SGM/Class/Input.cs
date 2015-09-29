using System;

namespace SGM
{
	public class Input
	{
		private int number = 0;
		private string text = null;

		public Input ()
		{
		}

		public int InputNumber(){

			do {

				Console.WriteLine("Input:\t");
				text = Console.ReadLine ();
				Int32.TryParse (text, out number);

				if(!int.TryParse(text, out number)){
					Console.WriteLine("Input Wrong\tTry Again!\n");
				}

			} while(!int.TryParse(text, out number));

			return number;
		}

		public string InputText(){

			this.text = Console.ReadLine ();

			return this.text;

		}
	}
}

