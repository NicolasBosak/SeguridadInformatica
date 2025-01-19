using SeguridadInformatica.MVVM.ViewModel;
using SeguridadInformatica.MVVM.Models;

namespace SeguridadInformatica.MVVM.Views;

[QueryProperty(nameof(TaskName), "TaskName")]
public partial class Password1 : ContentPage
{
    public string TaskName { get; set; }
    public Password1()
	{
		InitializeComponent();
    }
}