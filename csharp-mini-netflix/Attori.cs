using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_mini_netflix
{
    public class Attori
    {
        // PROPRIETA
        private string nome;
        private string cognome;
        private int eta;
        // STATO
        private bool deceduto;
        private bool inServizio;
        // COSTRUTTORI
        public Attori(string nome, string cognome, int eta, bool deceduto = false, bool inServizio = true)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.deceduto = deceduto;
            this.inServizio = inServizio;
        }
        // GETTERS
        public string GetNome()
        {
            return this.nome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public int GetEta()
        {
            return this.eta;
        }
        public bool GetDeceduto()
        {
            return this.deceduto;
        }
        public bool GetInServizio()
        {
            return this.inServizio;
        }
        // SETTERS
        public void SetEta(int eta)
        {
            this.eta = eta;
        }
        public void SetInServizio(bool inServizio)
        {
            this.inServizio = inServizio;
        }
        // METODI PUBBLICI
        public void Morto()
        {
            this.deceduto = true;
        }
        public void StampaAttore()
        {
            Console.WriteLine("\t" + this.nome + " " + this.cognome + ", " + this.eta + " anni");
        }
        // METODI DI UTILITA
    }
}
