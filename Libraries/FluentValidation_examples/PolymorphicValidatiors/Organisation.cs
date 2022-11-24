namespace FluentValidation_examples.PolymorphicValidatiors
{
	public class Organisation : IContact
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public Address Headquarters { get; set; }
	}
}