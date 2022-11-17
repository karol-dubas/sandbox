// Abstrakcjami są:
// - klasa kiedy ukrywa szczegóły implementacji i wystawia tylko publiczne składowe
// - cały projekt, tak samo wystawiając np. tylko endpointy

// Można to porównać do np. drukarki.
// Udostępnioną mamy możliwość drukowania, a pod spodem wykonywane są ukryte implementacje.

var printer = new Printer();
printer.Print("text");