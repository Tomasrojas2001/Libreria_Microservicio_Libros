﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borboteca_Libros.Domain.Entities
{
    public class LibroGenero
    {
        public int Id { get; set; }
        public int LibroId { get; set; }
        public int GeneroId { get; set; }

        public Genero Genero { get; set; }
        public Libro Libro { get; set; }
    }
}
