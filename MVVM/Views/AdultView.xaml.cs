using SeguridadInformatica.MVVM.Models;
using SeguridadInformatica.MVVM.ViewModel;

namespace SeguridadInformatica.MVVM.Views;

public partial class AdultView : ContentPage
{
    private AdultViewModel adultViewModel = new AdultViewModel();
    public AdultView()
    {
        InitializeComponent();
        BindingContext = adultViewModel;
    }

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        adultViewModel.UpdateData();
    }
    private async void OnLabelTapped(object sender, EventArgs e)
    {
        if (sender is Label label && label.BindingContext is MyTaskAdult task)
        {
            await adultViewModel.NavigateToTaskPage(task.TaskName);
        }
    }
}