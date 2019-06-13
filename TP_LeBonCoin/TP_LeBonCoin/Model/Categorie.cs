using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TP_LeBonCoin
{
    public class Categorie
    {
        /// <summary>
        /// ID de la catégorie
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        /// <summary>
        /// Titre de la catégorie
        /// </summary>
        public string Titre { get; set; }
    }
}
