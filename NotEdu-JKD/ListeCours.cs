﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEdu_JKD
{
    class ListeCours
    {
        public Dictionary<int, Cours> ListeDesCours { get; }
        public ListeCours()
        {
            ListeDesCours = new Dictionary<int, Cours>();
        }
        public void AjouterCours(Cours nouveauCours)
        {
            if (ListeDesCours.ContainsKey(nouveauCours.Id))
            {
                Console.WriteLine($"Le cours {nouveauCours.Titre} existe déjà, veuillez réessayer avec un autre cours.");
            }
            else
            {
                ListeDesCours.Add(nouveauCours.Id, nouveauCours);
                Console.WriteLine($"Ajout du cours {nouveauCours.Titre} réussi.");
            }
        }
        public void AfficherTousLesCours()
        {
            Console.WriteLine("Liste de tous les cours disponibles : \n");
            foreach (KeyValuePair<int, Cours> cours in ListeDesCours)
            {
                Console.WriteLine($" ID : {cours.Value.Id} | Cours : {cours.Value.Titre}\n");
            }
        }

        /*Suppression de toutes les occurences d'un cours.*/
        public void SuppressionCours()
        {
            AfficherTousLesCours();
            Console.Write("Entrez l'ID du cours à supprimer : ");
            int coursId = int.Parse(Console.ReadLine());
            if (!ListeDesCours.ContainsKey(coursId))
            {
                Console.WriteLine("Ce cours n'existe pas, veuillez entrer un cours valide.");
                return;
            }
            Cours coursASupprimer = ListeDesCours[coursId];
            Console.Write("/!\\ La suppression d'un cours entraîne la suppression de touses les notes " +
                "et appréciations qui lui sont liées. \n" +
                $"Voulez-vous vraiment supprimer le cours {coursASupprimer.Titre}? (Oui/Non) ");
            string reponseSuppression = Console.ReadLine().ToLower();

            if (reponseSuppression == "oui")
            {
                /* Loop à travers tout les élèves, dans toutes leurs notes pour trouver l'ID correspondant*/
                ListeDesCours.Remove(coursId);
            }
            else
            {
                Console.WriteLine("Annulation de la suppression du cours.");
            }
        }
        public void AfficherNotesCours()
        {
            AfficherTousLesCours();
            Console.Write("Entrez l'ID du cours à afficher : ");
            int coursId = int.Parse(Console.ReadLine());
            /* Loop dans la liste des élèves pour trouver les notes correspondants au cours */
        }
    }
}