using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressions.Events
{
    // Delegat deklarowany jak klasa, deklarujemy co podpięte metody mają zwracać oraz
    // jakie argumenty przyjmować. Zazwyczaj jest to sender i argumenty, jak poniżej
    public delegate void NameChanged(object sender, NameChangedEventArgs e);

    // Nie musi dziedziczyć po EventArgs, w starszych wersjach trzeba,
    // ale dzięki temu mamy dostęp do pola Empty
    public class NameChangedEventArgs : EventArgs
    {
        public string OldName { get; }
        public string NewName { get; }

        // Wartości są readonly, żeby nie można było ich zmieniać podczas wywoływania między przypiętymi metodami
        public NameChangedEventArgs(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }
    }
}
