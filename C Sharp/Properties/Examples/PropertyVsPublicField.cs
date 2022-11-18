using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Properties
{
    public class PropertyVsPublicField
    {
        public PropertyVsPublicField()
        {
            var test = new PublicField();
            test.Name = "dummy";

            var test2 = new Property();
            test2.Name = "dummy";
        }
    }

    class PublicField
    {
        public string Name;
    }

    class Property
    {
        // You could use fields, and if you wanted to add logic
        // to them later you'd convert them to properties. But this might
        // present problems with any use of reflection (and possibly elsewhere?).

        // As you'll know, if you use a public field and in the future you need
        // to add some logic when getting or setting the value, you can't
        // (unless you break the interface that you're providing to others).
        // You can't, because the value isn't encapsulated.

        // With an automatic property, instead, you can add more logic whenever
        // you want, without the need to change the interface that your class provides.
        // Just replace the automatic property with a standard one.

        // Czyli jak wystawiam pole na zewnątrz to za pomocą property.
        public string Name { get; set; }

        // Also the properties allow you to set different access levels for
        // the getter and setter which you can't do with a field.

        // Properties, even auto-properties, can be virtual.
        public virtual int Age { get; private set; }

        // Pole, które ma być tylko dla klasy ma być prywatne,
        // a jak chcę by było public, poza klasą, to tworzę property.

        // https://stackoverflow.com/a/653799/14192182
    }
}
