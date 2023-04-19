// See https://aka.ms/new-console-template for more information
using CSharp_Composizione_Shop;

Console.WriteLine("Ciao, Utente!");

Negozio Guitarshop = new Negozio("Guitarshop", "Torino", "Via Boston", 15);

Prodotto Bottiglia = new Prodotto("bottiglia", "bottiglia in plastica", 3.5f, 10);

Bottiglia.printProduct();