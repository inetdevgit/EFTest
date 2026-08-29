using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDAL.Entity
{
    public partial class Product
    {
        public string ProdId { get; set; }
        public string? ProdName { get; set; }
        public string? CatId { get; set; }
        public int StockQty { get; set; } = 0;
        public int SellingPrice { get; set; } = 0;

    }
}
