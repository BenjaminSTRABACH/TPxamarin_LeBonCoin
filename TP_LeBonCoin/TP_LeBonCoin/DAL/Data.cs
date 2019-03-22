using System;
using System.Collections.Generic;
using System.Text;
using TP_LeBonCoin.Model;

namespace TP_LeBonCoin.DAL
{
    class Data
    {
        private static Utilisateur _instance;

        public static Utilisateur GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Utilisateur()
                {

                    login = string.Empty,
                    mdp = string.Empty,

                };
            }
            return _instance;
        }
    }
}
