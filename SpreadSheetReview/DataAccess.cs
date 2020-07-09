using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadSheetReview
{
    public abstract class DataAccess
    {
        public string ConnectionString { get; set; }

        public abstract void GetProducts();
        public abstract void CreateProduct();
    }
}
