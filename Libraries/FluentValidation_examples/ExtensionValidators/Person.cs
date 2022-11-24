using System.Collections.Generic;

namespace FluentValidation_examples.ExtensionValidators
{
	partial class ExtensionValidators
	{
		public class Person
		{
			public IList<Pet> Pets { get; set; } = new List<Pet>();
		}
	}
}
