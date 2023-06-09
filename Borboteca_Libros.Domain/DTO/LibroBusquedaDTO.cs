﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Borboteca_Libros.Domain.Entities;
namespace Borboteca_Libros.Domain.DTO
{
    public class LibroBusquedaDTO
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Resenia { get; set; }
        public string Editorial { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public string NombreGenero { get; set; }
        public string Imagen { get; set; }
        public int Precio { get; set; }
        public string NombreCompleto { get; set; }
    }
}
