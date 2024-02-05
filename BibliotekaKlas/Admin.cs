namespace BibliotekaKlas
{
    public class Admin : Pracownik
    {
        // Konstruktor bez parametrów wymagany przy (de)serializacji XML
        // ponieważ XmlSerializer najpierw musi stworzyć sobie obiekt, zeby go
        // zapełnić.
        // To samo tyczy się pozostałych klas pracowników.
        // Konstruktor ten nie musi być publiczny, więc skoro nie musi, to jest
        // prywatny.
        private Admin() { }

        // Konstruktor wypełniający wszystkie pola. Wywołuje on też najpierw
        // konstruktor klasy bazowej (base).
        // Ponieważ klasa Admin nie ma żadnych dodatkowych pól, to wypełnia
        // tylko pola klasy bazowej.
        public Admin(string imie, string nazwisko, string pesel, string nazwa_uzytkownika, string haslo)
            : base(imie, nazwisko, pesel, nazwa_uzytkownika, haslo, "Administrator")
        {
        }

        // Te dwa konstruktory tworzą dobry przykład na:
        // * Hermetyzacje (private, public)
        // * Polimorfizm (ta sama nazwa - to, który bedzie wywolany zalezy od argumentow)
    }
}
