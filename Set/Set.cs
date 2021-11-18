using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T>, IEnumerable<T>
    {
        private HashSet<T> hashSet;

        public Set()
        {
            hashSet = new HashSet<T>();
        }

        public int Size => hashSet.Count;

        public List<T> Elements
        {
            get
            {
                List<T> elements = new List<T>();

                foreach(T item in hashSet)
                {
                    elements.Add(item);
                }

                return elements;
            }
        }

        public static ISet<T> Intersection(ISet<T> s1, ISet<T> s2)
        {
            ISet<T> result = new Set<T>();

            // do the work

            return result;
        }

        public static ISet<T> Union(ISet<T> s1, ISet<T> s2)
        {
            return null;
        }

        public void Add(ISet<T> s)
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(ISet<T> s)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
