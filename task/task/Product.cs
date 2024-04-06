using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public  class Product
    {
        public int No { get; set; }
        private static int _no;
        public string Name { get; set; }
        public double Price { get; set; }
        public Core.Type Type { get; set; }

        public Product()
        {
            _no = ++No;
        }

        public override string ToString()
        {
            return $"{No} {Name} {Price} {Type}";
        }
    }
}
