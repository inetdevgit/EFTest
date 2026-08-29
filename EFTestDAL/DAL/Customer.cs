using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDAL.DAL
{
    public static class Customer
    {
        public static EFTestDAL.Entity.Customer SearchById(string custId)
        { 
            using (AppDb db = new())
            {
                return db.Customers
                        .Where(x => x.CustId == custId)
                        .FirstOrDefault();
            }
        }

        public static void Save(Entity.Customer rec)
        {
            using (AppDb db = new())
            {
                Entity.Customer tmp = db.Customers
                            .Where(x => x.CustId == rec.CustId)
                            .FirstOrDefault();
                if (tmp == null)                            // not found, insert
                    db.Customers.Add(rec);
                else
                {                                           // found, update
                    tmp.CustName = rec.CustName;
                    tmp.Address = rec.Address;
                    db.Customers.Update(tmp);
                }
                db.SaveChanges();
            }

        }
        public static void Delete(string custId)
        {
            using (AppDb db = new())
            {
                Entity.Customer tmp = db.Customers
                        .Where(x => x.CustId == custId)
                        .FirstOrDefault();
                if (tmp != null)                            // not found, insert
                {
                    db.Customers.Remove(tmp);
                    db.SaveChanges();
                }
            }
        }

    }
}
