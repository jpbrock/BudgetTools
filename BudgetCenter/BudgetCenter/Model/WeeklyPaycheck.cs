using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter.Model
{
    public class WeeklyPaycheck : Paycheck
    {
        private int interval;

        public WeeklyPaycheck(string name, List<Deposit> categories, DateTime start, int weeksBetween)
            : base(name, categories)
        {
            this.interval = weeksBetween;
            this.startDate = start;
            this.occurences = 0;
        }

        public WeeklyPaycheck(string name, List<Deposit> categories, DateTime start, int weeksBetween, int occurences)
            : base(name)
        {
            this.interval = weeksBetween;
            this.startDate = start;
            this.occurences = occurences; 
        }
    }
}
