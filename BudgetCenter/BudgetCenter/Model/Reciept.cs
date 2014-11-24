using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class Reciept
    {
        private BudgetCategory category;

        public BudgetCategory Category
        {
            get { return category; }
        }

        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        private List<string> tags;

        public List<string> Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        protected DateTime date;

        public DateTime Date
        {
            get { return date; }
        }

        public Reciept(BudgetCategory category, string company, decimal amount, DateTime date, List<string> tags)
        {
            this.category = category;
            this.company = company;
            this.amount = amount;
            this.date = date;
            this.tags = tags;
        }

        public void AddTag(string tag){
            Tags.Add(tag);

        }
    }
}
