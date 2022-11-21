using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressions.Events
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    var args = new NameChangedEventArgs(_name, value);
                    _name = value;

                    // ?.Invoke() robi null check, jeśli są subscriberzy (podpięte metody) to uruchamia
                    NameChanged?.Invoke(this, args);

                    // W tym przypadku, jeśli nie ma to będzie null ref ex
                    //NameChanged(this, args);
                }
            }
        }

        // Wersja z własnym delegatem, poniżej EventHandler<> z .NET, działa tak samo, tylko
        // nie trzeba tworzyć własnego delegatu, ma wbudowany sender i podajemy tylko event args
        //public event NameChanged NameChanged;

        // Tutaj podpinane są metody w innej części kodu, która używa obiektu tej klasy
        // zostaną one wywołane przy użyciu np. NameChanged(this, args) jak wyżej w setterze
        public event EventHandler<NameChangedEventArgs> NameChanged;

        // Słowo kluczowe event jest opcjonalne, kiedy go użyjemy nie możemy przypisać
        // tu null, a jedynie używać operatora -=
        //public NameChanged NameChanged;
        //public EventHandler<NameChangedEventArgs> NameChanged;
    }
}
