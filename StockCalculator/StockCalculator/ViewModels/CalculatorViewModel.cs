using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StockCalculator.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        #region Fields
        private decimal _buyEntry;
        public decimal BuyEntry
        {
            get { return _buyEntry; }
            set
            {
                if (_buyEntry != value)
                {
                    _buyEntry = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _sellEntry;
        public decimal SellEntry
        {
            get { return _sellEntry; }
            set
            {
                if (_sellEntry != value)
                {
                    _sellEntry = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _lotEntry;
        public int LotEntry
        {
            get { return _lotEntry; }
            set
            {
                if (_lotEntry != value)
                {
                    _lotEntry = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _brokerCharges;
        public decimal BrokerCharges
        {
            get { return _brokerCharges; }
            set
            {
                if (_brokerCharges != value)
                {
                    _brokerCharges = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _taxIncludedCharges;
        public decimal TaxIncludeCharges
        {
            get { return _taxIncludedCharges; }
            set
            {
                if (_taxIncludedCharges != value)
                {
                    _taxIncludedCharges = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _totalProfit;
        public decimal TotalProfit
        {
            get { return _totalProfit; }
            private set
            {
                if (_totalProfit != value)
                {
                    _totalProfit = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        public CalculatorViewModel()
        {
            Title = "Stock Calculator";
            BuyEntry = 0;
            SellEntry = 0;
            LotEntry = 0;
            BrokerCharges = 0;
            TaxIncludeCharges = 0;
            TotalProfit = 0;
        }

        Command _calculateStockCommand;
        public Command CalculateStockCommand
        {
            get
            {
                return _calculateStockCommand ?? (_calculateStockCommand = new Command(async () => await CalculateStock()));
            }
        }

        private async Task CalculateStock()
        {
            await Task.Factory.StartNew(() =>
            {
                TotalProfit = (SellEntry - BuyEntry) * LotEntry;
            });
        }
    }
}
