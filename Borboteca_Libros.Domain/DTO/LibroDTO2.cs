﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borboteca_Libros.Domain.DTO
{
    public class LibroDTO2
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Resenia { get; set; }
        public string Editorial { get; set; }
        public string FechaDePublicacion { get; set; }
        public string Imagen { get; set; }
        public string Pach { get; set; }
        public int Precio { get; set; }
        public List<string> Generos { get; set; }
        public string NombreAutor { get; set; }
    }
}
