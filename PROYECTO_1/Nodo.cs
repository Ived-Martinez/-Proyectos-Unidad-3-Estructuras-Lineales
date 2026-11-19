using PROYECTO_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_1
{
    public class Nodo
    {
        public Paciente Datos;
        public Nodo Siguiente;

        public Nodo(Paciente paciente)
        {
            Datos = paciente;
            Siguiente = null;
        }

    }
}
