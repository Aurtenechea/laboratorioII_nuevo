using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo2
{
    public interface ISerializacion<T>
    {
        bool guardarSerializacion(string archivo, T datos);
        bool leerSerializacion(string archivo, out T datos);
    }
}
