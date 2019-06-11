using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using TP_LeBonCoin.Model;
using SQLite;

namespace TP_LeBonCoin.DAL
{
    public class AppDatabase
    {
        readonly SQLiteAsyncConnection database;

        public AppDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Annonce>().Wait();
            database.CreateTableAsync<Utilisateur>().Wait();
        }

        public Task<List<Annonce>> GetAnnonce()
        {
            return database.Table<Annonce>().ToListAsync();
        }

        public Task<List<Utilisateur>> GetUtilisateur()
        {
            return database.Table<Utilisateur>().ToListAsync();
        }

        public Task<int> SaveAnnonce(Annonce annonce)
        {
            if (annonce.Id != 0)
            {
                return database.UpdateAsync(annonce);
            }
            else
            {
                return database.InsertAsync(annonce);
            }
        }

        public Task<int> SaveUtilisateur(Utilisateur utilisateur)
        {
            if (utilisateur.Id != 0)
            {
                return database.UpdateAsync(utilisateur);
            }
            else
            {
                return database.InsertAsync(utilisateur);
            }
        }

        public Task<int> DeleteAnnonce(Annonce annonce)
        {
            return database.DeleteAsync(annonce);
        }

        public Task<int> DeleteUtilisateur(Utilisateur utilisateur)
        {
            return database.DeleteAsync(utilisateur);
        }
    }
}
