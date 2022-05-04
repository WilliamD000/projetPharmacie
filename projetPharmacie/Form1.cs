/* Nom     : ProjetPharmacie
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But: Simuler la gestion d'une pharmacie et de ses médicaments, patients et médecins.*/
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace projetPharmacie
{
    public partial class Form1 : Form
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Pharmacie));
        Pharmacie unePharmacie;
        public Form1()
        {
            InitializeComponent();
            OuvrirFichier();
        }

        private void btnCreerPharmacie_Click(object sender, EventArgs e)
        {
            unePharmacie = new Pharmacie();
            unePharmacie.NoPharmacie = int.Parse(edtNoPharmacie.Text);
            unePharmacie.NomPharmacie = edtNomPharmacie.Text;
            unePharmacie.AdressePharmacie = edtAdressePharmacie.Text;
            unePharmacie.VillePharmacie = edtVillePharmacie.Text;
            unePharmacie.ProvincePharmacie = edtProvincePharmacie.Text;
            unePharmacie.CodePostalPharmacie = edtProvincePharmacie.Text;
            unePharmacie.TelephonePharmacie = edtTelephonePharmacie.Text;
            unePharmacie.CourrielPharmacie = edtCourrielPharmacie.Text;
            unePharmacie.AnneeDImplantationPharmacie = dtpDateImplantationPharmacie.Value;
            btnCreerPharmacie.Enabled = false;
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("Pharmacie.Xml"))
            {
                serializer.Serialize(writer, unePharmacie);
            }
            MessageBox.Show("Programme enregistré.");
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFichier();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void àProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(unePharmacie.ToString());
        }
        public void OuvrirFichier()
        {
            try
            {
                if (File.Exists("Pharmacie.Xml"))
                {
                    serializer = new XmlSerializer(typeof(Pharmacie));
                    using (StreamReader reader = new StreamReader("Pharmacie.Xml"))
                    {
                        unePharmacie = (Pharmacie)serializer.Deserialize(reader);
                    }
                    MessageBox.Show("Programme ouvert.");
                    btnCreerPharmacie.Enabled = false;
                }
                else
                {
                    File.WriteAllText("Pharmacie.Xml", "");
                    MessageBox.Show("Le fichier 'Cegep.xml' a été crée, n'oubliez pas d'enregistrer souvent!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Classe cégep non détecté, veuillez créer un cégep et enregistrer.");
            }
        }
    }
}
