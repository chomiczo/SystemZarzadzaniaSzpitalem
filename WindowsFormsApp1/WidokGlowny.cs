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
    // Widok listy pracowników
    public partial class WidokGlowny : UserControl, IWidok
    {
        // Odwołanie do głównego okienka
        private Main parent;

        public WidokGlowny(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void Odswiez()
        {
            Pracownik zalogowany = parent.ZalogowanyPracownik;
            lblLogin.Text = $"{zalogowany.Imie} {zalogowany.Nazwisko} ({zalogowany.Login})";

            bool czyAdmin = (zalogowany.TypKonta == "Administrator");
            btnDodaj.Enabled = czyAdmin;
            btnEdytuj.Enabled = czyAdmin;
            btnUsun.Enabled = czyAdmin;

            lvPracownicy.Items.Clear();
            foreach (var pracownik in parent.PobierzPracownikow())
            {
                string[] items = {
                    pracownik.Imie,
                    pracownik.Nazwisko,
                    pracownik.TypKonta,
                    pracownik.TypKonta == "Lekarz" ? ((Lekarz) pracownik).Specjalnosc : ""
                };
                lvPracownicy.Items.Add(new ListViewItem(items));
            }
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            parent.Wyloguj();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            parent.NowyPracownik();
        }

        // Metoda sprawdzająca, czy zaznaczenie jest prawidłowe.
        // Wywoływana trzy razy, więc wydzielona do osobnej metody.
        private bool zaznaczeniePrawidlowe()
        {
            if (lvPracownicy.SelectedItems.Count < 1)
            {
                MessageBox.Show("Nie wybrano żadnego pracownika.", "Błąd");
                return false;
            }
            return true;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (zaznaczeniePrawidlowe())
            {
                // Ponieważ zawsze wyświetla wszystkich użytkowników, to
                // indeksy z kontrolki powinny się zgadzać z indeksami w bazie.
                // Gdyby tak nie było, to musielibyśmy troszkę bardziej
                // skomplikować program.
                // Inni userzy i tak nie mają możliwości modyfikacji
                parent.EdytujPracownika(lvPracownicy.SelectedItems[0].Index);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (zaznaczeniePrawidlowe())
            {
                parent.UsunPracownika(lvPracownicy.SelectedItems[0].Index);
            }
        }

        private void btnDyzury_Click(object sender, EventArgs e)
        {
            if (zaznaczeniePrawidlowe())
            {
                parent.PokazDyzury(lvPracownicy.SelectedItems[0].Index);
            }
        }
    }
}
