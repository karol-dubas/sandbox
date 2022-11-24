// Abstrakcjami są:
// - klasa kiedy ukrywa szczegóły implementacji i wystawia tylko publiczne składowe
// - cały projekt, tak samo wystawiając np. tylko endpointy

// Można to porównać do np. drukarki.
// Udostępnioną mamy możliwość drukowania, a pod spodem wykonywane są ukryte implementacje.

// W tym przykładzie drukarki implementują interfejs (kontrakt), który jest abstrakcją, nie ważne z jakiej
// drukarki korzystamy, wywoływane są w taki sam sposób, bez wiedzy co wykonuje się pod spodem w każdej z klas.

IPrinter printer = new HpPrinter();
printer.Print("text");

printer = new CanonPrinter();
printer.Print("test");