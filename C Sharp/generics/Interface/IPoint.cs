namespace generics
{
	interface IPoint<T>
	{
		public T X { get; set; }
		public T Y { get; set; }
	}
}