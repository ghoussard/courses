using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!BDD.connexion())
            {
                MessageBox.Show(
                    "Impossible de se connecter à la base de données.", 
                    "BDD - Erreur critique", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            BDD.deconnexion();
        }
    }
}
