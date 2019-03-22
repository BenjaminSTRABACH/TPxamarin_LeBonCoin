using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LeBonCoin.Model
{
    class Utilisateur
    {
        /// <summary>
        /// ID de l'utilisateur
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Nom de famille de l'utilisateur
        /// </summary>
        public string nom { get; set; }

        /// <summary>
        /// Prénom de famille de l'utilisateur
        /// </summary>
        public string prenom { get; set; }

        /// <summary>
        /// Identifiant de l'utilisateur pour la connexion
        /// </summary>
        public string login { get; set; }

        /// <summary>
        /// Mot de passe de l'utilisateur pour la connexion
        /// </summary>
        public string mdp { get; set; }
    }
}
