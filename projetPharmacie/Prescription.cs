/* Objet   : Prescription
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Objet qui représente une prescription*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPharmacie
{
    class Prescription
    {
        private int numeroPrescription;

        public int NumeroPrescription
        {
            get { return numeroPrescription; }
            set { numeroPrescription = value; }
        }
        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        private DateTime dateInscription;

        public DateTime DateInscription
        {
            get { return dateInscription; }
            set { dateInscription = value; }
        }

        public Prescription()
        {
            numeroPrescription = 0;
            active = false;
            dateInscription = DateTime.Now;
        }
        public Prescription(int unNumeroInscription, bool uneActive, DateTime uneDateInscription)
        {
            numeroPrescription = unNumeroInscription;
            active = uneActive;
            dateInscription = uneDateInscription;
        }
        public override string ToString()
        {
            return (NumeroPrescription + ", active: " + active + ", " + DateInscription);
        }

        public override int GetHashCode()
        {
            return(NumeroPrescription);
        }

        public override bool Equals(object obj)
        {
            return (obj is Prescription) && (obj != null) && NumeroPrescription.Equals((obj as Prescription).NumeroPrescription);
        }
    }
}
