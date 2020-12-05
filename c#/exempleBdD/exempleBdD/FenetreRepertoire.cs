using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exempleBdD
{
    public partial class FenetreRepertoire : Form
    {
        private List<int> lesId = new List<int>();
        public FenetreRepertoire() {
            InitializeComponent();
        }
        private void remplirListeContacts(List<Contact> lc) {
            lstIdentite.Items.Clear();
            lesId.Clear();
            foreach (Contact c in lc) {
                lstIdentite.Items.Add(c.Nom + " " + c.Prenom);
                lesId.Add(c.Id);
            }
        }
        private void mettreAJourListe() {
            List<Contact> lc = BdD.lireContacts(); //appel du modèle
            remplirListeContacts(lc); // appel de la vue
            lc.Clear();
        }
        private void modifierDetails(String nom, String prenom, String telephone)
        {
            txtNom.Text = nom;
            txtPren.Text = prenom;
            txtTel.Text = telephone;
        }
        private void effacerDetails()
        {
            txtNom.Text = "";
            txtPren.Text = "";
            txtTel.Text = "";
        }
        private void activerModifierSupprimer()
        {
            modifierButton.Enabled = true;
            supprimerButton.Enabled = true;
            actionsLabel.Visible = false;
        }
        private void desactiverModifierSupprimer()
        {
            modifierButton.Enabled = false;
            supprimerButton.Enabled = false;
            actionsLabel.Visible = true;
        }
        private void afficherFormulaireContact(Contact contact)
        {
            FormulaireContact formulaireContact = new FormulaireContact(contact);

            DialogResult result = formulaireContact.ShowDialog();

            if (result == DialogResult.OK)
            {
                mettreAJourListe();
                if (!formulaireContact.Ajout)
                {
                    //on selectionne le contact mis à jour dans la liste
                    Contact contactMisAJour = BdD.lireContact(contact.Id);
                    if(contactMisAJour != null) lstIdentite.SelectedIndex = lesId.IndexOf(contactMisAJour.Id);
                } else
                {
                    //on selectionne le nouveau contact dans le liste
                    lstIdentite.SelectedIndex = lesId.IndexOf(BdD.lireDernierIdDeContactCrée());
                }       
            }
            else if (result == DialogResult.Abort)
            {
                MessageBox.Show(
                    "Le contact n'a pas pu être " + (formulaireContact.Ajout ? "crée" : "mis à jour"), 
                    "Erreur", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
               );
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            mettreAJourListe();
        }
        private void lstIdentite_SelectedIndexChanged(object sender, EventArgs e) {
            int numero = lstIdentite.SelectedIndex;
            effacerDetails();
            if (numero >= 0) {
                int id = lesId[numero];
                Contact c = BdD.lireContact(id);
                if (c != null) {
                    modifierDetails(c.Nom, c.Prenom, c.Telephone);
                    activerModifierSupprimer();
                }
            } else
            {
                desactiverModifierSupprimer();
            }
        }
        private void btAjouter_Click(object sender, EventArgs e) {
            afficherFormulaireContact(null);
        }
        private void modifierButton_Click(object sender, EventArgs e)
        {
            if (lstIdentite.SelectedIndex < 0) return;
            int contactId = lesId[lstIdentite.SelectedIndex];
            Contact contact = BdD.lireContact(contactId);
            afficherFormulaireContact(contact);
        }
        private void supprimerButton_Click(object sender, EventArgs e)
        {

            if (lstIdentite.SelectedIndex < 0) return;

            if (MessageBox.Show(
                    "Souhaitez-vous supprimer " + txtNom.Text + " " + txtPren.Text + " du répertoire ?",
                    "Supprimer un contact",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                ) == DialogResult.OK
            )
            {
                int contactId = lesId[lstIdentite.SelectedIndex];
                BdD.supprimerContact(contactId);
                mettreAJourListe();
                effacerDetails();
                desactiverModifierSupprimer();
            }
        }
    }
}
