/* Objet   : Prescription
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Objet qui représente une prescription*/
using System;

namespace projetPharmacie
{
    public class Prescription
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
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
        public Prescription()
        {
            numeroPrescription = 0;
            active = false;
            dateInscription = DateTime.Now;
        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unNumeroInscription">Un numéro d'inscription d'une prescription</param>
        /// <param name="uneActive">Booléen signifiant l'activité d'une prescription</param>
        /// <param name="uneDateInscription">Date d'inscription d'une prescription</param>
        public Prescription(int unNumeroInscription, bool uneActive, DateTime uneDateInscription)
        {
            numeroPrescription = unNumeroInscription;
            active = uneActive;
            dateInscription = uneDateInscription;
        }
        /// <summary>
        /// Méthode remplaceant l'action par défaut de la méthode .ToString()
        /// </summary>
        /// <returns>Informations de la prescription en un string</returns>
        public override string ToString()
        {
            return (NumeroPrescription + ", active: " + active + ", " + DateInscription);
        }
        /// <summary>
        /// Permet d'attribuer un code unique à un objet
        /// </summary>
        /// <returns>Code de hashage</returns>
        public override int GetHashCode()
        {
            return (NumeroPrescription);
        }
        /// <summary>
        /// permet de comparer deux objets
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return (obj is Prescription) && (obj != null) && NumeroPrescription.Equals((obj as Prescription).NumeroPrescription);
        }

        public Pharmacie Pharmacie
        {
            get => default;
            set
            {
            }
        }
    }
}
