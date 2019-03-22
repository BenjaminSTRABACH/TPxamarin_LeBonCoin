using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LeBonCoin.Model
{
    class Annonce
    {
        /// <summary>
        /// ID de l'annonce
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Titre de l'annonce
        /// </summary>
        public string titre { get; set; }

        /// <summary>
        /// Description de l'annonce
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// Prix de l'annonce
        /// </summary>
        public decimal prix { get; set; }

        /// <summary>
        /// Numéro de téléphone à contacter
        /// </summary>
        public decimal tel { get; set; }

        /// <summary>
        /// Catégorie à laquelle appartient l'annonce
        /// </summary>
        public decimal categorie { get; set; }
    }
}
