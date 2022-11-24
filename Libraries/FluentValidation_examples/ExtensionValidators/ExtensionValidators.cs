using System;
using System.Text;

namespace FluentValidation_examples.ExtensionValidators
{
    partial class ExtensionValidators
    {
        public ExtensionValidators()
        {
            var person = new Person();
            person.Pets.Add(new Pet());
            person.Pets.Add(new Pet());

            var result = new PersonValidator().Validate(person);
        }
    }
}
