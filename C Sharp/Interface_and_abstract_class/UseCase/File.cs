using System;

namespace Interface_and_abstract_class.UseCase
{
	public abstract class File
	{
		private string _name;

		protected File(string name)
		{
			Name = name;
			
			Counter++;
		}

		public string Name
		{
			get => _name;
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("The name cannot be empty");

				_name = value;
			}
		}

		public static int Counter;

		public abstract string Type { get; }

		public virtual void Open()
		{
			Console.WriteLine("Opening file...");
		}
	}
}