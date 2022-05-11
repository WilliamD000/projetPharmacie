/* Objet   : Personne
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Objet qui représente une personne*/

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
            get { return nom; }
            set { nom = value; }
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
        /// <summary>
        /// Constructeur non paramètré
        /// </summary>
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
        /// <summary>
        /// Constructeur paramètré
        /// </summary>
        /// <param name="unPrenom">Un prénom</param>
        /// <param name="unNom">Un nom</param>
        /// <param name="uneAdresse">Une adresse</param>
        /// <param name="uneVille">Une ville</param>
        /// <param name="uneProvince"> Une province</param>
        /// <param name="unCodePostal">Un code postal</param>
        /// <param name="unTelephone">Un téléphone</param>
        /// <param name="unCourriel">Un courriel</param>
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
        /// <summary>
        /// Méthode remplaçant l'action par défaut .ToString()
        /// </summary>
        /// <returns>Les informations de la personne en un String</returns>
        public override string ToString()
        {
            return (Prenom + ", " + Nom + ", " + Adresse + ", " + Ville + ", " + Province + ", " + CodePostal + ", " + Telephone + ", " + Courriel);
        }
        /// <summary>
        /// Permet d'attribuer un code unique à un objet
        /// </summary>
        /// <returns>Code de Hashage</returns>
        public override int GetHashCode()
        {
            return (prenom.Length + nom.Length + courriel.Length);
        }
        /// <summary>
        /// Permet de comparer deux objets afin d'éviter les doublons
        /// </summary>
        /// <param name="obj">Objet à comparer</param>
        /// <returns>Valeur booléene</returns>
        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Personne) && courriel.Equals((obj as Personne).courriel);
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
