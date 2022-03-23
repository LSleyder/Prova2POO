using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTel
{
    class NohLista
    {
        private NohLista previo;
        private Contato data;
        private NohLista next;

        public NohLista()
        {
            previo = null;
            next = null;
        }

        public NohLista(Contato n)
        {
            previo = null;
            data = n;
            next = null;
        }

        public NohLista getPrevio()
        {
            return previo;
        }

        public void setPrevio(NohLista _previo)
        {
            previo = _previo;
        }

        public Contato getData()
        {
            return data;
        }

        public void setData(Contato _data)
        {
            data = _data;
        }


        public NohLista getNext()
        {
            return next;
        }

        public void setNext(NohLista _next)
        {
            next = _next;
        }
    }
}