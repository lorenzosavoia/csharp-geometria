/*
Consegna: Nel progetto csharp - geometria creare le seguenti classi
Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo. Aggiungere un opportuno costruttore con parametri. Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. Dopo averlo istanziato, stampate a video il perimetro e l’area.
Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
—— Rettangolo1 —— base: 20 cm altezza: 10 cm Perimetro: 60 cm Area: 200 cm2
BONUS Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/

using System;

namespace cshap_geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Quanto é alto il tuo rettangolo?");
            int iBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qual é la base del rettangolo?");
            int iAltezza = Convert.ToInt32(Console.ReadLine());
            Rettangolo rettangolo1 = new Rettangolo(iBase,iAltezza);

            int iAreaRettangolo = Rettangolo.AreaCalc(iBase,iAltezza);
            int iPerimetroRettangolo = Rettangolo.PerimetroCalc(iBase, iAltezza);

            //richiamo la funzione stampa rettangolo
            //nome rettangono.nome funzione
            rettangolo1.StampaRettangolo();

        }
    }
        
}
