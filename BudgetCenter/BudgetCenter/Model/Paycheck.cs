using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class Paycheck
    {
        private List<Deposit> categories;
        private string name;

        protected DateTime startDate;
        protected int occurences;


        public List<Deposit> Categories
        {
            get { return categories; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Paycheck(string name)
        {
            this.name = name;
            categories = new List<Deposit>();
        }

        public Paycheck(string name, List<Deposit> categories)
        {
            this.name = name;
            this.categories = categories;
        }

        public void AddCategory(Deposit category)
        {
            this.categories.Add(category);
        }

        public decimal AddPaycheck()
        {
            decimal balance = 0;
            foreach (Deposit cat in Categories)
            {
                cat.CommitDeposit();
            }
            return balance;
        }

    }
}