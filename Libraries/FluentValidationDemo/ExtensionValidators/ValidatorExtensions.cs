using System.Collections.Generic;
using FluentValidation;

namespace FluentValidationDemo.ExtensionValidators
{
	public static class ValidatorExtensions
	{
		public static IRuleBuilderOptions<T, IList<TElement>> ListMustContainFewerThan<T, TElement>
			(this IRuleBuilder<T, IList<TElement>> ruleBuilder, int number)
		{
			return ruleBuilder
				.Must(list => list.Count < number)
				.WithMessage($"List must contain less than {number} items");
		}
	}
}