using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class Deposit : Reciept
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

        public Deposit(string name, BudgetCategory category, string company, decimal amount, DateTime date, List<string> tags)
            : base(category, company, -Math.Abs(amount), date, tags)
        {
            this.name = name;
        }

        public BudgetCategory CommitDeposit()
        {
            if(!committed)
            {
                Category.Deposit(Amount);
                committed = true;
            }
            return Category;
        }

        public BudgetCategory RemoveDeposit()
        {
            if (committed)
            {
                Category.Withdraw(Amount);
                committed = false;
            }
            return Category;
        }
    }
}
