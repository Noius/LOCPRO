using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCPRO
{
    public static class Controleur
    {
        static Modele vmodele;

        public static Modele Vmodele
        {
            get { return Controleur.vmodele; }
            set { Controleur.vmodele = value; }
        }
        public static void init()
        {
            vmodele = new Modele();
        }

    }
}
