﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base (options) 
        {

        }

        public DbSet<Userr> users { get; set; }
    }
}