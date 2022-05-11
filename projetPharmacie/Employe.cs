/* Objet   : Employe
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Objet qui représente un Employé*/
using System;

namespace projetPharmacie
{
    public class Employe : Personne
    {
        private int numeroEmploye;

        public int NumeroEmploye
        {
            get { return numeroEmploye; }
            set { numeroEmploye = value; }
        }
        private int nas;

        public int Nas
        {
            get { return nas; }
            set { nas = value; }
        }
        private string poste;

        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }
        private DateTime dateEmbauche;

        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }
        private bool actif;

        public bool Actif
        {
            get { return actif; }
            set { actif = value; }
        }
        /// <summary>
        /// Constructeur non parametré
        /// </summary>
        public Employe()
        {
            numeroEmploye = 0;
            nas = 0;
            poste = "";
            dateEmbauche = DateTime.Now;
            actif = false;
        }
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unNumeroEmploye"></param>
        /// <param name="unNas"></param>
        /// <param name="unPoste"></param>
        /// <param name="uneDateEmbauche"></param>
        /// <param name="unActif"></param>
        public Employe(int unNumeroEmploye, int unNas, string unPoste, DateTime uneDateEmbauche, bool unActif)
        {
            numeroEmploye = unNumeroEmploye;
            nas = unNas;
            poste = unPoste;
            dateEmbauche = uneDateEmbauche;
            actif = unActif;
        }
        /// <summary>
        /// Méthode qui affiche les informations de l'employé dans la commande .ToString()
        /// </summary>
        /// <returns>Liste d'informations de l'employé</returns>
        public override string ToString()
        {
            return (Prenom + ", " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", "
                + Courriel + ", " + Poste + ", " + Nas + ", " + NumeroEmploye + ", actif:" + Actif);
        }
        /// <summary>
        /// Méthode qui attitre un code unique à un objet
        /// </summary>
        /// <returns>Code de hashage</returns>
        public override int GetHashCode()
        {
            return (numeroEmploye);
        }
        /// <summary>
        /// Méthode qui compare 2 objets pour éviter d'accumuler des doublons
        /// </summary>
        /// <param name="obj">Objet à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Employe) && numeroEmploye.Equals((obj as Employe).numeroEmploye);
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
