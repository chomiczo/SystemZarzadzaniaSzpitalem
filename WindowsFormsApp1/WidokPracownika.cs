using BibliotekaKlas;

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
    // Formularz z danymi pracownika
    public partial class WidokPracownika : UserControl, IWidok
    {
        Main parent;

        public WidokPracownika(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void Odswiez()
        {
            // Sprawdza, czy w okienku głównym jest ustawiony jakiś pracownik
            Pracownik wybrany = parent.WybranyPracownik;



            // Jeżeli nie, to resetuje pola formularza i ukrywamy pola
            // przeznaczone dla lekarza.
            if (wybrany == null)
            {
                tbImie.Text = "";
                tbNazwisko.Text = "";
                tbPesel.Text = "";
                tbLogin.Text = "";
                tbHaslo.Text = "";
                cbSpecjalnosc.Text = "";
                cbTypKonta.Text = "";

                gbSzczegoly.Hide();
            }
            else
            {
                // Jeżeli edytuje istniejącego pracownika, to uzupełnia
                // formularz jego danymi.
                tbImie.Text = wybrany.Imie;
                tbNazwisko.Text = wybrany.Nazwisko;
                tbPesel.Text = wybrany.Pesel;
                tbLogin.Text = wybrany.Login;
                tbHaslo.Text = wybrany.Haslo;
                tbPesel.Text = wybrany.Pesel;
                cbTypKonta.Text = wybrany.TypKonta;

                // Ponadto, jeżeli jest to lekarz, to pokazuje jeszcze
                // pola odpowiednie dla lekarza.
                if (wybrany.TypKonta == "Lekarz")
                {
                    tbPWZ.Text = ((Lekarz)wybrany).NrPWZ;
                    cbSpecjalnosc.Text = ((Lekarz)wybrany).Specjalnosc;
                    gbSzczegoly.Show();
                } else {
                    gbSzczegoly.Hide();
                }
            }
        }

        // Reaguje na zmianę typu konta.
        // Pokazuje lub ukrywamy pola przeznaczone dla lekarza.
        private void cbTypKonta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypKonta.Text == "Lekarz")
            {
                gbSzczegoly.Show();
            }
            else
            {
                gbSzczegoly.Hide();
            }
        }

        // Po kliknięciu "Anuluj", wraca do widoku głównego.
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            parent.PokazWidokGlowny();
        }

        // Po kliknnięciu "Zapisz" albo dodaje, albo aktualizuje użytkownika.
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (parent.WybranyPracownik == null)
            {
                parent.DodajPracownika(cbTypKonta.Text, tbImie.Text, tbNazwisko.Text, tbPesel.Text, tbLogin.Text, tbHaslo.Text, cbSpecjalnosc.Text, tbPWZ.Text);
            }
            else
            {
                parent.AktualizujPracownika(cbTypKonta.Text, tbImie.Text, tbNazwisko.Text, tbPesel.Text, tbLogin.Text, tbHaslo.Text, cbSpecjalnosc.Text, tbPWZ.Text);
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbPesel_KeyPress(object sender, KeyPressEventArgs e)
         {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Proszę podać liczbę, a nie literę.");
            }
        }
        
        private void tbPWZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Proszę podać liczbę, a nie literę.");
            }
        }
    }
}
