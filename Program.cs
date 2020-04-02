using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2a_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Chetiroxygol CHETIROXYGOLNIK = new Chetiroxygol();
            CHETIROXYGOLNIK.SIZESCHetver();
            CHETIROXYGOLNIK.GetSizeofside();
            CHETIROXYGOLNIK.GetDiagonal();
            CHETIROXYGOLNIK.GetPerimetr();
            CHETIROXYGOLNIK.GetArea();
        }
    }
}
