﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEdu_JKD
{
    class Program
    {
        static void Main(string[] args)
        {
            Eleve.CreerNouvelEleve();
            ListeEleves.AfficherListeEleves();
            Console.ReadLine();
        }
    }
}
