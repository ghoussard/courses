using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD
{
    public partial class Form1 : Form
    {
        private List<int> lesId = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirListeContacts(BDD.lireContacts());

        }

        private void remplirListeContacts(List<Contact> lc)
        {
            contactListBox.Items.Clear();
            lesId.Clear();

            //contactListBox.Items.AddRange(lc.ToArray());

            foreach (Contact c in lc)
            {
                lesId.Add(c.Id);
                contactListBox.Items.Add(c.ToString());
            }
        }

        private void contactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex < 0)
            {
                //déselection
                nomTextBox.Text = null;
                prenomTextBox.Text = null;
                telephoneTextBox.Text = null;
            } else
            {
                //sélection
                int id = lesId[contactListBox.SelectedIndex];
                Contact c = BDD.lireContact(id);
                nomTextBox.Text = c.Nom;
                prenomTextBox.Text = c.Prenom;
                telephoneTextBox.Text = c.Téléphone;
            }


        }
    }
}
