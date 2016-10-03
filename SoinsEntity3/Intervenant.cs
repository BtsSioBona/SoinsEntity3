using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestationSoin
{
    class Intervenant
    {
        protected string nom;
        protected string prenom;
        private List<Prestation> lesPrestations;

        public Intervenant(string Nom, string Prenom)
        {
            nom = Nom;
            prenom = Prenom;
            lesPrestations = new List<Prestation>();
        }

        public void ajouterPrestation(Prestation unePrestation)
        {
            lesPrestations.Add(unePrestation);
        }

        public string getNom()
        {
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }
    }
}
