using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string ligne = "";
            int i = 1;
            do
            {
                Console.WriteLine("saisir un nom");
                ligne = Console.ReadLine();
                if (!string.IsNullOrEmpty(ligne))
                {
                    Table1 table1 = new Table1();
                    table1.nom = ligne;
                    table1.Id = i;
                    i++;
                    MyDBEntities db = new MyDBEntities();
                    db.Table1.Add(table1);
                    int res = db.SaveChanges();
                    Console.WriteLine(res);
                }
            }
            while (!string.IsNullOrEmpty(ligne));

        }
    }
}
