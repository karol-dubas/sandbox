using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationDemo.ReUsingValidators
{
    class ReUsingValidators
    {
        public ReUsingValidators()
        {
            var customer1 = new Customer
            {
                Name = "Karol",
                // If the child property is null, then the child validator will not be executed.
                // Czyli, jeśli adres będzie null - to nie waliduje 'Address'
                Address = null
            };

            var customer2 = new Customer
            {
                Name = "Karol",
                Address = new Address
                {
                    Country = "Poland",
                    City = null
                }
            };

            var validator = new CustomerValidator();
            var result = validator.Validate(customer1);
            var result2 = validator.Validate(customer2);
        }
    }
}
