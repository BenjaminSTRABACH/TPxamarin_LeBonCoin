using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TP_LeBonCoin.DAL;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TP_LeBonCoin
{
    public partial class App : Application
    {
        static AppDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static AppDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new AppDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LeBonCoin.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
