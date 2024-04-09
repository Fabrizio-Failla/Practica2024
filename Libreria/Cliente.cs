﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Gmail { get; set; }
        public Cliente(int dni, string nombre, string email)
        {
            Dni = dni;
            Nombre = nombre;
            Gmail = email;
        }
    }
}
