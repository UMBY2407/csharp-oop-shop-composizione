using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
	internal class Negozio
	{
		//ATTRIBUTI
		private string nome;
		private string citta;
		private string indirizzo;
		private int numeroCivico;
		private List<Prodotto> listaProdotti;

		//COSTRUTTORI
		public Negozio(string nome, string citta, string indirizzo, int numeroCivico) {
			this.nome = nome;
			this.citta = citta;
			this.indirizzo = indirizzo;
			this.numeroCivico = numeroCivico;
			this.listaProdotti = new List<Prodotto>();
		}

		//GETTERS
		public string getNome() { return nome;}
		public string getCitta() {  return citta;}
		public string getIndirizzo() {  return indirizzo;}
		public int getNumeroCivico() {  return numeroCivico;}
		public List<Prodotto> GetListaProdotti()
		{
			return this.listaProdotti;
		}

		//SETTERS

		public void setCitta(string citta)
		{
			this.citta = citta;
		}
		public void setIndirizzo (string indirizzo)
		{
			this.indirizzo = indirizzo;
		}

		public void setNumeroCivico (int numeroCivico)
		{
			this.numeroCivico = numeroCivico;
		}

		//METODI
		public void aggiungiProdotto(Prodotto nuovoProdotto)
		{
			listaProdotti.Add(nuovoProdotto);
		}

		public void aggiungiListaProdotti (List<Prodotto> listaProdottiDaAggiungere)
		{
			foreach (Prodotto nuovoProdottoDaAggiungere in listaProdotti)
			{
				this.listaProdotti.Add(nuovoProdottoDaAggiungere);
			}
		}

		public string StampaInfoNegozio()
		{
			string rapprStringa = "Nome Negozio: " + this.nome + "\n";
			rapprStringa += "Città: " + this.citta + "\n";
			rapprStringa += "Indirizzo: " + this.indirizzo + "\n";
			rapprStringa += "Numero civico: " + this.numeroCivico + "\n";
            
			return rapprStringa;
		}

		public string StampaListaProdotti()
		{
			string rapprSringa = "";
			foreach (Prodotto prodottoScansionato in listaProdotti)
			{
				rapprSringa += " - " + prodottoScansionato.GetProdottoStringa() + "\n";
			}
			rapprSringa += "\n";
			return rapprSringa;
		}
	}
}
