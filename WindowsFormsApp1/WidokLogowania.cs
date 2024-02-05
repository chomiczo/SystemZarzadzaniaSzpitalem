using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzpitalGUI
{
    public partial class WidokLogowania : UserControl, IWidok
    {
        Main parent;

        public WidokLogowania(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            parent.Zaloguj(tbNazwaUzytkownika.Text, tbHaslo.Text);
        }

        public void Odswiez()
        {
            tbHaslo.Text = "";
            tbNazwaUzytkownika.Text = "";
        }

        // Tu reaguje na zdarzenie wciśnięcia klawisza na klawiaturze
        private void tbHaslo_KeyDown(object sender, KeyEventArgs e)
        {
            // Jeżeli kliknęliśmy enter, to "klikamy" przycisk zaloguj.
            // Takie o, ułatwienie.
            if (e.KeyCode == Keys.Enter)
            {
                btnZaloguj_Click(sender, e);
            }
        }

    }
}
