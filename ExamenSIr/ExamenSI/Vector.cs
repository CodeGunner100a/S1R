using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSI
{
    class Vector
    {

        const int MAX = 50;
        private int[] v;
        private int n;



        public Vector()
        {
            n = 0;
            v = new int[MAX];

        }


        public void CargarRnd(int n1, int a, int b)
        {

            Random r = new Random();

            n = n1;

            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }




        public string Descargar()
        {
            string s = "";

            for (int i = 1; i <= n; i++)
            {

                s = s + v[i] + "  |  ";
            }

            return s;
        }

        

        //Ejercicio 1
        public void Ejercicio1(int a, int b)
        {
            NEnt n1 = new NEnt();

            int i = a;

            while (i <= b)
            {
                n1.Cargar(v[i]);

                if (n1.VerifPrimo())
                {
                    EliminarPos(i);
                    b--; 
                }
                else
                {
                    i++;
                }
            }
        }
        public void EliminarPos(int pos)
        {
            for (int i = pos; i < n; i++)
            {
                v[i] = v[i + 1];
            }

            n--;
        }


        //Ejercicio 2

        public void Ejercicio2(int a, int b, ref Vector e, ref Vector f)
        {
            e.n = 0;
            f.n = 0;

            NEnt n1 = new NEnt();

            for (int i = a; i <= b; i++)
            {
                n1.Cargar(v[i]);

               
                if (n1.VerifPrimo())
                {
                    
                    if (!e.Existe_elemento(v[i]))
                    {
                        e.insertar(v[i]);

                        int frec = frecuencia_rango(v[i], a, b);
                        f.insertar(frec);
                    }
                }
            }

       
        }

        public int frecuencia_rango(int ele, int a, int b)
        {
            int cont = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                {
                    cont++;
                }
            }

            return cont;
        }
        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;

        }
        public bool Existe_elemento(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                {
                    ban = true;
                }
                else
                {
                    i = i + 1;
                }

            }

            return ban;
        }

    }
}
