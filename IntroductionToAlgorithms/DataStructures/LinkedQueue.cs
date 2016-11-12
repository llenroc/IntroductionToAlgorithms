﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms.DataStructures
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private readonly SinglyLinkendList<T> linkedList = new SinglyLinkendList<T>();
        public T Dequeue()
        {
            return linkedList.RemoveFirst();
        }

        public void Enqueue(T t)
        {
            linkedList.AddLast(t);
        }
    }
}
