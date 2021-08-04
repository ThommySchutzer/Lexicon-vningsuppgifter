using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öv2A.Models
{
    class Order
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int NumberOfDays { get; set; }
        public int Total { get; set; }
    }
}
