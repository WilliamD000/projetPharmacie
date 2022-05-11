/* Nom     : ProjetPharmacie
 * Date    : 2022/05/04
 * Version : 1.0
 * Auteur  : William Desjardins
 * But     : Simuler la gestion d'une pharmacie et de ses médicaments, patients et médecins.*/
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
        Employe unEmploye;
        int index = 0;
        int compteurEmploye = 0;
        public Form1()
        {
            InitializeComponent();
            OuvrirApplication();
        }
        /// <summary>
        /// Permet de créer la pharmacie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Permet d'enregistrer les informations de la pharmacie dans le fichier XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("Pharmacie.Xml"))
            {
                serializer.Serialize(writer, unePharmacie);
            }
            MessageBox.Show("Programme enregistré.");
        }
        /// <summary>
        /// Permet d'extraire les informations du fichier XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirFichier();
        }
        /// <summary>
        /// Permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Permet d'afficher les informations de la pharmacie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    InitialiserListeEmploye(compteurEmploye);
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
        /// <summary>
        /// Permet de modifier la pharmacie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Permet de supprimer la pharmacie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPharmacie_Click(object sender, EventArgs e)
        {
            unePharmacie = null;
            btnCreerPharmacie.Enabled = true;
            btnModifierPharmacie.Enabled = false;
            btnSupprimerPharmacie.Enabled = false;
            InitialiserListeEmploye(compteurEmploye);
        }
        /// <summary>
        /// Permet de créer l'employé, avec validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {
            try
            {
                unEmploye = new Employe();
                unEmploye.Prenom = edtPrenomEmploye.Text;
                unEmploye.Nom = edtNomEmploye.Text;
                unEmploye.Adresse = edtAdresseEmploye.Text;
                unEmploye.Ville = edtVilleEmploye.Text;
                unEmploye.CodePostal = edtCodePostalEmploye.Text;
                unEmploye.Province = edtProvinceEmploye.Text;
                unEmploye.Telephone = edtTelephoneEmploye.Text;
                unEmploye.Courriel = edtCourrielEmploye.Text;
                unEmploye.Nas = int.Parse(edtNas.Text);
                unEmploye.NumeroEmploye = int.Parse(edtNumeroEmploye.Text);
                unEmploye.Actif = cbxActif.Checked;
                unEmploye.Poste = edtPoste.Text;
                unEmploye.DateEmbauche = dtpDateEmbauche.Value;
                if (unePharmacie.AjouterEmploye(unEmploye) == false)
                {
                    MessageBox.Show("Cet employé existe déja.");
                }
                else
                {
                    compteurEmploye++;
                    unePharmacie.AjouterEmploye(unEmploye);
                    InitialiserListeEmploye(compteurEmploye);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erreur d'entrée, réessayer");
            }

        }
        /// <summary>
        /// Permet de modifier l'employé avec la saisie des champs d'édition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            if (unePharmacie.ObtenirNombreEmploye() == 0)
            {
                MessageBox.Show("Il n'y a aucun employé dans la liste");
            }
            else
            {
                if (lbxEmploye.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez sélectionner un employé");
                }
                else
                {
                    index = lbxEmploye.SelectedIndex;
                    unePharmacie.ObtenirListeEmploye()[index].Prenom = edtPrenomEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Nom = edtNomEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Adresse = edtAdresseEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Ville = edtVilleEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].CodePostal = edtCodePostalEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Province = edtProvinceEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Telephone = edtTelephoneEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Courriel = edtCourrielEmploye.Text;
                    unePharmacie.ObtenirListeEmploye()[index].Nas = int.Parse(edtNas.Text);
                    unePharmacie.ObtenirListeEmploye()[index].NumeroEmploye = int.Parse(edtNumeroEmploye.Text);
                    unePharmacie.ObtenirListeEmploye()[index].Actif = cbxActif.Checked;
                    unePharmacie.ObtenirListeEmploye()[index].Poste = edtPoste.Text;
                    unePharmacie.ObtenirListeEmploye()[index].DateEmbauche = dtpDateEmbauche.Value;
                    InitialiserListeEmploye(compteurEmploye);
                }
            }


        }
        /// <summary>
        /// Évenement se déclenchant au click du bouton Vider liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (unePharmacie.ViderListeEmploye() == false)
            {
                MessageBox.Show("Il n'y a aucun employé dans la liste");
            }
            unePharmacie.ViderListeEmploye();
            InitialiserListeEmploye(compteurEmploye);
        }
        /// <summary>
        /// Méthode permettant de érafficher le listbox
        /// </summary>
        /// <param name="compteurEmploye">Compteur contenant le nombre d'employés</param>
        /// <returns></returns>
        public int InitialiserListeEmploye(int compteurEmploye)
        {
            lbxEmploye.Items.Clear();
            compteurEmploye = 0;
            foreach (Employe employe in unePharmacie.ObtenirListeEmploye())
            {
                compteurEmploye++;
                lbxEmploye.Items.Add(compteurEmploye.ToString() + "- " + employe.ToString());
            }
            return (compteurEmploye);
        }
        /// <summary>
        /// Permet de supprimer l'employé sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerEmploye_Click(object sender, EventArgs e)
        {
            try
            {
                unePharmacie.EnleverEmploye(unePharmacie.ObtenirListeEmploye()[lbxEmploye.SelectedIndex]);
                InitialiserListeEmploye(compteurEmploye);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur dans la sélection.");
            }

        }
        /// <summary>
        /// Permet de retirer l'employé avec le nombre mentionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirer_Click(object sender, EventArgs e)
        {
            try
            {
                int nombreARetirer;
                nombreARetirer = int.Parse(edtEmployeARetirer.Text);
                unePharmacie.EnleverEmploye(unePharmacie.ObtenirListeEmploye()[nombreARetirer - 1]);
                InitialiserListeEmploye(compteurEmploye);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de sélection.");
            }

        }

        private void btnPremierEmploye_Click(object sender, EventArgs e)
        {
            lbxEmploye.SelectedIndex = 0;
        }
        /// <summary>
        /// Permet de changer tous les champs d'édition lorsqu'un employé est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Employe[] tableauEmploye;
                index = lbxEmploye.SelectedIndex;
                tableauEmploye = unePharmacie.ObtenirListeEmploye();
                edtPrenomEmploye.Text = tableauEmploye[index].Prenom;
                edtNomEmploye.Text = tableauEmploye[index].Nom;
                edtAdresseEmploye.Text = tableauEmploye[index].Adresse;
                edtVilleEmploye.Text = tableauEmploye[index].Ville;
                edtProvinceEmploye.Text = tableauEmploye[index].Province;
                edtCodePostalEmploye.Text = tableauEmploye[index].CodePostal;
                edtTelephoneEmploye.Text = tableauEmploye[index].Telephone;
                edtCourrielEmploye.Text = tableauEmploye[index].Courriel;
                edtNumeroEmploye.Text = tableauEmploye[index].NumeroEmploye.ToString();
                edtNas.Text = tableauEmploye[index].Nas.ToString();
                edtPoste.Text = tableauEmploye[index].Poste;
                cbxActif.Checked = tableauEmploye[index].Actif;
                dtpDateEmbauche.Value = tableauEmploye[index].DateEmbauche;

            }
            catch (Exception)
            {

                MessageBox.Show("Erreur de sélection");
            }
        }
        /// <summary>
        /// Affiche l'employé précédent du Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (lbxEmploye.SelectedIndex == 0)
            {
                lbxEmploye.SelectedIndex = unePharmacie.ObtenirNombreEmploye() - 1;
            }
            else
            {
                index = lbxEmploye.SelectedIndex - 1;
                lbxEmploye.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Affiche l'employé suivant du Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (lbxEmploye.SelectedIndex == unePharmacie.ObtenirNombreEmploye() - 1)
            {
                lbxEmploye.SelectedIndex = 0;
            }
            else
            {
                index = lbxEmploye.SelectedIndex + 1;
                lbxEmploye.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Affiche le dernier employé du Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDernier_Click(object sender, EventArgs e)
        {
            lbxEmploye.SelectedIndex = unePharmacie.ObtenirNombreEmploye() - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Action qui se produit au changement de l'index du combobox, changeant le panel affiché à l'écran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                panelPharmacie.Visible = false;
                panelEmploye.Visible = false;
                panelPrescription.Visible = false;
                this.Width = 200;
                this.Height = 100;
            }
            else
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    panelEmploye.Visible = false;
                    panelPharmacie.Visible = true;
                    panelPrescription.Visible = false;
                    this.Width = 339;
                    this.Height = 420;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 2)
                    {
                        panelEmploye.Visible = true;
                        panelPharmacie.Visible = false;
                        panelPrescription.Visible = false;
                        this.Width = 610;
                        this.Height = 460;
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex==3)
                        {
                            panelPrescription.Visible = true;
                            panelPharmacie.Visible = false;
                            panelEmploye.Visible = false;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Méthode qui change la grandeur de la fenêtre à l'ouverture, et exécute la méthode OuvrirFichier()
        /// </summary>
        private void OuvrirApplication()
        {
            this.Width = 200;
            this.Height = 100;
            OuvrirFichier();
        }
    }
}
