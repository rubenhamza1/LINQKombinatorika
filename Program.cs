using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQKombinatorika
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var upit =
               from broj1 in brojevi
               from broj2 in brojevi
               where broj2 != broj1
                   && (broj1 * 10 + broj2) % 2 == 0
               from broj3 in brojevi
               where broj3 != broj2 && broj3 != broj1
                   && (broj1 * 100 + broj2 * 10 + broj3) % 3 == 0
               from broj4 in brojevi
               where broj4 != broj3 && broj4 != broj2 && broj4 != broj1
                  && (broj1 * 1000 + broj2 * 100 + broj3 * 10 + broj4) % 4 == 0
               from broj5 in brojevi
               where broj5 != broj4 && broj5 != broj3 && broj5 != broj2 && broj5 != broj1
                  && (broj1 * 10000 + broj2 * 1000 + broj3 * 100
                  + broj4 * 10 + broj5) % 5 == 0
               from broj6 in brojevi
               where broj6 != broj5 && broj6 != broj4 && broj6 != broj3 && broj6 != broj2
                   && broj6 != broj1 && (broj1 * 100000 + broj2 * 10000 + broj3 * 1000
                   + broj4 * 100 + broj5 * 10 + broj6) % 6 == 0
               from broj7 in brojevi
               where broj7 != broj6 && broj7 != broj5 && broj7 != broj4 && broj7 != broj3
                   && broj7 != broj2 && broj7 != broj1
                   && (broj1 * 1000000 + broj2 * 100000 + broj3 * 10000 + broj4 * 1000
                   + broj5 * 100 + broj6 * 10 + broj7) % 7 == 0
               from broj8 in brojevi
               where broj8 != broj7 && broj8 != broj6 && broj8 != broj5
                   && broj8 != broj4 && broj8 != broj3 && broj8 != broj2 && broj8 != broj1
                   && (broj1 * 10000000 + broj2 * 1000000 + broj3 * 100000 + broj4 * 10000
                   + broj5 * 1000 + broj6 * 100 + broj7 * 10 + broj8) % 8 == 0
               from broj9 in brojevi
               where broj9 != broj8 && broj9 != broj7 && broj9 != broj6
                   && broj9 != broj5 && broj9 != broj4 && broj9 != broj3
                   && broj9 != broj2 && broj9 != broj1

               let trazeniBroj = broj1 * 100000000 +
                          broj2 * 10000000 +
                          broj3 * 1000000 +
                          broj4 * 100000 +
                          broj5 * 10000 +
                          broj6 * 1000 +
                          broj7 * 100 +
                          broj8 * 10 +
                          broj9 * 1
               where trazeniBroj % 9 == 0
               select trazeniBroj;

            foreach (int n in upit)
                Console.WriteLine(n);


            Console.ReadKey();

        }
    }
}
