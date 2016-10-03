using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestationSoin
{
    class Prestation
    {
        private DateTime date;
        private DateTime heure;
        private Intervenant I_Intervenant;
        private string libelle;

        public Prestation(string Libelle, DateTime Date, DateTime Heure, Intervenant Intervenant)
        {
            this.Libelle = Libelle;
            date = Date;
            heure = Heure;
            I_Intervenant = Intervenant;
            I_Intervenant.ajouterPrestation(this);
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public int compareTo(Prestation unePrestation)
        {
            if (date == unePrestation.getDateSoin())
                return 0;
            else if (date > unePrestation.getDateSoin())
                return 1;
            return -1;
        } 

        public DateTime getDateSoin()
        {
            return date;
        }

        public string getHeureSoin()
        {
            return Convert.ToString(heure.Hour + 'h' + heure.Minute);
        }

        public Intervenant getI_Intervenant()
        {
            return I_Intervenant;
        }

    }
}
