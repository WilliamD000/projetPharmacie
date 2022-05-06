/* Objet   : Pharmacie
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Objet qui représente un Employé*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Employe()
        {
            numeroEmploye = 0;
            nas = 0;
            poste = "";
            dateEmbauche = DateTime.Now;
            actif = false;
        }
        public Employe(int unNumeroEmploye, int unNas, string unPoste, DateTime uneDateEmbauche, bool unActif)
        {
            numeroEmploye = unNumeroEmploye;
            nas = unNas;
            poste = unPoste;
            dateEmbauche = uneDateEmbauche;
            actif = unActif;
        }
        public override string ToString()
        {
            return (poste + ", " + nas + ", " + numeroEmploye + ", actif:" + actif);
        }
        public override int GetHashCode()
        {
            return (numeroEmploye);
        }
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
