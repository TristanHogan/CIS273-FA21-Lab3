using System;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T> 
    {
        public Set()
        {
        }

        public int Size => throw new NotImplementedException();

        public List<T> Elements => throw new NotImplementedException();

        public static ISet<T> Intersection(ISet<T> s1, ISet<T> s2)
        {
            return null;
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
    }
}
