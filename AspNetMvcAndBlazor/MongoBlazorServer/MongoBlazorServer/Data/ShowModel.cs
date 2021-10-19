using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.Data
{
    public class ShowModel
    {
        public bool ShowInStockTrue { get; set; } = false;
        public bool ShowInStockFalse { get; set; } = false;
        public bool ShowInStockAll { get; set; } = true;
        public bool ShowOnSaleTrue { get; set; } = false;
        public bool ShowOnSaleFalse { get; set; } = false;
        public bool ShowOnSaleAll { get; set; } = true;
        public bool ShowCategoryMen { get; set; } = false;
        public bool ShowCategoryWomen { get; set; } = false;
        public bool ShowCategoryKids { get; set; } = false;
        public bool ShowCategoryHats { get; set; } = false;
        public bool ShowCategoryShoes { get; set; } = false;
        public bool ShowCategorySunglasses { get; set; } = false;
        public bool ShowCategoryWatches { get; set; } = false;
        public bool ShowCategoryAll { get; set; } = true;

    }
}
