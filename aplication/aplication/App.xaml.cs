using aplication.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplication
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        static SQLCitaHelper bd;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        //Esto es de registro de clientes
        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cliente.db3"));
                }
                return db;
            }
        }

        //Esto es de las citas
        public static SQLCitaHelper SQLiteBD
        {
            get
            {
                if (bd == null)
                {
                    bd = new SQLCitaHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Citas.db3"));
                }
                return bd;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
