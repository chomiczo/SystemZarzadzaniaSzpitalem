using System;
using System.Collections.Generic;

namespace BibliotekaKlas
{
    // Klasa reprezentująca konto lekarza, dziedzicząca po klasie Pracownik.
    public class Lekarz : Pracownik
    {
        public string Specjalnosc { get; set; }
        public string NrPWZ { get; set; }
        private List<DateTime> dyzury;
        public List<DateTime> Dyzury { get { return dyzury; }  }

        // Konstruktor bez argumentów dla zgodności z klasą XmlSerializer.
        private Lekarz()
        {
            dyzury = new List<DateTime>();
        }

        // Konstruktor wypełniający pola klasy.
        // Wywoływany jest uprzednio konstruktor klasy bazowej Pracownik
        // (: base(...))
        public Lekarz(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo, string specjalnosc, string nrPWZ)
            : base(imie, nazwisko, pesel, nazwaUzytkownika, haslo, "Lekarz")
        {
            Specjalnosc = specjalnosc;
            dyzury = new List<DateTime>();
            NrPWZ = nrPWZ;
        }

        // Metoda dodająca dyżur do konta lekarza.
        public void DodajDyzur(DateTime data)
        {
            dyzury.Add(data);
        }

        // Metoda usuwająca dane dyżury z konta.
        public void UsunDyzury(List<DateTime> dyzury)
        {
            foreach (var data in dyzury)
            {
                this.dyzury.Remove(data);
            }
        }

        // Metoda zwracająca wszystkie dyżury lekarza w danym miesiącu.
        public List<DateTime> DyzuryWMiesiacu(DateTime miesiac)
        {
            List<DateTime> wynik = new List<DateTime>();

            foreach (DateTime dyzur in dyzury)
            {
                // Wystarczy nam miesiąc i rok
                if (dyzur.Year == miesiac.Year && dyzur.Month == miesiac.Month)
                {
                    wynik.Add(dyzur);
                }
            }

            // Sortuje wynikową listę, żeby było ładnie i się nie mieszało
            // w widoku.
            wynik.Sort();

            return wynik;
        }
    }
}
