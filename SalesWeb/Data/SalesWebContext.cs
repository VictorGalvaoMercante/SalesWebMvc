﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Models;

namespace SalesWeb.Data
{
    public class SalesWebContext : DbContext
    {
        public SalesWebContext (DbContextOptions<SalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public object SalesRecord { get; internal set; }
    }
}
