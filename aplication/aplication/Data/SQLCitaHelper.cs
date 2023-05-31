using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using aplication.cita;
using SQLite;

namespace aplication.Data
{
    public class SQLCitaHelper
    {
        SQLiteAsyncConnection bd;
        public SQLCitaHelper(string dbPath)
        {
            bd = new SQLiteAsyncConnection(dbPath);
            bd.CreateTableAsync<Conection>().Wait();
        }

        public Task <int> SaveCitaAsync(Conection conecti)
        {
            if (conecti.IdUser != 0)
            {
                return bd.InsertAsync(conecti);
            }
            else
            {
                return null;
            }
        }
    }
}
