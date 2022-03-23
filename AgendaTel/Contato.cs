using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTel
{
    internal class Contato
    {
        int Codigo;
        string Nome;
        string Telefone;
        string Celular;
        string email;
        Data dataAniversario;
        
        public Contato(int _Codigo, string _Nome, string _Telefone, string _Celular, string _email, Data _dataAniversario)
        {
            Codigo = _Codigo;
            Nome = _Nome;
            Telefone = _Telefone;    
            Celular = _Celular;
            email = _email;
            dataAniversario = _dataAniversario;
        }
        public int getCodigo()
        {
            return Codigo;
        }

        public string getNome()
        {
            return Nome;
        }
        public string getTelefone()
        {
            return Telefone;
        }
        public string getCelular()
        {
            return Celular;
        }
        public string getEmail()
        {
            return email;
        }
        public Data getNiver()
        {
            return dataAniversario;
        }
    }
}
