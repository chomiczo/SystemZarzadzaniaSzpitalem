using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BibliotekaKlas;

namespace SzpitalGUI
{
    // Główne okienko programu
    public partial class Main : Form
    {
        // Nazwa pliku z bazą danych.
        public const string BAZA_PLIK = "baza.xml";

        // Obiekt z bazą pracowników
        private BazaPracownikow bazaPracownikow;

        // Odniesienie do zalogowanego użytkownika
        // i pracownika wybranego z listy pracowników.
        public Pracownik ZalogowanyPracownik { get; private set; }
        public Pracownik WybranyPracownik { get; private set; }

        // Obiekty z konkretnymi widokami do wyświetlenia.
        private IWidok widokLogowania;
        private IWidok widokGlowny;
        private IWidok widokDyzurow;
        private IWidok widokPracownika;

        public Main()
        {
            InitializeComponent();

            // Tworzymy bazę pracowników
            bazaPracownikow = new BazaPracownikow();

            // Jeżeli plik z istniejącą bazą istnieje, to go wczyta.
            if (File.Exists(BAZA_PLIK))
            {
                bazaPracownikow.Wczytaj(BAZA_PLIK);
            }
            else
            {
                // Jeżeli plik z bazą nie istnieje, to tworzymy domyślnego
                // administratora i zapisujemy go do pliku.
                Admin admin = new Admin("Administrator", "Systemu", "123456789", "admin", "admin");
                bazaPracownikow.DodajPracownika(admin);
                bazaPracownikow.Zapisz(BAZA_PLIK);
            }

            // Inicjalizacja konkretynych widoków przekazując do nich obiekt
            // głównego okna, żeby widoki szczegółowe mogły się do niego
            // odwoływać.
            widokLogowania = new WidokLogowania(this);
            widokGlowny = new WidokGlowny(this);
            widokDyzurow = new WidokDyzurow(this);
            widokPracownika = new WidokPracownika(this);

            // Na razie nikt nie jest zalogowany, więc ustawia sie zalogowanego
            // użytkownika na ŻADNEGO i przełącza widok na ekran logowania.
            ZalogowanyPracownik = null;
            przelaczWidok(widokLogowania);
        }

        // Metoda ustawiająca widok na któryś z konkretnych widoków.
        private void przelaczWidok(IWidok widok)
        {
            // Czyści okienko z wszelkich kontrolek, które się w nim znajdują.
            Controls.Clear();
            // Dodaje widok do kontrolek w głównym okienku.
            Controls.Add((UserControl) widok);
            // Ponieważ widok implementuje interfejs IWidok, to można wywołać
            // metodę Odswiez.
            widok.Odswiez();
        }

        // Metoda przeprowadzająca logowanie użytkownika.
        public void Zaloguj(string nazwaUzytkownika, string haslo)
        {
            // Najpierw szuka pracownika o danym loginie.
            Pracownik pracownik = bazaPracownikow.ZnajdzPracownika(nazwaUzytkownika);

            // Jeżeli takiego nie znajdzie, to pokazuje okienko z błędem
            // i wychodzi.
            if (pracownik == null)
            {
                MessageBox.Show("Błędne dane logowania.", "Błąd");
                return;
            }

            // Sprawdza, czy podane hasło się zgadza z hasłem użytkownika.
            if (pracownik.SprawdzHaslo(haslo))
            {
                // Jeżeli się zgadza, to ustawia zalogowanego użytkownika
                // na tego, którego znajdzie i przełącza widok na główną
                // listę.
                ZalogowanyPracownik = pracownik;
                przelaczWidok(widokGlowny);
                return;
            }

            // Jeżeli się nie zgadza, to wyświetlamy błąd.
            MessageBox.Show("Błędne dane logowania.", "Błąd");
        }

        // Metoda wylogowująca użytkownika.
        public void Wyloguj()
        {
            ZalogowanyPracownik = null;
            przelaczWidok(widokLogowania);
        }

        // Reakcja na zdarzenie zamknięcia okna.
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Przy zamknięciu okna zapisujemy stan bazy do pliku.
            bazaPracownikow.Zapisz(BAZA_PLIK);
        }

        // Metoda pobierająca listę pracowników z bazy.
        public List<Pracownik> PobierzPracownikow()
        {
            return bazaPracownikow.Pracownicy;
        }

        // Metoda przełączająca na formularz dodawania/edycji pracownika.
        public void NowyPracownik()
        {
            // Ponieważ wybrany pracownik ustawiany jest na null, to po
            // zatwierdzeniu formularza pracownik będzie tworzony od nowa.
            WybranyPracownik = null;
            przelaczWidok(widokPracownika);
        }

        // Metoda przełączająca na formularz dodawania/edycji pracownika.
        public void EdytujPracownika(int index)
        {
            // Ponieważ pracownik jest ustawiany na konkretnego użytkownika
            // z listy, to po zatwierdzeniu formularza, pracownik będzie
            // modyfikowany.
            WybranyPracownik = bazaPracownikow.Pracownicy[index];
            przelaczWidok(widokPracownika);
        }

        // Metoda przełączająca widok na listę pracowników.
        public void PokazWidokGlowny()
        {
            przelaczWidok(widokGlowny);
        }

        // Metoda dodająca pracownika do bazy.
        public void DodajPracownika(string typKonta, string imie, string nazwisko, string pesel, string login, string haslo, string specjalnosc, string nrPWZ)
        {
            string komunikatBledu = null;

            // Sprawdza typ konta i na jego podstawie tworzy obiekt
            // pracownika odpowiedniej klasy i dodaje go do bazy.
            switch (typKonta)
            {
                case "Administrator":
                    komunikatBledu = bazaPracownikow.DodajPracownika(new Admin(imie, nazwisko, pesel, login, haslo));
                    break;
                case "Lekarz":
                    komunikatBledu = bazaPracownikow.DodajPracownika(new Lekarz(imie, nazwisko, pesel, login, haslo, specjalnosc, nrPWZ));
                    break;
                case "Pielęgniarka":
                    komunikatBledu = bazaPracownikow.DodajPracownika(new Pielegniarka(imie, nazwisko, pesel, login, haslo));
                    break;
                default:
                    komunikatBledu = "Nieznany rodzaj konta.";
                    break;
            }
            
            if (komunikatBledu != null)
            {
                MessageBox.Show(komunikatBledu, "Blad");
                return;
            }
            PokazWidokGlowny();
        }

        // Metoda modyfikująca wybranego pracownika.
        public void AktualizujPracownika(string typKonta, string imie, string nazwisko, string pesel, string login, string haslo, string specjalnosc, string nrPWZ)
        {
            if (WybranyPracownik == null)
            {
                MessageBox.Show("Nie wybrano pracownika", "Błąd");
                return;
            }

            // Usuwa wybranego pracownika i dodaje nowego ze zmodyfikowanymi
            // danymi.
            bazaPracownikow.UsunPracownika(WybranyPracownik);
            WybranyPracownik = null;
            DodajPracownika(typKonta, imie, nazwisko, pesel, login, haslo, specjalnosc, nrPWZ);
        }

        // Metoda usuwająca pracownika z bazy.
        public void UsunPracownika(int index)
        {
            bazaPracownikow.UsunPracownika(bazaPracownikow.Pracownicy[index]);
            PokazWidokGlowny();
        }

        // Metoda przełączająca widok na widok dyżurów danego pracownika.
        public void PokazDyzury(int index)
        {
            WybranyPracownik = bazaPracownikow.Pracownicy[index];
            if (WybranyPracownik.TypKonta == "Administrator")
            {
                MessageBox.Show("Administratorzy nie mają dyżurów.", "Błąd");
                return;
            }
            przelaczWidok(widokDyzurow);
        }

        // Metoda dodająca dyżur do konta danego pracownika
        public void DodajDyzur(DateTime data)
        {
            string komunikatBledu = bazaPracownikow.DodajDyzur(WybranyPracownik, data);
            if (komunikatBledu == null)
            {
                widokDyzurow.Odswiez();
            }
            else
            {
                MessageBox.Show(komunikatBledu, "Błąd");
            }
        }

        // Metoda usuwająca dyżury z konta danego pracownika.
        public void UsunDyzury(List<DateTime> dyzury)
        {
            string komunikatBledu = bazaPracownikow.UsunDyzury(WybranyPracownik, dyzury);
            if (komunikatBledu == null)
            {
                widokDyzurow.Odswiez();
            }
            else
            {
                MessageBox.Show(komunikatBledu, "Błąd");
            }
        }
    }
}
