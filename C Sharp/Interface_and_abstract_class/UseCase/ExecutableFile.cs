using System;

namespace Interface_and_abstract_class.UseCase
{
	public class ExecutableFile : File
	{
		public ExecutableFile(string name) : base(name) { }

		public override string Type => "exe";

		public override void Open()
		{
			Console.WriteLine("To open this file you must have admin permissions");
			const bool runAsAdmin = true;

			if (!runAsAdmin)
			{
				Console.WriteLine("Access denied");
				return;
			}

			base.Open();
		}
	}
}