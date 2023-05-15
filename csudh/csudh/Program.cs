using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh
{
    
    public class Program
    {
        public static string function(string nev, int szint)
            {
                string ertek;
                try
                {
                   ertek= nev.Split('.')[nev.Split('.').Length- szint];
                }
                catch (Exception)
                {
                    ertek = "nincs";
                }
                return ertek;
            }
        static void Main(string[] args)
        {
            List<Domain> list = new List<Domain>();
            StreamReader s = new StreamReader("csudh.txt");
            s.ReadLine();
            while (!s.EndOfStream)
            {
                list.Add(new Domain(s.ReadLine()));
            }
            s.Close();

            Console.WriteLine("3. feladat:");
            foreach (var item in list)
            {
                Console.WriteLine(item.nev+" "+item.ip);
            }
            Console.WriteLine(list.Count() + " cím van a listában.");

            Console.WriteLine("3. feladat:");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i + ". szint:"+ function(list[0].nev, i));
            }

            Console.ReadKey();

            

        }
    }
}
