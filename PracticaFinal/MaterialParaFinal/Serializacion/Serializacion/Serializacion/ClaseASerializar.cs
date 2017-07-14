using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializacionLib;

/*  necesita para serializar. */
using System.Xml;
using System.Xml.Serialization;





namespace Serializacion
{
    /*  implementa opcion uno para serializar.  */
    class ClaseASerializar : ISerializar1<ClaseASerializar>
    {
        bool guardarSerializacion(string archivo, ClaseASerializar datos)
        {
            return true;
        }
       



    }
}
