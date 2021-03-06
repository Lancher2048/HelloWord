﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcDemo.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Service.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
