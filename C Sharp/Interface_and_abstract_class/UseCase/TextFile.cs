namespace Interface_and_abstract_class.UseCase
{
	public class TextFile : File, IHasOwner
	{
		public TextFile(string name) : base(name) { }

		public override string Type => "txt";
		public string Owner { get; set; }
	}
}