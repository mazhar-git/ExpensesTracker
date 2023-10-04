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

        [HttpGet("{id}", Name ="GetExpense")]
        public async Task<ActionResult<Expense>> GetExpense(int id){
            return await _context.Expenses.FindAsync(id);
        }

        [HttpPost]
        [ActionName("AddExpense")]
        public async Task<ActionResult<Expense>> AddExpense(Expense expense){
            _context.Expenses.Add(expense);

            var result = await _context.SaveChangesAsync() > 0;

            if(result) return CreatedAtRoute("GetExpense", new {Id = expense.Id}, expense);

            return BadRequest(new ProblemDetails{Title = "Problem in creating new Expense"});
        }
    }
}