using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class Film
    {
        //PROPRIETà
        private string titolo;
        private int annoDiProduzione;
        //private string director;
        private List<Attori> attori;
        //STATO
        private bool inWishlist;
        private bool preferito;
        // COSTRUTTORI
        public Film(string titolo, int annoDiProduzione, Attori attori, bool inWishlist = false, bool preferito = false)
        {
            this.titolo = titolo;
            this.annoDiProduzione = annoDiProduzione;
            this.attori = new List<Attori>()
            {
                attori
            };
            this.inWishlist = inWishlist;
            this.preferito = preferito;
        }
        // GETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }
        public int GetAnnoDiProduzione()
        {
            return this.annoDiProduzione;
        }
        public List<Attori> GetAttori()
        {
            return this.attori;
        }
        public bool GetWishlist()
        {
            return this.inWishlist;
        }
        public bool GetPreferito()
        {
            return this.preferito;
        }
        // SETTERS
        public void SetWishlist(bool inWishlist)
        {
            this.inWishlist = inWishlist;
        }
        public void SetPreferito(bool preferito)
        {
            this.preferito = preferito;
        }
        // METODI PUBBLICI
        public void StampaFilm()
        {
            Console.WriteLine("\t" + this.titolo + " " + this.annoDiProduzione + ", ");
            StampaAttoriLista();
        }
        // METODI DI UTILITA
        private void StampaAttoriLista()
        {
            foreach (Attori attore in this.attori)
            {
                attore.StampaAttore();
            }
        }
    }
}