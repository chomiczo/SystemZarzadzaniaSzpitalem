using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BibliotekaKlas
{
    // Klasa pomocnicza do reprezentacji XML. Jest to osobna klasa, bo tak po
    // prostu było łatwiej.
    // Nie można np. serializować listy elementów ogólnego typu Pracownik, bo
    // serializer nie ogarnia wtedy, że trzeba serializować również pola z
    // klas dziedziczących. Tutaj lista ta jest rozdzielana na trzy osobne.
    public class BazaPracownikowXML
    {
        public List<Admin> Administratorzy { get; set; }
        public List<Lekarz> Lekarze { get; set; }
        public List<Pielegniarka> Pielegniarki { get; set; }

        // Konstruktor bez argumentów (dla zgodności z klasą XmlSerializer).
        public BazaPracownikowXML()
        {
            Administratorzy = new List<Admin>();
            Lekarze = new List<Lekarz>();
            Pielegniarki = new List<Pielegniarka>();
        }

        // Konstruktor do tworzenia klasy na podstawie obiektu typu
        // BazaPracownikow. Żeby kod się nie powtarzał, to inicjalizacja list
        // jest wykonywana w pierwszym konstruktorze (: this()).
        public BazaPracownikowXML(BazaPracownikow baza) : this()
        {
            // Dla każdego pracownika na podstawie jego typu konta,
            // przydzielany jest on do odpowiedniej listy po uprzednim
            // zrzutowaniu na odpowiednią klasę potomną (pracownik as Lekarz).
            foreach (var pracownik in baza.Pracownicy)
            {
                switch(pracownik.TypKonta)
                {
                    case "Administrator":
                        Administratorzy.Add(pracownik as Admin);
                        break;
                    case "Pielęgniarka":
                        Pielegniarki.Add(pracownik as Pielegniarka);
                        break;
                    case "Lekarz":
                        Lekarze.Add(pracownik as Lekarz);
                        break;
                }
            }
        }

        // Funkcja zwracająca połączoną listę pracowników zebranych po
        // deserializacji z trzech list. Tutaj rzutowanie na klasę bazową nie
        // jest wymagane.
        public List<Pracownik> Pracownicy()
        {
            var pracownicy = new List<Pracownik>();
            foreach (var admin in Administratorzy)
            {
                pracownicy.Add(admin);
            }
            foreach (var lekarz in Lekarze)
            {
                pracownicy.Add(lekarz);
            }
            foreach (var pielegniarka in Pielegniarki)
            {
                pracownicy.Add(pielegniarka);
            }
            return pracownicy;
        }
    }

    // Klasa reprezentująca bazę wszystkich pracowników i pozwalająca
    // wykonywać operacje na całej bazie.
    public class BazaPracownikow
    {
        private List<Pracownik> pracownicy;
        public List<Pracownik> Pracownicy { get { return pracownicy; } }

        // Konstruktor nowej bazy.
        public BazaPracownikow()
        {
            pracownicy = new List<Pracownik>();
        }

        // Metoda zapisująca bazę do pliku XML.
        public void Zapisz(string nazwaPliku)
        {
            using (var sw = new StreamWriter(nazwaPliku))
            {
                // Tworzy klasę pomocniczą na podstawie tej bazy.
                BazaPracownikowXML bpxml = new BazaPracownikowXML(this);
                // Tworzy serializer
                XmlSerializer xs = new XmlSerializer(bpxml.GetType());
                // Serializuje
                xs.Serialize(sw, bpxml);
            }
        }

        // Metoda wczytująca pracowników z pliku XML.
        public void Wczytaj(string nazwaPliku)
        {
            using (var sr = new StreamReader(nazwaPliku))
            {
                // Tworzy obiekt pomocniczy (ale tylko po to, żeby móc użyć
                // metody GetType()).
                var bpxml = new BazaPracownikowXML(this);
                XmlSerializer xs = new XmlSerializer(bpxml.GetType());
                // Deserializuje. Deserialize zwraca zdeserializowany obiekt
                // ale musi go jeszcze zrzutować na BazaPracownikowXML, bo
                // Deserialize zwraca typ object.
                bpxml = xs.Deserialize(sr) as BazaPracownikowXML;
                // Ustawia listę pracowników na pracowników ze
                // zdeserializowanego obiektu.
                pracownicy = bpxml.Pracownicy();
            }
        }

        // Metoda dodająca pracownika do bazy.
        // Jeżeli wystąpił błąd, to zwraca komunikat błędu.
        // Jeżeli wszystko się powiodło, to zwraca null.
        public string DodajPracownika(Pracownik nowyPracownik)
        {
            // Sprawdza, czy wszystkie podstawowe dane są uzupełnione.
            if (nowyPracownik.Imie == "" || nowyPracownik.Nazwisko == "" || nowyPracownik.Login == "" || nowyPracownik.Haslo == "" || nowyPracownik.Pesel == "")
            {
                return "Wszystkie pola muszą być uzupełnione.";
            }

            // Sprawdza duplikujące się dane.
            foreach (var pracownik in Pracownicy)
            {
                if (pracownik.Pesel == nowyPracownik.Pesel)
                {
                    return "Pracownik o tym numerze PESEL juz istnieje w bazie.";
                }

               else if (pracownik.Login == nowyPracownik.Login)
                {
                    return "Pracownik o tej nazwie uzytkownika juz istnieje w bazie.";
                }

                else if (pracownik.TypKonta == "Lekarz" && nowyPracownik.TypKonta == "Lekarz" && (((Lekarz)nowyPracownik).NrPWZ == ((Lekarz)pracownik).NrPWZ))
                {
                    return "Lekarz o tym numerze PWZ juz istnieje w bazie.";
                }
            }

            Pracownicy.Add(nowyPracownik);
            return null;
        }

        // Metoda usuwająca pracownika z bazy.
        public void UsunPracownika(Pracownik pracownik)
        {
            Pracownicy.Remove(pracownik);
        }

        // Metoda zwraca użytkownika o danym loginie.
        // Jeżeli nie znaleziono danego loginu w bazie, to zwraca null.
        public Pracownik ZnajdzPracownika(string nazwaUzytkownika)
        {
            foreach (var pracownik in Pracownicy)
            {
                if (pracownik.Login == nazwaUzytkownika)
                {
                    return pracownik;
                }
            }
            return null;
        }

        // Metoda sprawdzająca, czy dana data jest już zajęta przez lekarza
        // o tej samej specjalności.
        private bool czyDyzuryKoliduja(Lekarz lekarz, DateTime data)
        {
            foreach (Pracownik p in Pracownicy)
            {
                if (p.TypKonta == "Lekarz" && ((Lekarz)p).Specjalnosc == lekarz.Specjalnosc && lekarz != ((Lekarz) p))
                {
                    foreach (DateTime dyzur in ((Lekarz)p).DyzuryWMiesiacu(data))
                    {
                        if (dyzur.Day == data.Day && dyzur.Month == data.Month)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Metoda przypisująca dyżur do danego pracownika.
        // Jeżeli wystąpił błąd, zwraca komunikat błędu.
        // Jeżeli jest ok, to zwraca null.
        public string DodajDyzur(Pracownik pracownik, DateTime data)
        {
            if (pracownik.TypKonta == "Administrator")
            {
                return "Administratorzy nie moga miec dyzurow.";
            }

            // Pobieramy dyżury z danego miesiąca (w zależności od rodzaju konta).
            List<DateTime> dyzuryWMiesiacu = new List<DateTime>();
            if (pracownik.TypKonta == "Lekarz")
            {
                dyzuryWMiesiacu = (pracownik as Lekarz).DyzuryWMiesiacu(data);
            }
            else if (pracownik.TypKonta == "Pielęgniarka")
            {
                dyzuryWMiesiacu = (pracownik as Pielegniarka).DyzuryWMiesiacu(data);
            }

            // W jednym miesiącu nie może być więcej niż 10 dyżurów.
            if (dyzuryWMiesiacu.Count >= 10)
            {
                return "Pracownik nie moze miec powyzej 10 dyzurow jednego miesiaca.";
            }

            // Sprawdza, czy ma przynajmniej jeden dzień przerwy między dyżurami.
            foreach (var dyzur in dyzuryWMiesiacu)
            {
                if (Math.Abs(data.DayOfYear - dyzur.DayOfYear) <= 1)
                {
                    return "Nie mozna przypisac dyzuru bezposrednio przy dniu innego dyzuru.";
                }
            }

            // Lekarze nie mogą mieć dyżuru tego samego dnia co inny lekarz
            // tej samej specjalności, więc to też sprawdza.
            if (pracownik.TypKonta == "Lekarz")
            {
                if (czyDyzuryKoliduja((Lekarz) pracownik, data))
                {
                    return "Dyzur koliduje z dyzurem innego lekarza o tej samej specjalnosci.";
                }

                ((Lekarz)pracownik).DodajDyzur(data);
            }
            else if (pracownik.TypKonta == "Pielęgniarka")
            {
                ((Pielegniarka)pracownik).DodajDyzur(data);
            }

            return null;
        }

        // Metoda usuwająca wybrane dyżury z konta pracownika.
        public string UsunDyzury(Pracownik pracownik, List<DateTime> dyzury)
        {
            switch (pracownik.TypKonta)
            {
                case "Administrator":
                    return "Administrator nie ma dyzurow.";
                case "Lekarz":
                    (pracownik as Lekarz).UsunDyzury(dyzury);
                    break;
                case "Pielęgniarka":
                    (pracownik as Pielegniarka).UsunDyzury(dyzury);
                    break;
            }

            return null;
        }
    }
}
