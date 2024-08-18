using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationDemo.WhenOtherwiseValidators
{
    class WhenOtherwiseValidators
    {
        public WhenOtherwiseValidators()
        {
            var customer = new Customer
            {
                IsPreferred = false,
                Discount = 1
            };

            var result = new CustomerValidator().Validate(customer);
        }
    }
}
