﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3
{
    public interface ISerializable
    {
        string RutaArchivo{get; set;}

        // bool Deserealizar();

        bool SerealizarXML();
    }
}
