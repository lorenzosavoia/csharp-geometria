using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshap_geometria
{
    //—— Rettangolo1 —— base: 20 cm altezza: 10 cm Perimetro: 60 cm Area: 200 cm2
    internal class Rettangolo
    {
        private int iBaseRettangolo;
        private int iAltezzaRettangolo;

        public Rettangolo(int iBaseRettangolo , int iAltezzaRettangolo)
        {
           this.iBaseRettangolo = iBaseRettangolo;
           this.iAltezzaRettangolo = iAltezzaRettangolo;
        }
        public static int AreaCalc(int iBase, int iAltezza)
        {
            int iArea = iBase * iAltezza;
            return iArea;
        }

        public static int PerimetroCalc(int iBase, int iAltezza)
        {
            int iPerimetro = (iBase * 2) + (iAltezza * 2);
            return iPerimetro;
        }
        public void StampaRettangolo()
        {
            Console.WriteLine("");
            Console.WriteLine("base {0} cm", iBaseRettangolo);
            Console.WriteLine("altezza {0} cm", iAltezzaRettangolo);
            Console.WriteLine("perimetro {0} cm", PerimetroCalc(iBaseRettangolo,iAltezzaRettangolo));
            Console.WriteLine("area {0}", AreaCalc(iBaseRettangolo,iAltezzaRettangolo));
        }
    }
}
