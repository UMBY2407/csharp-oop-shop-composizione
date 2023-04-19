using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
	internal class Prodotto
	{
		//ATTRIBUTI
		private int codice;
		private string name;
		private string description;
		private float price;
		private float priceWithIva;
		private int iva;


		//GETTER
		public string getNome()
		{
			return this.name;
		}

		public string getDescription()
		{
			return this.description;
		}

		public float getPrice()
		{
			return this.price;
		}

		public float getPriceWithIva()
		{
			return this.priceWithIva;
		}


		//SETTER
		public string setNome()
		{
			Console.Write("Inserisci il nome del prodotto: ");
			name = Console.ReadLine();
			return this.name;
		}

		public string setDescription()
		{
			Console.Write("Inserisci la descrizione del prodotto: ");
			description = Console.ReadLine();
			return this.description;
		}

		public float setPrezzo()
		{
			Console.Write("Inserisci il prezzo del prodotto: ");
			price = float.Parse(Console.ReadLine());
			return this.price;
		}

		public int setIva()
		{
			Console.Write("Inserire l'iva del prodotto: ");
			iva = int.Parse(Console.ReadLine());
			return this.iva;
		}

		public float setPriceWithIva()
		{
			priceWithIva = price + (price / 100) * iva;
			return this.priceWithIva;
		}


		//METODI	
		private int creaCodice()
		{
			Random rdn = new Random();
			codice = rdn.Next();
			return this.codice;
		}


		public void creaProdotto()
		{
			creaCodice();
			setNome();
			setDescription();
			setPrezzo();
			setIva();
			setPriceWithIva();
		}

		public void printProduct()
		{
			Console.WriteLine("-------------- PRODOTTO -----------------");
			Console.WriteLine("Codice prodotto: " + creaCodice());
			Console.WriteLine("Nome prodotto: " + getNome());
			Console.WriteLine("Descrizione prodotto: " + getDescription());
			Console.WriteLine("Prezzo prodotto (iva esclusa): " + getPrice() + " EUR");
			Console.WriteLine("Prezzo prodotto (+ iva): " + getPriceWithIva() + " EUR");
			Console.WriteLine("-------------------------------------------");
		}
	}
}
