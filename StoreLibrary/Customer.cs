using System;
using System.Collections.Generic;
using System.Text;


namespace StoreLibrary
{
	/// <summary>
	/// Here Customer should register first before he/she can do something.
	/// Customer can add and remove item, display items inside the cart and checkout.
	/// </summary>
	public class Customer
	{
		//Fields
		internal string ID { get; }

		internal string Name { get; set; }

		internal decimal Balance
		{
			get
			{
				decimal balance = 0;
				foreach (var item in allTransactions)
				{
					balance += item.Price;
				}
				return balance;
			}

		}
		private static int customersID = 1;

		
		public List<Transaction> allTransactions = new List<Transaction>();
		public List<Items> allItems = new List<Items>();

		//Constructor
		public Customer(string name) 
		{

			this.Name = name;
			this.ID = customersID.ToString();
			customersID++;
			var cusDictionary = new Dictionary<string, int>();
			cusDictionary.Add(name, customersID);
		}

		public void AddItem(string itemID, DateTime date)
		{
			//

		}

		public void RemoveItem(string itemID, DateTime date)
		{
			/*if (itemID == (Id sa product))
			{
				throw new ArgumentOutOfRangeException(nameof(price), "There is no negative Price!");
			}
			if (Balance - price < 0)
			{
				Console.WriteLine("Cart is empty!");
			}
			var remove = new Transaction(itemID);
			allTransactions.Add(remove);*/
		}

		public void DisplayItems()
        {

			//items bought or items inside the cart
			var list = new List<Ite
			

		}

		public void CheckOut()
        {
			//Check the total number of items from directory order with keys and value on it;
			//return total balance, directory of items, store location and date. 
			
        }
	}
}

