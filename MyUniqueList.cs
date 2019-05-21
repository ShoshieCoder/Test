﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mivhan
{
    class MyUniqueList<T>
    {
        List<T> list = new List<T>();

        public MyUniqueList()
        {

        }

        public bool Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }
            throw new IteamAlreadyExcistException("Item already exicst!");
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }
            throw new IteamNotFoundException("Item not found");
        }

        public T Peek(int index)
        {
            if(this.list.Count <= index)
            {
                throw new IndexOutOfRangeException("Out of range!");
            }
            return list[index];
        }

        public T this[int index]
        {
            get
            {
                if (this.list.Count <= index)
                {
                    throw new IndexOutOfRangeException("Out of range!");
                }
                return this.list[index];
            }
            set
            {
                if (list[index].Equals(value))
                    return;
                if (list.Contains(value))
                    return;
                if (this.list.Count <= index)
                    throw new IndexOutOfRangeException();
                list[index] = value;
            }
        }
    }
}
