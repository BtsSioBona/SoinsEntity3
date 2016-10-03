using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestationSoin
{
    class Dossier
    {
        private string nomPatient;
        private string prenomPatient;
        private DateTime dateNaissancePatient;
        private List<Prestation> mesPrestations;
        private string remarques;

        public Dossier(string NomPatient, string PrenomPatient, DateTime DateNaissancePatient)
        {
            nomPatient = NomPatient;
            prenomPatient = PrenomPatient;
            dateNaissancePatient = DateNaissancePatient;
            mesPrestations = new List<Prestation>();
        }

        public Dossier(Prestation unePrestation)
        {
            mesPrestations = new List<Prestation>();
            this.ajouterPrestation(unePrestation);
        }

        public Dossier(List<Prestation> desPrestations)
        {
            mesPrestations = new List<Prestation>(desPrestations);
        }

        public List<Prestation> getMesPrestations()
        {
            return mesPrestations;
        }

        public void ajouterPrestation(string unLibelle, DateTime uneDate, DateTime uneHeure, Intervenant unIntervenant)
        {
            mesPrestations.Add(new Prestation(unLibelle, uneDate, uneHeure, unIntervenant));
        }

        public void ajouterPrestation(Prestation unePrestation)
        {
            mesPrestations.Add(unePrestation);
        }

        public void ajouterRemarque(string Remarques)
        {
            remarques = Remarques;
        }

        public string getDossier()
        {
            return nomPatient + ' ' + prenomPatient + " née le " + dateNaissancePatient.ToShortDateString();
        }

        public int getNbPrestationConfondu()
        {
            return mesPrestations.Count;
        }

        public int getNbPrestation()
        {
            int nb = 0;
            foreach (Prestation p in mesPrestations)
                if (p.getI_Intervenant().GetType().ToString() != "IntervenantExterne")
                    nb++;
            return nb;
        }

        public int getNbPrestationExterne()
        {
            int nb = 0;
            foreach (Prestation p in mesPrestations)
                if (p.getI_Intervenant().GetType().ToString() == "IntervenantExterne") 
                    nb++;
            return nb;
        }

        public int getNbJoursSoin()
        {
           List<DateTime> lesDates = new List<DateTime>();
            for (int i = 0; i < mesPrestations.Count; i++)
                if(!lesDates.Contains(mesPrestations[i].getDateSoin()))
                    lesDates.Add(mesPrestations[i].getDateSoin());
            return lesDates.Count;
        }




    }
}
