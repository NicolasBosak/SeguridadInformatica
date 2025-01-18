using SeguridadInformatica.MVVM.ViewModel;

namespace SeguridadInformatica.MVVM.Views;

public partial class TeenView : ContentPage
{
    private TeenViewModel teenViewModel = new TeenViewModel();
    public TeenView()
	{
		InitializeComponent();
        BindingContext = teenViewModel;
    }

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        teenViewModel.UpdateData();
    }
}