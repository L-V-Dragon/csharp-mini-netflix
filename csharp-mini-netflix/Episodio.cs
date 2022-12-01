using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class Episodio
    {
        // PROPRIETA
        private string titolo;
        private double durata;
        private List<Attori> autori;
        // STATO
        // COSTRUTTORI
        public Episodio(string titolo, double durata, List<Attori> autori)
        {
            this.titolo = titolo;
            this.durata = durata;
            List<Attori> autoriOrdinati = autori.OrderBy(autore => autore.GetEta()).ToList();
            this.autori = autoriOrdinati;
        }
        // GETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }
        public double GetDurata()
        {
            return this.durata;
        }
        // SETTERS
        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }
        public void SetDurata(double durata)
        {
            this.durata = durata;
        }
        // METODI PUBBLICI
        public void StampaEpisodio()
        {
            Console.WriteLine("\t" + this.titolo + " " + this.durata + " min");
        }
    }
}
