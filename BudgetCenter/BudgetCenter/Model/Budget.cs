using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class Budget
    {
        private string directory;
        private List<BudgetCategory> categories;
        private List<Paycheck> paychecks;
        private List<Expense> expenses;
        private List<Deposit> deposits;
    }
}
