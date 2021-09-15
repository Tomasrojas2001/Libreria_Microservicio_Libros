﻿using Borboteca_Libros.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borboteca_Libros.AccessData.Configurations
{
    public class ConfigCarro
    {
        public ConfigCarro(EntityTypeBuilder<Carro> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Activo).IsRequired();
            
            entityTypeBuilder.Property(x => x.Valor).IsRequired();

           
        }
    }
}
