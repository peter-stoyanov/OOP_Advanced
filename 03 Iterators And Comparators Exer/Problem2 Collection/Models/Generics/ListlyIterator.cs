using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem2_Collection.Models.Generics
{
    public class ListlyIterator<T> : IEnumerable<T>
    {
        private IList<T> data;
        private int index;

        public ListlyIterator(IList<T> items)
        {
            this.data = items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
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