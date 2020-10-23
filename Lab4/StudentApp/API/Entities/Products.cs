using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Products : IEnumerable
    {
        List<Product> list = new List<Product>();

        public Product this[int index]
        {
            get { return list[index]; }
            set { list.Insert(index, value); }
        }
        public IEnumerator<Product> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
