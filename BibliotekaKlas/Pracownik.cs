using System;

namespace BibliotekaKlas
{
    // Klasa bazowa dla pracowników - po niej dziedziczą Admin, Pielegniarka i
    // Lekarz.
    public class Pracownik
    {
        public string Pesel { get; set; }
        public string Haslo { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string TypKonta { get; set; }
        public string Login { get; set; }

        // Konstruktor bez argumentów dla klasy XmlSerializer.
        // Nie jest on wywoływany bezpośrednio, ale jest wywoływany przez klasy
        // potomne przy (de)serializacji.
        // Nie może być prywatny tak jak w klasach potomnych, bo nie miałyby
        // do niego dostępu. Żeby mogły go wywoływać klasy potomne, ale żadne
        // zewnętrzne, to ustawiamy protected.
        protected Pracownik() { }

        // Z tego konstruktora będą korzystać tylko klasy potomne, więc też
        // ustawiony jest na protected.
        protected Pracownik(string imie, string nazwisko, string pesel, string login, string haslo, string typKonta)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Login = login;
            Haslo = haslo;
            TypKonta = typKonta;
        }

        // Metoda sprawdzająca, czy podane hasło się zgadza z hasłem użytkownika.
        public bool SprawdzHaslo(string haslo)
        {
            return haslo == this.Haslo;
        }
    }
}
