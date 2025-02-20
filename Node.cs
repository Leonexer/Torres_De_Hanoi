using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    internal class Node
    {
        public Node Next;
        public int Valor;
        public Node(int Valor, Node Next)
        {
            this.Valor = Valor;
            this.Next = Next;
        }

        public Node(int Valor)
        {
            this.Valor = Valor;
            this.Next = null;
        }

        public Node()
        {
            this.Valor = 0;
            this.Next = null;
        }

    }
}
