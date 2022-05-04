/* Objet     : Pharmacie
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Objet qui représente la pharmacie*/
using System;

namespace projetPharmacie
{
    public class Pharmacie
    {
        private int noPharmacie;

        public int NoPharmacie
        {
            get { return noPharmacie; }
            set { noPharmacie = value; }
        }
        private string nomPharmacie;

        public string NomPharmacie
        {
            get { return nomPharmacie; }
            set { nomPharmacie = value; }
        }
        private string adressePharmacie;

        public string AdressePharmacie
        {
            get { return adressePharmacie; }
            set { adressePharmacie = value; }
        }
        private string villePharmacie;

        public string VillePharmacie
        {
            get { return villePharmacie; }
            set { villePharmacie = value; }
        }
        private string provincePharmacie;

        public string ProvincePharmacie
        {
            get { return provincePharmacie; }
            set { provincePharmacie = value; }
        }
        private string codePostalPharmacie;

        public string CodePostalPharmacie
        {
            get { return codePostalPharmacie; }
            set { codePostalPharmacie = value; }
        }
        private string telephonePharmacie;

        public string TelephonePharmacie
        {
            get { return telephonePharmacie; }
            set { telephonePharmacie = value; }
        }
        private string courrielPharmacie;

        public string CourrielPharmacie
        {
            get { return courrielPharmacie; }
            set { courrielPharmacie = value; }
        }
        private DateTime anneeDImplantationPharmacie;

        public DateTime AnneeDImplantationPharmacie
        {
            get { return anneeDImplantationPharmacie; }
            set { anneeDImplantationPharmacie = value; }
        }
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
        public Pharmacie()
        {
            noPharmacie = 0;
            nomPharmacie = "";
            adressePharmacie = "";
            villePharmacie = "";
            provincePharmacie = "";
            codePostalPharmacie = "";
            telephonePharmacie = "";
            courrielPharmacie = "";
            anneeDImplantationPharmacie = DateTime.Now;

        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unNoPharmacie">Numero d'une pharmacie</param>
        /// <param name="unNomPharmacie">Nom d'une pharmacie</param>
        /// <param name="uneAdressePharmacie">Adresse d'une pharmacie</param>
        /// <param name="uneVillePharmacie">Ville d'une pharmacie</param>
        /// <param name="uneProvincePharmacie">Province d'une pharmacie</param>
        /// <param name="unCodePostalPharmacie">Code Postal d'une pharmacie</param>
        /// <param name="unTelephonePharmacie">Numero de telephone d'une pharmacie</param>
        /// <param name="unCourrielPharmacie">Courriel d'une pharmacie</param>
        /// <param name="uneAnneeDImplantationPharmacie">Annee d'implantation d'une pharmacie</param>
        public Pharmacie(int unNoPharmacie, string unNomPharmacie, string uneAdressePharmacie, string uneVillePharmacie, string uneProvincePharmacie,
            string unCodePostalPharmacie, string unTelephonePharmacie, string unCourrielPharmacie, DateTime uneAnneeDImplantationPharmacie)
        {
            noPharmacie = unNoPharmacie;
            nomPharmacie = unNomPharmacie;
            adressePharmacie = uneAdressePharmacie;
            villePharmacie = uneVillePharmacie;
            provincePharmacie = uneProvincePharmacie;
            codePostalPharmacie = unCodePostalPharmacie;
            telephonePharmacie = unTelephonePharmacie;
            courrielPharmacie = unCourrielPharmacie;
            anneeDImplantationPharmacie = uneAnneeDImplantationPharmacie;

        }
        /// <summary>
        /// Remplace la méthode "ToString" de l'objet
        /// </summary>
        /// <returns>Les informations de la pharmacie</returns>
        public override string ToString()
        {
            return (noPharmacie.ToString() + ", " + nomPharmacie + ", " + adressePharmacie + ", " + villePharmacie + ", " + provincePharmacie + ", " + codePostalPharmacie + ", "
                + telephonePharmacie + ", " + courrielPharmacie + ", " + anneeDImplantationPharmacie);
        }
        /// <summary>
        /// Créer un code unique pour l'objet pharmacie
        /// </summary>
        /// <returns>Code de hashage</returns>
        public override int GetHashCode()
        {
            return (noPharmacie);
        }
        /// <summary>
        /// Permet de comparer 2 objet pour éviter les doublons
        /// </summary>
        /// <param name="obj">Objet à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Pharmacie) && noPharmacie.Equals((obj as Pharmacie).noPharmacie));
        }


    }
}
