namespace SkiHeritage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe participation
    /// </summary>
    public class Participation
    {
    /// <summary>
    /// variable competiteur
    /// </summary>
        private Competiteur zleCompetiteur;

        /// <summary>
        /// numero dossard de un competiteur
        /// </summary>
        private int numDossard;

        /// <summary>
        /// classement du competiteur après l'epreuve
        /// </summary>
        private int classement;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Participation"/>
        /// </summary>
        /// <param name="mleCompetiteur">parametre de type competiteur</param>
        public Participation(Competiteur mleCompetiteur)
        {
            this.zleCompetiteur = mleCompetiteur;
        }

        /// <summary>
        /// Obtient le competiteur
        /// </summary>
        public Competiteur LeCompetiteur
        {
            get
            {
                return this.zleCompetiteur;
            }
        }

        /// <summary>
        /// Obtient ou définit num dossard
        /// </summary>
        public int NumDossard
        {
            get
            {
                return this.numDossard;
            }

            set
            {
                this.numDossard = value;
            }
        }

        /// <summary>
        /// Obtient ou définit classement
        /// </summary>
        public int Classement
        {
            get
            {
                return this.classement;
            }

            set
            {
                this.classement = value;
            }
        }

        /// <summary>
        /// Méthode ToString
        /// </summary>
        /// <returns>Retourne un participant sous la forme d'une chaine de caracteres</returns>
        public override string ToString()
        {
            return this.zleCompetiteur + " - Numéro dossard:" + this.numDossard + " - Classement:" + this.Classement + "\n--------------------------------------";
        }
    }
}