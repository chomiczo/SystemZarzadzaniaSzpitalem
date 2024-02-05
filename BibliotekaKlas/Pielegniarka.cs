using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace BibliotekaKlas
{
    // Klasa reprezentująca pielęgniarkę. W zasadzie to samo, co Lekarz, tylko
    // nie ma pól ze specjalizacją i numerem PWZ.
    public class Pielegniarka : Pracownik
    {
        private List<DateTime> dyzury;

        private Pielegniarka()
        {
            dyzury = new List<DateTime>();
        }

        public Pielegniarka(string imie, string nazwisko, string pesel, string nazwa_uzytkownika, string haslo)
            : base(imie, nazwisko, pesel, nazwa_uzytkownika, haslo, "Pielęgniarka")
        {
            dyzury = new List<DateTime>();
        }

        public void DodajDyzur(DateTime data)
        {
            dyzury.Add(data);
        }

        public void UsunDyzury(List<DateTime> dyzury)
        {
            foreach (var data in dyzury)
            {
                this.dyzury.Remove(data);
            }
        }

        public List<DateTime> DyzuryWMiesiacu(DateTime miesiac)
        {
            List<DateTime> wynik = new List<DateTime>();

            foreach (DateTime dyzur in dyzury)
            {
                if (dyzur.Year == miesiac.Year && dyzur.Month == miesiac.Month)
                {
                    wynik.Add(dyzur);
                }
            }
            return wynik;
        }
    }
}
