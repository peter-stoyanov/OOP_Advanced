using System;
using System.Collections.Generic;

namespace Problem1_ListlyIterator.Models.Generics
{
    public class ListlyIterator<T>
    {
        private int index;
        private IList<T> data;

        public ListlyIterator(IList<T> items)
        {
            this.data = items;
        }

        public bool HasNext()
        {
            if ((this.index + 1) < this.data.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (this.data.Count > 0)
            {
                Console.WriteLine(this.data[this.index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}