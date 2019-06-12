using SQLite;

namespace TP_LeBonCoin
{
    public class Utilisateur
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
    }
}
