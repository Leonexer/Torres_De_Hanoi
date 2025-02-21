using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    internal class EmptyPileException : ApplicationException
    {
        public EmptyPileException()
    : base("La pila esta vacía.")
        {

        }
    }
}
