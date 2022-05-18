using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasTerreno
{
    class Terreno
    {
        public Terreno()
        {
        }

        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double PrecoMtq { get; set; }
        public double Area { get; set; }
        
        public double AreaTotal()
        {
            return Largura * Comprimento;
        }

        public double PrecoTotal()
        {
            return AreaTotal() * PrecoMtq;
        }

        public override string ToString()
        {
            return "AREA = " + AreaTotal().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "PRECO = " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
