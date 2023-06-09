﻿using Borboteca_Libros.Application.Services;
using Borboteca_Libros.Domain.DTO;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borboteca_Libros.API.Controllers
{
    [ApiController]
    [Route("api/Autor")]
    public class AutorController : Controller
    {
        private readonly IAutorService _service;
        public AutorController(IAutorService service)
        {
            this._service = service;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public IActionResult Post(AutorDTO autor)
        {
            try
            {
                return new JsonResult(_service.CrearAutor(autor)) { StatusCode = 201 };
            }
            catch (Exception)
            {
                return BadRequest(new { error = "no se pudo crear al autor" });
            }
        }

        [HttpGet]

        public IActionResult GetAutores()
        {
            try
            {
                return new JsonResult(_service.PedirAutor()) { StatusCode = 200 };
            }
            catch (Exception)
            {
                return BadRequest(new { error = "no se pudo obtener la lista de autores." });
            }
        }
        [HttpGet]
        [Route("GetPorid")]
        public IActionResult GetAutoresPorid(int id)
        {
            try
            {
                return new JsonResult(_service.PedirAutorPorid(id)) { StatusCode = 200 };
            }
            catch (Exception)
            {
                return BadRequest(new { error = "no se pudo obtener el autor por id." });
            }
        }
        [HttpGet]
        [Route("GetPorNombre")]
        public IActionResult GetAutoresPorNombre(string nombre)
        {
            try
            {
                return new JsonResult(_service.PedirAutorPorNombre(nombre)) { StatusCode = 200 };
            }
            catch (Exception)
            {
                return BadRequest(new { error = "no se pudo obtener la lista de autores por nombre." });
            }
        }
        
    }
}
