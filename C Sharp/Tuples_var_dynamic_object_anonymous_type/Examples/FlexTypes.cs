namespace Tuples_var_dynamic_object_anonymous_type.Examples
{
    internal class FlexTypes
    {
        public FlexTypes()
        {
            // dynamic to poszerzony object o boxing/unboxing przy konwersji typów wartościowych

            // var isn't a type. The actual type is figured out at compile-time.
            object object1;
            dynamic dynamic1;
            //var var1;

            object object2 = 1; // Zostaje object po przypisaniu
            dynamic dynamic2 = 1; // Zostaje dynamic po przypisaniu
            int var2 = 1; // Zmienia wartość w czasie tworzenia kodu (nie kompilacji)

            // Nie można zmienić typu dobranego do var.
            // object i dynamic mogą przyjąć wszystko.
            object2 = "1";
            dynamic2 = "1";
            //var2 = "1";

            dynamic dynamic3 = new Student();
            // Nie sprawdza podczas pisania kodu, tylko kompilacji
            dynamic3.Name = "Karol";
            // dynamic3.NewProp = "I'm not real";
        }
    }
}