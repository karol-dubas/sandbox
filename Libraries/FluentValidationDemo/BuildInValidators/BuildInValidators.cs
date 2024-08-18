using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationDemo.BuildInValidators
{
    partial class BuildInValidators
    {
        public BuildInValidators()
        {
            var customer = new Customer
            {
                Id = 2,
                Forename = "Karol",
                Password = "123",
                PasswordConfirmation = "123",
                Discount = 0.2M,
                Address = "aaaaa",
                Email = "x@x.com",
                Gender = "male",
            };

            var results = new CustomerValidator().Validate(customer).Errors;
        }
    }
}
