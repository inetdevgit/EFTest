using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestBR.Db
{
    public static class DbUtil
    {
        public static EFTestDAL.AppDb Create()
        {
            return EFTestDAL.General.DbManager.Db;
        }
        public static void DeleteDb()
        {
            EFTestDAL.General.DbManager.DeleteDb();
        }
        public static void CreateDb()
        {
            EFTestDAL.General.DbManager.CreateDb();
        }
    }
}
