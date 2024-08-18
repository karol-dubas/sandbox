using System.Collections.Generic;

namespace FluentValidationDemo.ExtensionValidators
{
	partial class ExtensionValidators
	{
		public class Person
		{
			public IList<Pet> Pets { get; set; } = new List<Pet>();
		}
	}
}
