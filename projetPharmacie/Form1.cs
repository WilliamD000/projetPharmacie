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
            btnModifierPharmacie.Enabled = true;
            btnSupprimerPharmacie.Enabled = true;
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
            if (unePharmacie != null)
            {
                MessageBox.Show(unePharmacie.ToString());
            }
            else
            {
                MessageBox.Show("Vous n'avez pas crée de pharmacie");
            }

        }
        /// <summary>
        /// Permet de gérer l'ouverture du fichier Xml, ou en crée un nouveau s'il n'existe pas
        /// </summary>
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
                    edtNoPharmacie.Text = unePharmacie.NoPharmacie.ToString();
                    edtNomPharmacie.Text = unePharmacie.NomPharmacie;
                    edtAdressePharmacie.Text = unePharmacie.AdressePharmacie;
                    edtVillePharmacie.Text = unePharmacie.VillePharmacie;
                    edtProvincePharmacie.Text = unePharmacie.ProvincePharmacie;
                    edtCodePostalPharmacie.Text = unePharmacie.CodePostalPharmacie;
                    edtTelephonePharmacie.Text = unePharmacie.TelephonePharmacie;
                    edtCourrielPharmacie.Text = unePharmacie.CourrielPharmacie;
                    dtpDateImplantationPharmacie.Value = unePharmacie.AnneeDImplantationPharmacie;
                    btnModifierPharmacie.Enabled = true;
                    btnSupprimerPharmacie.Enabled = true;
                }
                else
                {
                    File.WriteAllText("Pharmacie.Xml", "");
                    MessageBox.Show("Le fichier 'Pharmacie.Xml' a été crée, n'oubliez pas d'enregistrer souvent!");
                    edtNoPharmacie.Text = "1235";
                    edtNomPharmacie.Text = "Familiprix";
                    edtAdressePharmacie.Text = "200 rue Témiscouata";
                    edtVillePharmacie.Text = "Rivière-du-Loup";
                    edtProvincePharmacie.Text = "Québec";
                    edtCodePostalPharmacie.Text = "G5R2Y5";
                    edtTelephonePharmacie.Text = "418-862-2176";
                    edtCourrielPharmacie.Text = "experienceclient@familiprix.com";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Classe Pharmacie non détecté, veuillez créer une pharmacie et enregistrer.");
                edtNoPharmacie.Text = "1235";
                edtNomPharmacie.Text = "Familiprix";
                edtAdressePharmacie.Text = "200 rue Témiscouata";
                edtVillePharmacie.Text = "Rivière-du-Loup";
                edtProvincePharmacie.Text = "Québec";
                edtCodePostalPharmacie.Text = "G5R2Y5";
                edtTelephonePharmacie.Text = "418-862-2176";
                edtCourrielPharmacie.Text = "experienceclient@familiprix.com";
            }
        }

        private void btnModifierPharmacie_Click(object sender, EventArgs e)
        {
            unePharmacie.NoPharmacie = int.Parse(edtNoPharmacie.Text);
            unePharmacie.NomPharmacie = edtNomPharmacie.Text;
            unePharmacie.AdressePharmacie = edtAdressePharmacie.Text;
            unePharmacie.VillePharmacie = edtVillePharmacie.Text;
            unePharmacie.ProvincePharmacie = edtProvincePharmacie.Text;
            unePharmacie.CodePostalPharmacie = edtProvincePharmacie.Text;
            unePharmacie.TelephonePharmacie = edtTelephonePharmacie.Text;
            unePharmacie.CourrielPharmacie = edtCourrielPharmacie.Text;
            unePharmacie.AnneeDImplantationPharmacie = dtpDateImplantationPharmacie.Value;
        }

        private void btnSupprimerPharmacie_Click(object sender, EventArgs e)
        {
            unePharmacie = null;
            btnCreerPharmacie.Enabled = true;
            btnModifierPharmacie.Enabled = false;
            btnSupprimerPharmacie.Enabled = false;
        }
    }
}
