namespace FluentValidationDemo.PolymorphicValidatiors
{
	public class ContactRequest
	{
		public IContact Contact { get; set; }

		public string MessageToSend { get; set; }
	}
}