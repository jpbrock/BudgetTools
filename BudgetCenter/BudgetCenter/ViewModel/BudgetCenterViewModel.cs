using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCenter
{


    public class BudgetCenterViewModel : ViewModelBase
    {
        private ObservableCollection<string> budgetCategories;
        private int selectedCategory;
        private string balance;
        public ObservableCollection<string> BudgetCategories
        {
            get { return budgetCategories; }
        }
 

        public int SelectedCategory
        {
            get { return selectedCategory; }
            set 
            { 

                if (value != null && selectedCategory.Equals(value)) { return; }

                SetProperty(ref this.selectedCategory, value);

                SelectedCategoryChanged();
            }
        }

        

        public string  Balance
        {
            get { return balance; }
            set { SetProperty(ref this.balance, value); }
        }


        private DateTime recieptDate;
        public DateTime RecieptDate
        {
            get { return recieptDate; }
            set { SetProperty(ref this.recieptDate, value); }
        }

        private List<string> tagsList;
        private string tags;

        public string Tags
        {
            get
            {
                    TagsAggregate();
                    return tags; }
            set
            {
                SetProperty(ref this.tags, value);
                TagsSplit();
            }
        }


        

        public BudgetCenterViewModel()
        {
            budgetCategories = new ObservableCollection<string>();
            budgetCategories.Add("Stuff");
            budgetCategories.Add("Items");
            selectedCategory = 0;
            balance = "$20";
            recieptDate = DateTime.Today;
            Tags = "#example#tags";

        }

        public void SelectedCategoryChanged()
        {
            if (SelectedCategory == 0)
            {
                Balance = "$20";
            }

            if (SelectedCategory == 1)
            {
                Balance = "$30";
            }
        }

        private void TagsAggregate()
        {
            StringBuilder ts = new StringBuilder("");
            foreach (string tag in tagsList)
            {
                ts.Append("#" + tag);
            }
            tags = ts.ToString();
        }

        private void TagsSplit()
        {
            char[] delim = { '#' };
            tagsList = tags.Split(delim, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
