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
    public partial class FormulaireContact : Form
    {
        private Contact _contact;

        public bool Ajout
        {
            get => _contact == null;
        }

        public FormulaireContact()
        {
            InitializeComponent();
        }

        public FormulaireContact(Contact contact)
        {
            InitializeComponent();
            _contact = contact;
        }
        private void validerButton_Click(object sender, EventArgs e)
        {
            String nom = nomTextBox.Text.Trim();
            if (nom.Length == 0)
            {
                MessageBox.Show(
                    "Le champ Nom ne peut pas être vide", 
                    "Erreur", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                );
            } else
            {
                String prenom = prenomTextBox.Text.Trim();
                String telephone = telephoneTextBox.Text.Trim();

                bool operationReussie;                
                if(Ajout)
                {
                    operationReussie = BdD.ajouterContact(nom, prenom, telephone);
                } else
                {
                    operationReussie = BdD.modifierContact(_contact.Id, nom, prenom, telephone);
                }

                if(operationReussie)
                {
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    this.DialogResult = DialogResult.Abort;
                }

                Close();
            }
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormulaireContact_Load(object sender, EventArgs e)
        {
            String action;

            if(Ajout)
            {
                action = "Ajouter";
            } else
            {
                action = "Modifier";
                nomTextBox.Text = _contact.Nom;
                prenomTextBox.Text = _contact.Prenom;
                telephoneTextBox.Text = _contact.Telephone;
            }

            validerButton.Text = action;
            this.Text = action + " un contact";
        }
    }
}
