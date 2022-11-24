using System;
using System.Text;

namespace FluentValidation_examples.ListValidators
{
    class ListValidators
    {
        public ListValidators()
        {
            var person = new Person();

            person.AddressLines.Add("test");
            person.AddressLines.Add("");
            person.AddressLines.Add(null);

            person.Orders.Add(new Order { Total = 1.1 });
            person.Orders.Add(new Order { Total = -1.1 });
            person.Orders.Add(new Order { Total = 0 });
            person.Orders.Add(new Order());

            var result = new PersonValidator().Validate(person);
        }
    }
}
