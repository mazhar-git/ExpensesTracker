using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Data
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}