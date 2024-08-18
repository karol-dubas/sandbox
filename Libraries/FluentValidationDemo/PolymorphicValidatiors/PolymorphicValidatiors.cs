using System.Collections.Generic;
using System.Text;

namespace FluentValidationDemo.PolymorphicValidatiors
{
    class PolymorphicValidatiors
    {
        public PolymorphicValidatiors()
        {
            var contactRequest1 = new ContactRequest
            {
                Contact = new Person(),
                MessageToSend = "test message 2"
            };

            var contactRequest2 = new ContactRequest
            {
                Contact = new Organisation
                {
                    Headquarters = new Address()
                },
                MessageToSend = "test message 2"
            };

            var validator = new ContactRequestValidator();
            var result1 = validator.Validate(contactRequest1);
            var result2 = validator.Validate(contactRequest2);
        }
    }
}
