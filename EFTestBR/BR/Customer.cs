using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFTestBR.BR
{
    public static class Customer
    {
        public static void Save(string cid, string name, string addr)
        {
            if (String.IsNullOrEmpty(cid))
            {
                throw new ArgumentException("Customer ID cannot be null or empty.");
            }
            EFTestDAL.Entity.Customer rec = new EFTestDAL.Entity.Customer();
            rec.CustId = cid;
            rec.CustName= name;
            rec.Address = addr;
            EFTestDAL.DAL.Customer.Save(rec);
        }
        public static void Delete(string custId)
        {
            if (String.IsNullOrEmpty(custId))
            {
                throw new ArgumentException("Customer ID cannot be null or empty.");
            }
            EFTestDAL.DAL.Customer.Delete(custId);
        }
        public static EFTestDAL.Entity.Customer SearchById(string custId)
        {
            if (String.IsNullOrEmpty(custId))
            {
                throw new ArgumentException("Customer ID cannot be null or empty.");
            }
            return EFTestDAL.DAL.Customer.SearchById(custId);
        }
    }
}