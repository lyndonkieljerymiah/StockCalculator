using StockCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockCalculator.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage()
		{
			InitializeComponent();
            BindingContext = new CalculatorViewModel();
		}
	}
}