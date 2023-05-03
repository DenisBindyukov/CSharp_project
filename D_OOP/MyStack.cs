using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{

    public class MyStack
    {
        private object[] _items;

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }

        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new object[defaultCapacity];
        }

        public MyStack(int capacity)
        {
            _items = new object[capacity];
        }

    }
}
