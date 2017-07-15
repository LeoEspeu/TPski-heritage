namespace SkiHeritage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe course slalom hérite de course
    /// </summary>
    public class CourseSlalom : Course
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="CourseSlalom"/>
        /// </summary>
        /// <param name="nomCompetition">nom de la descente</param>
        /// <param name="dateCompetition">date de la descente</param>
        /// <param name="lesParticipants">liste de competiteur</param>
        public CourseSlalom(string nomCompetition, DateTime dateCompetition, List<Competiteur> lesParticipants) : base(nomCompetition, dateCompetition, lesParticipants)
        {
            Course course = new Course(nomCompetition, dateCompetition, lesParticipants);
        }

        /// <summary>
        /// attribue des dossards aux participants
        /// </summary>
        public void TraitementDossards()
        {
            int zComp;
            int zIC;
            this.ClasserLesParticipants();
            zComp = LesParticipants.Count;
            this.AttribuerDossards(1, 8);
            if (zComp > 15)
            {
                this.AttribuerDossards(8, 16);
            }

            zIC = 15;
            while (zIC < zComp)
            {
                LesParticipants[zIC].NumDossard = zIC + 1;
                zIC = zIC + 1;
            }
        }

        /// <summary>
        /// attribue les dossards selon le reglement de un slalom
        /// </summary>
        /// <param name="borneInf">numéro minimun du dossard attribuer</param>
        /// <param name="borneSup">numéro maximun du dossard attribuer</param>
        private void AttribuerDossards(int borneInf, int borneSup)
        {
            int rangCoureur;
            int numero;
            numero = borneInf;

            if (LesParticipants.Count < 8)
            {
                borneSup = LesParticipants.Count + 1;
            }

            while (numero < borneSup)
            {
                Random random = new Random();
                rangCoureur = random.Next(borneInf, borneSup);
                rangCoureur = rangCoureur - 1;
                if (LesParticipants[rangCoureur].NumDossard == 0)
                {
                    LesParticipants[rangCoureur].NumDossard = numero;
                    numero = numero + 1;
                }
            }
        }
    }
}