using StockCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockCalculator.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent();
			BindingContext = new StockViewModel();
		}
	}
}