namespace SkiHeritage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe course descente hérite de course 
    /// </summary>
    public class CourseDescente : Course
    {
    /// <summary>
    /// variable longueur
    /// </summary>
        private int longueur;

        /// <summary>
        /// variable etat de la neige
        /// </summary>
        private int etatNeige;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="CourseDescente"/>
        /// </summary>
        /// <param name="nomCompetition">nom de la descente</param>
        /// <param name="dateCompetition">date de la descente</param>
        /// <param name="lesParticipants">liste de competiteur</param>
        /// <param name="pLongueur">longueur de la piste</param>
        /// <param name="pEtatNeige">Code de l'etat de la neige</param>
        public CourseDescente(string nomCompetition, DateTime dateCompetition, List<Competiteur> lesParticipants, int pLongueur, int pEtatNeige) : base(nomCompetition, dateCompetition, lesParticipants)
        {
            this.longueur = pLongueur;
            this.etatNeige = pEtatNeige;
            Course course = new Course(nomCompetition, dateCompetition, lesParticipants);
        }

        /// <summary>
        /// Obtient ou définit de longueur
        /// </summary>
        public int Longueur
        {
            get
            {
                return this.longueur;
            }

            set
            {
                this.longueur = value;
            }
        }

        /// <summary>
        /// Obtient ou définit etat neige
        /// </summary>
        public int EtatNeige
        {
            get
            {
                return this.etatNeige;
            }

            set
            {
                this.etatNeige = value;
            }
        }

        /// <summary>
        /// attribue les dossards à tout les concurents
        /// </summary>
        public void TraitementDossards()
        {
            int zBComp;
            int tIC;
            this.ClasserLesParticipants();
            zBComp = LesParticipants.Count;
            this.AttribuerDossards(1, 31);
            tIC = 30;
            while (tIC < zBComp)
            {
                LesParticipants[tIC].NumDossard = tIC + 1;
                tIC = tIC + 1;
            }
        }

        /// <summary>
        /// attribue les dossards selon le reglement de la descente et l'etat de la neige
        /// </summary>
        /// <param name="borneInf">numéro minimun du dossard attribuer</param>
        /// <param name="borneSup">numéro maximun du dossard attribuer</param>
        private void AttribuerDossards(int borneInf, int borneSup)
        {
            int i = borneInf;
            int rangCoureur = 0;
            int numero;
            List<int> dossards = new List<int>();
            while (i <= 30)
            {
                dossards.Add(i);
                i = i + 1;
            }

            if (this.etatNeige == 0 || LesParticipants.Count > 7)
            {
                LesParticipants[0].NumDossard = 5;
                LesParticipants[1].NumDossard = 6;
                dossards.RemoveAt(4);
                dossards.RemoveAt(4);
                rangCoureur = 2;
            }

            if (LesParticipants.Count < 30)
            {
                borneSup = LesParticipants.Count + 1;
            }

            while (rangCoureur <= 14 && rangCoureur < LesParticipants.Count)
            {
                Random random = new Random();
                numero = random.Next(borneInf, borneSup);
                foreach (int p in dossards)
                {
                    if (numero == p)
                    {
                        LesParticipants[rangCoureur].NumDossard = numero;
                        rangCoureur = rangCoureur + 1;
                        i = dossards.IndexOf(p);
                    }
                }

                if (i >= 0)
                {
                    dossards.RemoveAt(i);
                }

                i = -1;
            }

            while (rangCoureur < 30 && rangCoureur < LesParticipants.Count)
            {
                LesParticipants[rangCoureur].NumDossard = dossards[0];
                dossards.RemoveAt(0);
                rangCoureur = rangCoureur + 1;
            }
        }       
    }
}