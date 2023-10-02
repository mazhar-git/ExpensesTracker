using ExpenseAPI.Entities;

namespace ExpenseAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ExpenseContext context){
            
            if(context.Expenses.Any()) return;

            var expenses = new List<Expense>
            {
                
                new Expense {
                    Title= "Toilet Paper",
                    Amount= "94.12",
                    ExpenseDate= "2019-01-01 10:20:05.123"
                },
                new Expense {
                    Title= "New TV",
                    Amount= "799.49",
                    ExpenseDate= "2020-04-01 10:20:05.123"
                },
                new Expense {
                    Title= "Car Insurance",
                    Amount= "294.67",
                    ExpenseDate= "2021-08-01 10:20:05.123"
                },
                new Expense {
                    Title= "New Desk (Wooden)",
                    Amount= "450",
                    ExpenseDate= "2022-07-01 10:20:05.123"
                },
                new Expense {
                    Title= "New Desk (Steel)",
                    Amount= "550",
                    ExpenseDate= "2022-09-09 10:20:05.123"
                }
            };

            foreach (var expense in expenses)
            {
                context.Expenses.Add(expense);
            }

            context.SaveChanges();
        }
    }
}