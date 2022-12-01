using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class SerieTv
    {
        //PROPRIETà
        private string titolo;
        private int annoDiProduzione;
        private int stagione;
        //private string director;
        private List<Attori> attori;
        private List<Episodio> episodi;
        //STATO
        private bool inWishlist;
        private bool preferito;
        // COSTRUTTORI
        public SerieTv(string titolo, int stagione, int annoDiProduzione, Attori attori, Episodio episodi, bool inWishlist = false, bool preferito = false)
        {
            this.titolo = titolo;
            this.stagione = stagione;
            this.annoDiProduzione = annoDiProduzione;
            this.attori = new List<Attori>(){attori};
            this.episodi = new List<Episodio>() { episodi };
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
        public void StampaSerie()
        {
            Console.WriteLine("\t" + this.titolo + " " + this.annoDiProduzione +", ");
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
