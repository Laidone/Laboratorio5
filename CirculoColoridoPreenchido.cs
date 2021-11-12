using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class CirculoColoridoPreenchido : CirculoColorido
    {
        private Cor_enum corlilas;
        enum Cor_enum
        {
            ciano
        }
        public CirculoColoridoPreenchido(double x, double y, double r, string c):base(x, y, r, c)
        {
        }
        public CirculoColoridoPreenchido()
        {
            corlilas = Cor_enum.ciano;
        }
        public override string ToString()
        {
            return base.ToString() + " e a cor adcional é " + corlilas;
        }
    }
}