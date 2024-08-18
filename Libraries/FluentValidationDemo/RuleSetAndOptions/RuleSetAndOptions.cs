using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidationDemo.RuleSetAndOptions
{
    class RuleSetAndOptions
    {

        public void Run()
        {
            var person = new Person();
            
            var validator = new PersonValidator();
            
            // Bez podania RuleSet nie będzie go walidował
            var result = validator.Validate(person, options => options.IncludeRuleSets(RuleSets.Names));
            var result2 = validator.Validate(person);
        }
    }
}
