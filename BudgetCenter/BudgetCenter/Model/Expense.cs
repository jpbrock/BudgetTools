using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class Expense : Reciept
    {
        private string name;
        private bool committed;

        public bool Committed
        {
            get { return committed; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Expense(string name, BudgetCategory category, string company, decimal amount, DateTime date, List<string> tags)
            : base(category, company, Math.Abs(amount), date, tags)
        {
            this.name = name;
            this.committed = false;
        }

        public BudgetCategory CommitExpense()
        {
            if (!committed)
            {
                Category.Withdraw(Amount);
                committed = true;
            }
            return Category;
        }

        public BudgetCategory RemoveExpense()
        {
            if (committed)
            {
                Category.Deposit(Amount);
                committed = false;
            }
            return Category;
        }
        
    }
}
