namespace SkiHeritage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe course
    /// </summary>
    public class Course
    {
    /// <summary>
    /// nom de la course
    /// </summary>
        private string nomCompetition;

        /// <summary>
        /// date de la course
        /// </summary>
        private DateTime dateCompetition;

        /// <summary>
        /// liste de participants
        /// </summary>
        private List<Participation> lesParticipants;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Course"/>
        /// </summary>
        /// <param name="nomCompetition">nom de la descente</param>
        /// <param name="dateCompetition">date de la descente</param>
        /// <param name="lesParticipants">liste de competiteur</param>
        public Course(string nomCompetition, DateTime dateCompetition, List<Competiteur> lesParticipants)
        {
            this.lesParticipants = new List<Participation>();
            this.nomCompetition = nomCompetition;
            this.dateCompetition = dateCompetition;
            foreach (Competiteur zunCompetiteur in lesParticipants)
            {
                this.lesParticipants.Add(new Participation(zunCompetiteur));
            }
        }

        /// <summary>
        /// Obtient nom competition
        /// </summary>
        public string NomCompetition
        {
            get
            {
                return this.nomCompetition;
            }
        }

        /// <summary>
        /// Obtient ou définit date competition
        /// </summary>
        public DateTime DateCompetition
        {
            get
            {
                return this.dateCompetition;
            }

            set
            {
                this.dateCompetition = value;
            }
        }

        /// <summary>
        /// Obtient ou définit liste les participant
        /// </summary>
        internal List<Participation> LesParticipants
        {
            get
            {
                return this.lesParticipants;
            }

            set
            {
                this.lesParticipants = value;
            }
        }

        /// <summary>
        /// classe les participants selon le classement WCSL pour 30 premiers puis par le classement FIS pour le reste
        /// </summary>
        public void ClasserLesParticipants()
        {
            this.lesParticipants = this.lesParticipants.OrderBy(p => p.LeCompetiteur.ClassementWCSL).ToList<Participation>();
            List<Participation> zleParticipant = new List<Participation>();
            if (this.lesParticipants.Count > 30)
            {
                while (this.lesParticipants.Count != 30)
                {
                    zleParticipant.Add(this.lesParticipants[30]);
                    this.lesParticipants.RemoveAt(30);
                }

                zleParticipant = zleParticipant.OrderBy(p => p.LeCompetiteur.ClassementFIS).ToList<Participation>();
                while (zleParticipant.Count != 0)
                {
                    this.lesParticipants.Add(zleParticipant[0]);
                    zleParticipant.RemoveAt(0);
                }
            }
        }
    }
}