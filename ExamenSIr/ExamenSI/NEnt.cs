using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSI
{
    class NEnt
    {
        private int n;
        
        public NEnt()
        {
            n = 0;
        }


        public void Cargar(int dato)
        {
            n = dato;//5
        }

        public int Descargar()
        {
            return n;
        }

        public bool VerifPrimo()
        {
            int c = 0;
            bool ban = true;
            
            for (int i = 1; i <= n; i++)
            {
                
                if (n % i == 0)
                {
                    c = c + 1;
                }

            }

            if (c == 2)
            {
                ban = true;
            }
            else
            {
                ban = false;
            }


            return ban;

        }

    }
}
