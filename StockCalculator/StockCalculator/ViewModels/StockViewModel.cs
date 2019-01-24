using StockCalculator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StockCalculator.ViewModels
{
    public class StockViewModel : BaseViewModel
    {

        #region Fields
        public ObservableCollection<Stock> Stocks { get; set; }
        #endregion

        public StockViewModel()
        {
            Title = "List of Stock";
        }

       

    }
}
