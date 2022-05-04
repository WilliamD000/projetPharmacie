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
        public override string ToString()
        {
            return (noPharmacie.ToString() + ", " + nomPharmacie + ", " + adressePharmacie + ", " + villePharmacie + ", " + provincePharmacie + ", " + codePostalPharmacie + ", "
                + telephonePharmacie + ", " + courrielPharmacie + ", " + anneeDImplantationPharmacie);
        }
        public override int GetHashCode()
        {
            return (noPharmacie);
        }
        public override bool Equals(object obj)
        {
            return ((obj != null) && (obj is Pharmacie) && noPharmacie.Equals((obj as Pharmacie).noPharmacie));
        }


    }
}
