﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}
