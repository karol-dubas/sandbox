using System;

namespace OpenClose.Module
{
	class Rectangle : IShape
	{
		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public int Width { get; set; }
		public int Height { get; set; }

		public void Render()
		{
			Console.WriteLine("Rendering rectangle");
		}
	}
}