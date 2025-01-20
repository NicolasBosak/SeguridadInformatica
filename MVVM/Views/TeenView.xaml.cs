using SeguridadInformatica.MVVM.Models;
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
    private async void OnLabelTapped(object sender, EventArgs e)
    {
        if (sender is Label label && label.BindingContext is MyTaskTeen task)
        {
            await teenViewModel.NavigateToTaskPage(task.TaskName);
        }
    }
}