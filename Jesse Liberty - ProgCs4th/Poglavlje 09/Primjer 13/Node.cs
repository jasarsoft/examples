using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingConstraints
{
    class Node<T> : IComparable<Node<T>> where T : IComparable<T>
    {
        //clanovi polja
        private T data;
        private Node<T> next = null;
        private Node<T> prev = null;

        //konstruktor
        public Node(T data)
        {
            this.data = data;
        }

        //svojstva
        public T Data { get { return this.data; } }

        public Node<T> Next
        {
            get { return this.next; }
        }

        public int CompareTo(Node<T> rhs)
        {
            //funkcionira zbog ogranicenja
            return data.CompareTo(rhs.data);
        }

        public bool Equals(Node<T> rhs)
        {
            return this.data.Equals(rhs.Data);
        }

        //metode
        public Node<T> Add(Node<T> newNode)
        {
            if(this.CompareTo(newNode) > 0) //ide prije mene
            {
                newNode.next = this; //novi cvor pokazuje na mene

                //ako imam predhodno postavi ih da pokazuju na novi cvor kao svoj sljedeci
                if(this.prev != null)
                {
                    this.prev.next = newNode;
                    newNode.prev = this.prev;
                }

                //postavlja prev u tekucem cvoru da pokazuje na novi cvor
                this.prev = newNode;

                //vraca newNode u slucaju da je to novo zaglavlje
                return newNode;
            }
            else //ide nakon mene
            {
                //ako imam sljedeci, prosljedjuje novi cvor na usporedjivanje
                if(this.next != null)
                {
                    this.next.Add(newNode);
                }

                //nemam sljedeci pa postavim novi cvor
                //da bude moj sljedeci i postavi njegov prev da pokazuje na mene
                else
                {
                    this.next = newNode;
                    newNode.prev = this;
                }

                return this;
            }
        }

        public override string ToString()
        {
            string output = data.ToString();

            if(next != null)
            {
                output += ", " + next.ToString();
            }

            return output;
        }
    }
}
