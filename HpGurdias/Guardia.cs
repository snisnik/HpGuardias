using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpGurdias
{
    class Guardia
    {
        String lugar;
        DateTime date;
        String persona;
        String tipo;

        public string Lugar
        {
            get
            {
                return lugar;
            }

            set
            {
                lugar = value;
            }
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

        public string Persona
        {
            get
            {
                return persona;
            }

            set
            {
                persona = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
