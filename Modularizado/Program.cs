using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularizado
{
    class program
    {
        static void Main(string[] arg)
        {

            /*
            for (int i = 0; i < 5; i++)
            {
                MetodoGeneral();
            }*/

            int e = leerEdad();




            Console.ReadKey();
        }




        public static int leerEdad(int edad)
        {
            Console.WriteLine("introduce tu edad : ");
            edad = int.Parse(Console.ReadLine());

            return edad;
        }

        public static YaCumplioAnios(bool r)
        {
            bool r=false;

            Console.WriteLine("¿Ya cumplio años? Y/N");
            string resp = Console.ReadLine();
            if (resp == "Y" || resp == "y")
            {
                r = true;
            }
            if ( r== false)
            {
                Console.WriteLine("Su año de nacimiento es: {0}", antrue());
            }
            else
            {

                Console.WriteLine("Su año de nacimiento es: {0}", anfalse());
            }

            return r;
        }

       

        public static int CalcularAnnio(int antrue)
        {
           antrue = DateTime.Now.Year - (leerEdad + 1);
           // Console.WriteLine("Su año de nacimiento es: {0}", anioNacimineto);
           return antrue;
        }

        public static CalcularAnnio(int anfalse)
        {
            anfalse = DateTime.Now.Year - (leerEdad);
            // Console.WriteLine("Su año de nacimiento es: {0}", anioNacimineto);
            return anfalse;
        }

        public static MostrarResultados()
        {

        }
        


    }
}