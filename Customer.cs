using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace StoreApplication
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Customer
	{
		//Fields
        public string ID { get; }

		public string Name { get; set; }

		public decimal Balance 
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

		
		//Constructor
		public Customer(string name)
		{
		
			this.Name = name;
			this.ID = customersID.ToString();
			customersID++;
		}

		//Methods
		public void AddItem(decimal price, string itemName, string itemID, DateTime date)
        {
			if (price <= 0 )
            {
				throw new ArgumentOutOfRangeException(nameof(price), "Price of an Item must not be negative!");
            }
			var buy = new Transaction(price, itemName, itemID, date);
			allTransactions.Add(buy);
        }

		public void RemoveItem(decimal price, string itemName, string itemID, DateTime date)
        {
			if (price <= 0)
            {
				throw new ArgumentOutOfRangeException(nameof(price), "Cannot Remove Item with an empty Cart!");
            }
			if (Balance - price < 0)
            {
				Console.WriteLine("Cart is Empty!");
            }
			var remove = new Transaction(-price, itemName, itemID, date);
			allTransactions.Add(remove);
        }
	}
}
