// See https://aka.ms/new-console-template for more information
using CSharp_Composizione_Shop;

Console.WriteLine("Ciao, Utente!");
string infoNegozio;
string infoProdotto;

Negozio Guitarshop = new Negozio("Guitarshop", "Torino", "Via Boston", 15);
infoNegozio = Guitarshop.StampaInfoNegozio();
Console.WriteLine(infoNegozio);

Prodotto Telecaster = new Prodotto("Fender Telecaster", "Fender Telecaster del '72","Chitarra Elettrica", 2500f, 22);
Prodotto CordeE = new Prodotto("Corde Elixir 0.10", "Corde per Chitarra Elettrica Elixir", "Corde per Chitarra", 20f, 22);
Prodotto LesPaul = new Prodotto("Gibson Les Paul", "Gibson LesPaul 2020", "Chitarra Elettrica", 1500f, 22);

Guitarshop.aggiungiProdotto(Telecaster);
Guitarshop.aggiungiProdotto(CordeE);
Guitarshop.aggiungiProdotto(LesPaul);