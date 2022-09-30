﻿using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd
{
    public class AplicationDbContext : DbContext

    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
        public DbSet<Car>   Car{get; set; }
    }
}
