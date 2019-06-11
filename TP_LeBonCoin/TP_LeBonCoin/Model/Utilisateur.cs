using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TP_LeBonCoin.Model
{
    public class Utilisateur
    {
        /// <summary>
        /// ID de l'utilisateur
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Nom de famille de l'utilisateur
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom de famille de l'utilisateur
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Identifiant de l'utilisateur pour la connexion
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Mot de passe de l'utilisateur pour la connexion
        /// </summary>
        public string Mdp { get; set; }
    }
}
