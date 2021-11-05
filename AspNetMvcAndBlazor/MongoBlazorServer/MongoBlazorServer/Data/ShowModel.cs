using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoBlazorServer.Data
{
    public class ShowModel
    {
        public bool[] InStock { get; set; } = { false, false, true };
        public bool[] OnSale { get; set; } = { false, false, true };
        public bool[] Category { get; set; } = { false, false, false, false, false, false, false, true };
        public bool[] Brand { get; set; } = { false, false, false, false, false, false, true };
        public bool[] Sizes { get; set; } = { false, false, false, false, false, false, true };
        public bool[] Colors { get; set; } = { false, false, false, false, false, false, true };
        public bool[] Labels { get; set; } = { false, false, false, false, true };
        public bool[] Tags { get; set; } = { false, false, false, false, false, false, false, false, true };
        public int[] Price { get; set; } = { 0, 800 };
        public int[] Rating { get; set; } = { 0, 5 };
        public bool[] SortPrice { get; set; } = { false, false };
        public bool[] SortRating { get; set; } = { false, false };
    }
}