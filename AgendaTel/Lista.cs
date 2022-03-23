using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTel
{
    class Lista
    {
        private NohLista INICIO;
        private NohLista FIM;

        public Lista() 
        {
            INICIO = null;
            FIM = null;
        }

        public bool estaVazia()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public void Inserir(Contato n)
        {
            NohLista newNoh = new NohLista(n);

            if (estaVazia()) 
            {
                INICIO = newNoh;
                FIM = newNoh;
            }
            else
            {
                Contato inicio = INICIO.getData();
                Contato fim = FIM.getData();
                if (n.getCodigo() < inicio.getCodigo())
                {
                    INICIO.setPrevio(newNoh);
                    newNoh.setNext(INICIO);
                    INICIO = newNoh;
                }
                else if (n.getCodigo() > fim.getCodigo())
                {   
                    
                    FIM.setNext(newNoh);
                    newNoh.setPrevio(FIM);
                    FIM = newNoh;
                }
                else
                {
                    NohLista temp = INICIO;
                    while (temp != null) 
                    {
                        Contato codigo = temp.getData();
                        if (n.getCodigo() < codigo.getCodigo())
                        {
                            newNoh.setNext(temp.getPrevio());
                            temp.getPrevio().setNext(newNoh);
                            newNoh.setPrevio(temp.getPrevio());
                            temp.setNext(newNoh);
                            break;
                        }
                        temp = temp.getNext();
                    }
                }
            }
        }

        public Boolean Remover(string nome)
        {
            NohLista foundnoh = INICIO;

            string primeiro = nome.Split(" ")[0];

            while (foundnoh != null)
            {
                if (foundnoh.getData().getNome().Split(" ")[0].Equals(primeiro))
                {
                    if (foundnoh == INICIO)
                    {
                        INICIO = INICIO.getNext();
                        if (INICIO != null)
                        {
                            INICIO.setPrevio(null);
                            foundnoh = INICIO;
                        }
                        else
                        {
                            foundnoh = null;
                        }
                    }

                    else if (foundnoh == FIM)
                    {
                        FIM = FIM.getPrevio();
                        foundnoh = null;
                    }

                    else
                    {
                        (foundnoh.getPrevio()).setNext(foundnoh.getNext());
                        (foundnoh.getNext()).setPrevio(foundnoh.getPrevio());
                    }
                    return true;
                }
                else
                    foundnoh = foundnoh.getNext();
            }
            return false;
        }

        public NohLista Buscar(int codigo)
        {
            NohLista foundNoh = INICIO;
            while (foundNoh != null) 
            {
                int foundcod = foundNoh.getData().getCodigo();
                if (codigo == foundcod) 
                    return (foundNoh);
                else
                    foundNoh = foundNoh.getNext();
            }
            return null;
        } 

       

    }
}
