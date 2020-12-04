using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    class ListViewItemPersonne : System.Windows.Forms.ListViewItem
    {
        private Personne qui;
        public ListViewItemPersonne(Personne p) : base() {
            qui = p;
            Text = p.ToString();
        }
        public Personne Qui {
            get { return qui; }
        }
    }
}
