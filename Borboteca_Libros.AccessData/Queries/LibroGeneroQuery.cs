﻿using Borboteca_Libros.AccessData.Queries.Repository;
using Borboteca_Libros.Domain.DTO;
using Cqrs.Repositories.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryFactory = SqlKata.Execution.QueryFactory;

namespace Borboteca_Libros.AccessData.Queries
{
    public class LibroGeneroQuery : ILibroGeneroQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler SqlKata;
        public LibroGeneroQuery(IDbConnection connection, Compiler sqlKata)
        {
            this.connection = connection;
            this.SqlKata = sqlKata;
        }

        public List<LibroGeneroDTO> PedirGeneroLibro(Guid libroId)
        {
            var db = new QueryFactory(connection, SqlKata);

            var generos = db.Query("LibroGenero")
                .Select("GeneroId")
                .Where("LibroId", "=", libroId)
                .Get<LibroGeneroDTO>().ToList();

            return generos;
        }

    }
}
