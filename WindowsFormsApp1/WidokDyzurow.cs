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
    // Klasa widoku dyżurów danego pracownika
    // dziedzicząca po klasie UserControl
    // i implementująca interfejs IWidok.
    public partial class WidokDyzurow : UserControl, IWidok
    {
        // Odwołanie do okienka głównego.
        Main parent;

        // Lista dyżurów danego pracownika (jako pole klasy, bo jest używana
        // pomiędzy metodami).
        List<DateTime> dyzury = null;

        public WidokDyzurow(Main parent)
        {
            InitializeComponent();

            // Ustawia odwołanie do głównego okienka.
            this.parent = parent;
        }

        // Metoda odświeżająca widok
        public void Odswiez()
        {
            // Definiuje sobie zmienną, żeby się za dużo nie napisać.
            Pracownik wybrany = parent.WybranyPracownik;

            // Ustawiamy tytułowy label na imię i nazwisko pracownika
            lblTytul.Text = $"{wybrany.Imie} {wybrany.Nazwisko}";

            // Czyści listę (w sensie kontrolkę z listą) z dyżurami
            lvDyzury.Clear();

            // W zależności od rodzaju pracownika pobieramy listę dyżurów w
            // wybranym miesiącu
            if (wybrany.TypKonta == "Lekarz")
            {
                dyzury = ((Lekarz)parent.WybranyPracownik).DyzuryWMiesiacu(dtpMiesiac.Value);
            }
            else if (wybrany.TypKonta == "Pielęgniarka")
                dyzury = ((Pielegniarka)parent.WybranyPracownik).DyzuryWMiesiacu(dtpMiesiac.Value);
            {
            }

            // Uzupełnia kontrolkę z listą na podstawie listy pobranej z bazy.
            foreach (var dyzur in dyzury)
            {
                lvDyzury.Items.Add($"{dyzur.Day}.{dyzur.Month}.{dyzur.Year}");
            }

            // Jeżeli zalogowany użytkownik jest administratorem, to daje
            // mu możliwość kliknięcia w przyciski odpowiedzialne za modyfikacje.
            // Jeżeli nie, to zabiera tę możliwość.
            bool czyAdmin = parent.ZalogowanyPracownik.TypKonta == "Administrator";
            btnDodaj.Enabled = czyAdmin;
            btnUsun.Enabled = czyAdmin;
            dtpNowyDyzur.Enabled = czyAdmin;
        }

        // Po kliknięciu "Wróć', wraca do głównej listy.
        private void btnWroc_Click(object sender, EventArgs e)
        {
            parent.PokazWidokGlowny();
        }

        // Po kliknięciu "Dodaj", dodaje dyżur.
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            parent.DodajDyzur(dtpNowyDyzur.Value);
        }

        // Po zmianie wartości w kontrolce z wyborem miesiąca musi
        // odświeżyć listę.
        private void dtpMiesiac_ValueChanged(object sender, EventArgs e)
        {
            Odswiez();
        }

        // Po kliknięciu "Usuń", próbuje usunąć zaznaczone dyżury.
        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (lvDyzury.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano zadnego dyzuru.");
                return;
            }

            // Robi nową listę z zaznaczonymi dyżurami
            var doUsuniecia = new List<DateTime>();
            foreach (int index in lvDyzury.SelectedIndices)
            {
                doUsuniecia.Add(dyzury[index]);
            }

            // I przekazuje ją do metody z głównego okienka.
            parent.UsunDyzury(doUsuniecia);
        }
    }
}
