using OOP.Inheritance;

// Child() : base() bez { } -> Base() -> Child() { }
var child = new Child("foo");

// dla bezparametrowego konstruktora zadziała tak samo, tylko bez 'base'
// Child() bez { } -> Base() -> Child() { }
Child child2 = new Child();

// Child poszerzony jest o Base
child2.BaseMethod();
child2.ChildMethod();
