using SeguridadInformatica.MVVM.ViewModel;
using SeguridadInformatica.MVVM.Models;

namespace SeguridadInformatica.MVVM.Views;

public partial class MainView : ContentPage
{
    private MainViewModel mainViewModel = new MainViewModel();

    public MainView()
    {
        InitializeComponent();
        BindingContext = mainViewModel;

        // Suscribirse al mensaje de respuesta correcta
        MessagingCenter.Subscribe<Password1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "No Compartir Contrase�as")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "No Compartir Contrase�as");
                if (task != null)
                {
                    task.Completed = true; // Marcar la tarea como completada
                    mainViewModel.UpdateData(); // Actualizar el progreso
                }
            }
        });
    }

    // M�todo para manejar la actualizaci�n de los CheckBox
    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        mainViewModel.UpdateData();
    }

    private async void OnLabelTapped(object sender, EventArgs e)
    {
        if (sender is Label label && label.BindingContext is MyTask task)
        {
            await mainViewModel.NavigateToTaskPage(task.TaskName);
        }
    }
}