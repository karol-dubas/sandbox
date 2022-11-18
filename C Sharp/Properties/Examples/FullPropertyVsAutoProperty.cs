using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class FullPropertyVsAutoProperty
    {
        public FullPropertyVsAutoProperty()
        {
            var dummy = new FullProperty();
            dummy.Name = "test";
            string field = dummy.Name;


            var dummy2 = new AutoProperty();
            dummy2.Name = "test";
            string field2 = dummy2.Name;
        }
    }

    public class FullProperty
    {
        // Instead of writing property like this:
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }

    public class AutoProperty
    {
        // We can write it like this as there is no additional logic involved in getter and setter:
        public string Name { get; set; }
        
        // Auto property działa tak samo jak zwykłe, tylko mniej pisania.

        // What compiler produces of automatic property:

        /*
        private string <Name>k__BackingField;

        public string Name
        {
            get { return <Name>k__BackingField; }
            set { <Name>k__BackingField = value; }
        }
        */
    }

    public class PropertyLogic
    {
        // When I want to actually implement some getter/setter logic,
        // I have to use the private/public pair anyway.

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                    _age = value;
            }
        }

        // Nie zrobię tego poprzez autoproperty, bo w nim nie można implementować logiki.

        // If you want to do stuff in getters or setters (autoprop),
        // there's no problem to convert them to normal properties later on.
    }
}
