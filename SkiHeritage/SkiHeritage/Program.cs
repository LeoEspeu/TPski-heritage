namespace SkiHeritage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe programme
    /// </summary>
    public class Program
    {
    /// <summary>
    /// methode main
    /// </summary>
    /// <param name="args">programme principal</param>
        public static void Main(string[] args)
        {
            try
            {
                List<Competiteur> lesCompetiteurs = new List<Competiteur>();
                lesCompetiteurs.Add(new Competiteur(1, "nomcompetiteur1", "prenomCompetiteur1", 29, 14));
                lesCompetiteurs.Add(new Competiteur(2, "nomcompetiteur2", "prenomCompetiteur2", 40, 31));
                lesCompetiteurs.Add(new Competiteur(3, "nomcompetiteur3", "prenomCompetiteur3", 17, 28));
                lesCompetiteurs.Add(new Competiteur(4, "nomcompetiteur4", "prenomCompetiteur4", 9, 7));
                lesCompetiteurs.Add(new Competiteur(5, "nomcompetiteur5", "prenomCompetiteur5", 5, 2));
                lesCompetiteurs.Add(new Competiteur(6, "nomcompetiteur6", "prenomCompetiteur6", 11, 13));
                lesCompetiteurs.Add(new Competiteur(7, "nomcompetiteur7", "prenomCompetiteur7", 4, 6));
                lesCompetiteurs.Add(new Competiteur(8, "nomcompetiteur8", "prenomCompetiteur8", 13, 15));
                lesCompetiteurs.Add(new Competiteur(9, "nomcompetiteur9", "prenomCompetiteur9", 27, 22));
                lesCompetiteurs.Add(new Competiteur(10, "nomcompetiteur10", "prenomCompetiteur10", 33, 32));
                lesCompetiteurs.Add(new Competiteur(11, "nomcompetiteur11", "prenomCompetiteur11", 39, 33));
                lesCompetiteurs.Add(new Competiteur(12, "nomcompetiteur12", "prenomCompetiteur12", 34, 34));
                lesCompetiteurs.Add(new Competiteur(13, "nomcompetiteur13", "prenomCompetiteur13", 30, 23));
                lesCompetiteurs.Add(new Competiteur(14, "nomcompetiteur14", "prenomCompetiteur14", 1, 1));
                lesCompetiteurs.Add(new Competiteur(15, "nomcompetiteur15", "prenomCompetiteur15", 36, 35));
                lesCompetiteurs.Add(new Competiteur(16, "nomcompetiteur16", "prenomCompetiteur16", 14, 21));
                lesCompetiteurs.Add(new Competiteur(17, "nomcompetiteur17", "prenomCompetiteur17", 25, 17));
                lesCompetiteurs.Add(new Competiteur(18, "nomcompetiteur18", "prenomCompetiteur18", 24, 24));
                lesCompetiteurs.Add(new Competiteur(19, "nomcompetiteur19", "prenomCompetiteur19", 8, 5));
                lesCompetiteurs.Add(new Competiteur(20, "nomcompetiteur20", "prenomCompetiteur20", 28, 11));
                lesCompetiteurs.Add(new Competiteur(21, "nomcompetiteur21", "prenomCompetiteur21", 23, 30));
                lesCompetiteurs.Add(new Competiteur(22, "nomcompetiteur22", "prenomCompetiteur22", 18, 25));
                lesCompetiteurs.Add(new Competiteur(23, "nomcompetiteur23", "prenomCompetiteur23", 7, 12));
                lesCompetiteurs.Add(new Competiteur(24, "nomcompetiteur24", "prenomCompetiteur24", 3, 4));
                lesCompetiteurs.Add(new Competiteur(25, "nomcompetiteur25", "prenomCompetiteur25", 31, 36));
                lesCompetiteurs.Add(new Competiteur(26, "nomcompetiteur26", "prenomCompetiteur26", 20, 18));
                lesCompetiteurs.Add(new Competiteur(27, "nomcompetiteur27", "prenomCompetiteur27", 16, 26));
                lesCompetiteurs.Add(new Competiteur(28, "nomcompetiteur28", "prenomCompetiteur28", 10, 8));
                lesCompetiteurs.Add(new Competiteur(29, "nomcompetiteur29", "prenomCompetiteur29", 35, 37));
                lesCompetiteurs.Add(new Competiteur(30, "nomcompetiteur30", "prenomCompetiteur30", 15, 27));
                lesCompetiteurs.Add(new Competiteur(31, "nomcompetiteur31", "prenomCompetiteur31", 37, 38));
                lesCompetiteurs.Add(new Competiteur(32, "nomcompetiteur32", "prenomCompetiteur32", 6, 9));
                lesCompetiteurs.Add(new Competiteur(33, "nomcompetiteur33", "prenomCompetiteur33", 19, 16));
                lesCompetiteurs.Add(new Competiteur(34, "nomcompetiteur34", "prenomCompetiteur34", 38, 39));
                lesCompetiteurs.Add(new Competiteur(35, "nomcompetiteur35", "prenomCompetiteur35", 2, 3));
                lesCompetiteurs.Add(new Competiteur(36, "nomcompetiteur36", "prenomCompetiteur36", 21, 19));
                lesCompetiteurs.Add(new Competiteur(37, "nomcompetiteur37", "prenomCompetiteur37", 32, 40));
                lesCompetiteurs.Add(new Competiteur(38, "nomcompetiteur38", "prenomCompetiteur38", 26, 20));
                lesCompetiteurs.Add(new Competiteur(39, "nomcompetiteur39", "prenomCompetiteur39", 12, 10));
                lesCompetiteurs.Add(new Competiteur(40, "nomcompetiteur40", "prenomCompetiteur40", 22, 29));

                CourseSlalom uneCourse = new CourseSlalom("Prix du Mont-Faron", Convert.ToDateTime("01/12/2017 11:00:00"), lesCompetiteurs);

                // Code de l'état de la neige : 1-Neige dure 0-Neigemolle
                CourseDescente uneCoursebis = new CourseDescente("Descente du Canigou", Convert.ToDateTime("15/12/2017 16:00:00"), lesCompetiteurs, 5000, 1);
                uneCoursebis.TraitementDossards();
                uneCourse.TraitementDossards();
                Console.Write("Nom Competition:" + uneCourse.NomCompetition + " -Date competition:" + uneCourse.DateCompetition + "\n\nListe coureurs:\n\n");
                Console.Write("Epreuve de slalom :\n\n");
                foreach (Participation p in uneCourse.LesParticipants)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("Nombres total de participants pour le slalom: " + uneCourse.LesParticipants.Count);
                Console.Write("\n\nNom Competition:" + uneCoursebis.NomCompetition + " -Date competition:" + uneCoursebis.DateCompetition + "\n\nListe coureurs:\n\n");
                Console.Write("\nEpreuve de descente:\nLongueur de la piste:" + uneCoursebis.Longueur + " mètres." + "\n\n");
                foreach (Participation p in uneCoursebis.LesParticipants)
                {
                    Console.WriteLine(p);
                }

                if (uneCoursebis.EtatNeige == 1)
                {
                    Console.WriteLine("\nEtat de la piste:neige dure.");
                }
                else
                {
                    Console.WriteLine("Etat de la piste:neige molle.");
                }

                Console.WriteLine("Nombres total de participants pour la descente: " + uneCoursebis.LesParticipants.Count);
                Console.Write("Nombre total de participant en coupe du monde de ski:" + lesCompetiteurs.Count());
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}