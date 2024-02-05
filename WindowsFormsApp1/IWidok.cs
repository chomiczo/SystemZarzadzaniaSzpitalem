using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzpitalGUI
{
    // Ogólna zasada działania warstwy prezentacji jest taka, że mamy główne
    // okienko (Main) i kilka obiektów ze szczegółowymi designami (dziedziczącymi
    // po klasie UserControl), które są dynamicznie podmieniane w trakcie działania
    // programu.
    //
    //Zrobiona zostala funkcja odświeżania widoku, żeby można było użyć w tym celu interfejsu,
    // który będzie wymuszał, żeby każdy widok implementował metodę Odswiez().

    interface IWidok
    {
        void Odswiez();
    }
}
