using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTel
{
    internal class Data
    {
        int Dia;
        int Mes;

        public Data(string _data)
        {
            Dia = int.Parse(_data.Split("/")[0]);
            Mes = int.Parse(_data.Split("/")[1]);
        }

        public int getDia()
        {
            return Dia;
        }

        public int getMes()
        {
            return Mes;
        }
    }
}
