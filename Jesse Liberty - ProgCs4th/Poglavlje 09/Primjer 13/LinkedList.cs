using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingConstraints
{
    class LinkedList<T> where T: IComparable<T>
    {
        //polje clanovi 
        private Node<T> headNode = null;

        //svojstva
        //indekser
        public T this[int index]
        {
            get
            {
                int ctr = 0;
                Node<T> node = headNode;

                while(node != null && ctr <= index)
                {
                    if(ctr == index)
                    {
                        return node.Data;
                    }
                    else
                    {
                        node = node.Next;
                    }

                    ++ctr;
                }

                throw new ArgumentOutOfRangeException();
            }
        }

        //metode
        public void Add(T data)
        {
            if(headNode == null)
            {
                headNode = new Node<T>(data);
            }
            else
            {
                headNode = headNode.Add(new Node<T>(data));
            }
        }

        public override string ToString()
        {
            if(this.headNode != null)
            {
                return this.headNode.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
