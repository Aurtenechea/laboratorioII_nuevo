using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionLib
{
    /*  Metodo Uno */
    public interface ISerializar1 <T>
    {
        //bool guardarSerializacion(string archivo, T datos);

        //bool leerSerializacion(string archivo, out T datos);

        bool guardarSerializacion();

        bool leerSerializacion();
    
    
    }
}
