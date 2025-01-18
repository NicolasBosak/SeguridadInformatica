using SeguridadInformatica.MVVM.ViewModel;

namespace SeguridadInformatica.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}