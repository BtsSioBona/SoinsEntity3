using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestationSoin
{
    class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        public IntervenantExterne(string Nom, string Prenom, string Specialite, string Adresse, string Tel)
            :base(Nom, Prenom)
        {
            specialite = Specialite;
            adresse = Adresse;
            tel = Tel;
        }

        public string getSpecialite()
        {
            return specialite;
        }

        public string getAdresse()
        {
            return adresse;
        }

        public string getTel()
        {
            return tel;
        }
    }
}
