using System;

namespace Attributes
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public class MethodParameterAttribute : Attribute
	{
		public string Info { get; set; }
	}
}
