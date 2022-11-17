using System;

namespace OOP.Encapsulation
{
	public class Person
	{
		private int _balance;
		private string _name;

		public Gender Gender { get; set; }

		public string Name
		{
			get => _name;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Please provide a valid name");
				}

				_name = value;
			}
		}

		public void Deposit(int amount)
		{
			ValidateAmount(amount);

			_balance += amount;
		}

		public void Withdraw(int amount)
		{
			ValidateAmount(amount);

			if (amount > _balance)
			{
				throw new ArgumentException("Balance must be greater than withdrawal amount");
			}
			
			_balance -= amount;
		}

		private void ValidateAmount(int amount)
		{
			if (amount < 0)
			{
				throw new ArgumentException("Amount value must be greater than 0");
			}
		}
	}
}
