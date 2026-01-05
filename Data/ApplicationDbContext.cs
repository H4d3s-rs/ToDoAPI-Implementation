using System;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.Models;

namespace ToDoAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<ItemModel> Items { get; set; }

}
