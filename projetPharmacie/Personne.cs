/* Objet   : Pharmacie
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Objet qui représente une personne*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPharmacie
{
    public class Personne
    {
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string nom;

        public string Nom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string ville;

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        private string province;

        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        private string codePostal;

        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private string courriel;

        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        public Personne()
        {
            prenom = "";
            nom = "";
            adresse = "";
            ville = "";
            province = "";
            codePostal = "";
            telephone = "";
            courriel = "";
        }
        public Personne(string unPrenom, string unNom, string uneAdresse, string uneVille, string uneProvince, string unCodePostal, string unTelephone, string unCourriel)
        {
            prenom = unPrenom;
            nom = unNom;
            adresse = uneAdresse;
            ville = uneVille;
            province = uneProvince;
            codePostal = unCodePostal;
            telephone = unTelephone;
            courriel = unCourriel;
        }
        public override string ToString()
        {
            return(prenom + ", " + nom + ", " + adresse + ", " + ville + ", " + province + ", " + codePostal + ", " + telephone + ", " +  courriel);
        }
        public override int GetHashCode()
        {
            return(prenom.Length + nom.Length + courriel.Length);
        }
        public override bool Equals(object obj)
        {
            return(obj != null) && (obj is Personne) && courriel.Equals((obj as Personne).courriel);
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
