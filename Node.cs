using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    internal class Node
    {
        public Node Prev;
        public Node Next;
        public int Valor;

        public Node(int valor, Node prev, Node next)
        {
            Prev = prev;
            Next = next;
            Valor = valor;
        }

        public Node(int Valor, Node Next)
        {
            this.Valor = Valor;
            this.Prev = Next;
            this.Next = Next;
        }

        public Node(int Valor)
        {
            this.Valor = Valor;
            this.Prev = null;
        }

        public Node()
        {
            this.Valor = 0;
            this.Prev = null;
        }

    }
}
