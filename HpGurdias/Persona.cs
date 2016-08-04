using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpGurdias
{
    class Persona
    {
        String name;
        Int32 vc;
        Int32 doce;

        public Persona()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Vc
        {
            get
            {
                return vc;
            }

            set
            {
                vc = value;
            }
        }

        public int Doce
        {
            get
            {
                return doce;
            }

            set
            {
                doce = value;
            }
        }
    }
}
