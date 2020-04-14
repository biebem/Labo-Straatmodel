﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StraatModel2.Tool2
{
    class Tool2
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------Het wegennetwerk Tool 2-------------------------");
            Console.WriteLine("|                                   Deserialization                            |");
            Console.WriteLine("| Please Give path of input file: (provincies.dat)                             |");
            Console.WriteLine("| exit to exit                                                                 |");
            Console.WriteLine("--------------------------------------------------------------------------------");
            string entered = Console.ReadLine();
            if (entered.ToLower().Trim() == "exit")
            {
                return;
            }
            else
            {
                string pathInput = @"" + entered;
                DatabaseImporter db = new DatabaseImporter(@"Data Source=DESKTOP-OF28PIK\SQLEXPRESS;Initial Catalog=provincies; Integrated Security=True");
                db.InsertAll(Serializatie.DeSerializeProvinciesBinary(pathInput));
                return;
            }

        }
    }
}
