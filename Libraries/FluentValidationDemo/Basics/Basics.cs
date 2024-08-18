using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationDemo.Basics
{
    public partial class Basics
    {
        // IsValid, Errors, exceptions, validation
        public Basics()
        {
            var customer = new Customer
            {
                Surname = "test"
            };
            
            var validator = new CustomerValidator();

            // The Validate method returns a ValidationResult object. This contains two properties:
            // IsValid - a boolean that says whether the validation succeeded.
            // Errors - a collection of ValidationFailure objects containing details about any validation failures.
            var result = validator.Validate(customer);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine(failure);
                }
            }

            string allMessages = result.ToString("~"); // In this case, each message will be separated with a `~`

            try
            {
                // This throws a ValidationException which contains the error messages in the Errors property.
                validator.ValidateAndThrow(customer);
                // or
                validator.Validate(customer, options => options.ThrowOnFailures());
            }
            catch { }
        }
    }
}
