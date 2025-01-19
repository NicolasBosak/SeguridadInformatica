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
        MessagingCenter.Subscribe<Password2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Crear Contrase�as Fuertes")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Crear Contrase�as Fuertes");
                if (task != null)
                {
                    task.Completed = true; 
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Strangers1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "No Compartir Informaci�n Personal")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "No Compartir Informaci�n Personal");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Strangers2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Identificar Qu� Informaci�n es Privada")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Identificar Qu� Informaci�n es Privada");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Content1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "No Todo en Internet es Real")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "No Todo en Internet es Real");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Content2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Identificar Se�ales de Alerta")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Identificar Se�ales de Alerta");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
    }

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