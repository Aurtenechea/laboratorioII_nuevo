using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*  Existen dos formas de serializar.
    1- Aplicar una interface a un determinado objeto, para que esta implemente
       las funciones leer/guardar que guardaran el objeto this en un archivo.
    2- Aplicar una interface a un objeto intermedio llamado genericamente como "Serializacion"
        y utilizar una instancia de este para acceder a sus metodos guardar leer que guardan/leen
        un objeto cualquiera (definido como T). */

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
