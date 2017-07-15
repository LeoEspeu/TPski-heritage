namespace SkiHeritage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe Competiteur
    /// </summary>
    public class Competiteur
    {
        /// <summary>
        /// Numero  du competiteur
        /// </summary>
        private int numeroCompetiteur;

        /// <summary>
        /// Nom du competiteur
        /// </summary>
        private string nomCompetiteur;

        /// <summary>
        /// Prenom du competiteur
        /// </summary>
        private string prenomCompetiteur;

        /// <summary>
        /// Prenom du competiteur
        /// </summary>
        private int classementFIS;

        /// <summary>
        /// Classement WCSL
        /// </summary>
        private int classementWCSL;
        
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Competiteur"/>
        /// </summary>
        /// <param name="numeroCompetiteur">Numero du competiteur</param>
        /// <param name="nomCompetiteur">Nom du competiteurr</param>
        /// <param name="prenomCompetiteur">Prenom du competiteur</param>
        /// <param name="classementFIS">Classement FIS</param>
        /// <param name="classementWCSL">Classement WCSL</param>
        public Competiteur(int numeroCompetiteur, string nomCompetiteur, string prenomCompetiteur, int classementFIS, int classementWCSL)
        {
            this.numeroCompetiteur = numeroCompetiteur;
            this.nomCompetiteur = nomCompetiteur;
            this.prenomCompetiteur = prenomCompetiteur;
            this.classementFIS = classementFIS;
            this.classementWCSL = classementWCSL;
        }

        /// <summary>
        /// Obtient numero competiteur
        /// </summary>
        public int NumeroCompetiteur
        {
            get
            {
                return this.numeroCompetiteur;
            }
        }

        /// <summary>
        /// Obtient nom competiteur
        /// </summary>
        public string NomCompetiteur
        {
            get
            {
                return this.nomCompetiteur;
            }
        }

        /// <summary>
        /// Obtient ou définit classement FIS
        /// </summary>
        public int ClassementFIS
        {
            get
            {
                return this.classementFIS;
            }

            set
            {
                this.classementFIS = value;
            }
        }

        /// <summary>
        /// Obtient prenom competiteur
        /// </summary>
        public string PrenomCompetiteur
        {
            get
            {
                return this.prenomCompetiteur;
            }
        }

        /// <summary>
        /// Obtient ou définit classement WCSL
        /// </summary>
        public int ClassementWCSL
        {
            get
            {
                return this.classementWCSL;
            }

            set
            {
                this.classementWCSL = value;
            }
        }

        /// <summary>
        /// Méthode ToString
        /// </summary>
        /// <returns>Retourne les propriétés sous forme de chaines de caracteres</returns>
        public override string ToString()
        {
            return "Numero competiteur: " + this.numeroCompetiteur + "  Nom competiteur:" + this.nomCompetiteur + "  Prenom competiteur:" + this.prenomCompetiteur
            + " Classement WCSL:" + this.ClassementWCSL + " - Classement FIS:" + this.classementFIS;
        }
    }
}