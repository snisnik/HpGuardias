using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpGurdias
{
   
    class Lugar
    {
        DateTime[] date;
        String nombre;

        public Lugar(string n, DateTime[] d)
        {
            nombre = n;
            date = d;
        }
        public DateTime[] Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
