﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borboteca_Libros.AccessData.Command.Repository
{
    public interface IGenericRepository
    {
        public void Add<T>(T entity) where T : class;
        public void Update<T>(T entity) where T : class;
        public void Delete<T>(int _id) where T : class;

    }
}
