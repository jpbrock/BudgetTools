using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class BudgetCategory
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }
        public BudgetCategory(string name, decimal startingBalance)
        {
            this.name = name;
            this.balance = startingBalance;
        }

        public decimal Deposit(decimal amount)
        {
            this.balance += Math.Abs(amount);
            return balance;
        }

        public decimal Withdraw(decimal amount)
        {
            this.balance -= Math.Abs(amount);
            return balance;
        }
    }
}
