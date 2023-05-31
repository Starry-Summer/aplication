using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using aplication.Models;
using System.Threading.Tasks;

namespace aplication.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Conection>().Wait();
        }

        public Task <int> SaveClienteAsync(Conection conec)
        {
            if (conec.IdUser != 0)
            {
                return db.InsertAsync(conec);
            }
            else
            {
                return null;
            }
        }
    }
}
