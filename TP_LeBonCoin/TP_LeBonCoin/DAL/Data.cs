using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

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
            database.CreateTableAsync<Categorie>().Wait();
        }

        public Task<List<Annonce>> SelectAnnonces(bool notMine)
        {
            if (notMine == false)
            {
                return database.Table<Annonce>().ToListAsync();
            } else
            {
                int idUtilisateur = int.Parse(Application.Current.Properties["session"] as String);
                return database.Table<Annonce>().Where(i => i.IDUtilisateur != idUtilisateur).ToListAsync();
            }
        }

        public Task<List<Categorie>> SelectCategories()
        {
            return database.Table<Categorie>().ToListAsync();
        }

        public Task<List<Utilisateur>> SelectUtilisateurs()
        {
            return database.Table<Utilisateur>().ToListAsync();
        }

        public Task<int> SaveAnnonce(Annonce annonce)
        {
            if (annonce.ID != 0)
            {
                return database.UpdateAsync(annonce);
            }
            else
            {
                return database.InsertAsync(annonce);
            }
        }

        public Task<int> SaveCategorie(Categorie categorie)
        {
            if (categorie.ID != 0)
            {
                return database.UpdateAsync(categorie);
            }
            else
            {
                return database.InsertAsync(categorie);
            }
        }

        public Task<int> SaveUtilisateur(Utilisateur utilisateur)
        {
            if (utilisateur.ID != 0)
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

        public Task<int> DeleteCategorie(Categorie categorie)
        {
            return database.DeleteAsync(categorie);
        }

        public Task<int> DeleteUtilisateur(Utilisateur utilisateur)
        {
            return database.DeleteAsync(utilisateur);
        }

        public Task<List<Annonce>> SelectAnnoncesByTitre(bool notMine, string search)
        {
            search = '%' + search + '%';
            if (notMine == false)
            {
                return database.QueryAsync<Annonce>("SELECT * FROM [annonce] WHERE [Titre] LIKE ?", search);
            } else
            {
                int idUtilisateur = int.Parse(Application.Current.Properties["session"] as String);
                return database.QueryAsync<Annonce>("SELECT * FROM [annonce] WHERE [Titre] LIKE ? AND IDUtilisateur != ?", search, idUtilisateur);
            }
        }

        public Task<List<Annonce>> SelectAnnoncesByIdUtilisateur()
        {
            int idUtilisateur = int.Parse(Application.Current.Properties["session"] as String);
            return database.Table<Annonce>().Where(i => i.IDUtilisateur == idUtilisateur).ToListAsync();
        }

        public Task<Annonce> GetAnnonceById(int id)
        {
            return database.Table<Annonce>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<Categorie> GetCategorieById(int id)
        {
            return database.Table<Categorie>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<Utilisateur> GetUtilisateurByLogin(string login)
        {
            return database.Table<Utilisateur>().Where(i => i.Login == login).FirstOrDefaultAsync();
        }

        public Task<Categorie> GetCategorieByTitre(string titre)
        {
            return database.Table<Categorie>().Where(i => i.Titre == titre).FirstOrDefaultAsync();
        }
    }
}
