﻿using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace OWTodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
