using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    public static class MiClase
    {
        public static bool validaS_N(char opcion)
        {
            bool retorno = false;

            if((opcion== 's')||(opcion== 'S'))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
