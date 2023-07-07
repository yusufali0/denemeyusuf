﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Devlet", Price = 100 },
                new Book { Id = 2, Title = "Olasılıksız", Price = 200 },
                new Book { Id = 3, Title = "Suç Ve Ceza", Price = 450 }
            );
        }
    }
}
