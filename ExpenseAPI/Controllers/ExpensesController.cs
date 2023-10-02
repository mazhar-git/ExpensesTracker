using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseAPI.Data;
using ExpenseAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Controllers
{
    [ApiController]
    [Route("expenseapi/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly ExpenseContext _context;
        
        public ExpensesController(ExpenseContext context){
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Expense>>> GetExpense(){
            return await _context.Expenses.ToListAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id){
            return await _context.Expenses.FindAsync(id);
        }
    }
}