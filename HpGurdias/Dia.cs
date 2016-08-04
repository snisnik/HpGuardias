using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpGurdias
{
    class Dia
    {
        DateTime date;
        String type;
        
        public Dia(int dia,int mes,int anio)
        {
            date = new DateTime(anio, mes, dia);
        }

        public DateTime Date
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

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
