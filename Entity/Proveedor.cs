﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public Proveedor(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
