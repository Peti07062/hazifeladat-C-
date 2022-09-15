using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazifeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Kérem adja meg az első számot: ");
            int szam_1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az első számot: ");
            int szam_2 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az első számot: ");
            int szam_3 = int.Parse(Console.ReadLine());

            if (szam_1 > szam_2 && szam_1 > szam_3)
            {
                Console.Write(szam_1 + " ");
                if (szam_2 > szam_3)
                {
                    Console.Write(szam_2 + " " + szam_3);
                }
                else
                {
                    Console.Write(szam_3 + " " + szam_2);
                }
            }

            if (szam_2> szam_3 && szam_2 > szam_1)
            {
                Console.Write(szam_2 + " ");
                if(szam_1 > szam_3)
                {
                    Console.Write(szam_1 + " " + szam_3);

                }
                else
                {
                    Console.Write(szam_3 + " " + szam_1);
                }
            }


            if (szam_3 > szam_1 && szam_3 > szam_2)
            {
                Console.Write(szam_3 + " ");
                if (szam_1 > szam_2)
                {
                    Console.Write(szam_1 + " " + szam_2);

                }
                else
                {
                    Console.Write(szam_2 + " " + szam_1);
                }
            }



            Console.ReadKey();
        }
    }
}
