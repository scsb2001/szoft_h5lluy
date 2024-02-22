using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    
    internal class Row<K, V>
    {
        private K key;
        private V val;

        public K Key
        {
            get { return key; }
            set { key = value; }
        }

        public V Value
        {
            get { return val; }
            set { val = value; }
        }

        public Row(K key, V val)
        {
            this.key = key;
            this.val = val;
        }
    }
}
