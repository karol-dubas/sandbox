using System;

namespace Interface_and_abstract_class.UseCase
{
	public class Image : File, IHasOwner, IHasThumbnail
	{
		public Image(string name, byte[] source) : base(name)
		{
			Source = source;
		}

		public override string Type => "jpg";

		public byte[] Source { get; set; }
		public string Owner { get; set; }

		public byte[] GetThumbnail()
		{
			Console.WriteLine("Resizing...");
			return Source;
		}
	}
}