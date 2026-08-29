using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDAL.General
{
    public static class DbManager
    {
        private static AppDb _db;
        public static AppDb Db
        {
            get
            {
                if (_db == null || !_db.Database.CanConnect())
                { _db?.Dispose(); _db = new AppDb(); }
                return _db;
            }
        }
        public static void DeleteDb()
        {
            Db.Database.EnsureDeleted();
        }
        public static void CreateDb()
        {
            DeleteDb();
            Db.Database.EnsureCreated();
        }

    }
}
