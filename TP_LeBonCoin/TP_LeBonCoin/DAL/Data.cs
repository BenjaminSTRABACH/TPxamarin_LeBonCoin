using System;
using System.Collections.Generic;
using System.Text;
using TP_LeBonCoin.Model;
using SQLite;

namespace TP_LeBonCoin.DAL
{
    public class AppDatabase
    {
        private static Utilisateur _instance;

        readonly SQLiteAsyncConnection database;

        public AppDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Annonce>().Wait();
            database.CreateTableAsync<Utilisateur>().Wait();
        }

        public static Utilisateur GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Utilisateur()
                {

                    Login = string.Empty,
                    Mdp = string.Empty,

                };
            }
            return _instance;
        }
    }
}
