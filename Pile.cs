using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    internal class Pile
    {
        private Node Top;

        public bool PileIsEmpty()
        {
            return Top == null;
        }
        public void Push(int Numero)
        {
            Node Newnode = new Node(Numero);
            if (PileIsEmpty())
            {
                Top = Newnode;
                return;
            }
            Top.Prev = Newnode;
            Newnode.Next = Top;
            Top = Newnode;
        }

        public int Pop()
        {
            if (PileIsEmpty())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            int data = Top.Valor;
            Top = Top.Next;
            if (Top != null)
            {
                Top.Prev = null;
            }
            return data;
        }

        public int Peek()
        {
            if (PileIsEmpty())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            return Top.Valor;
        }

        public void Print()
        {
            Node Current = Top;
            while (Current != null)
            {
                Console.WriteLine(Current.Valor);
                Current = Current.Next;
            }
        }

    }
}
