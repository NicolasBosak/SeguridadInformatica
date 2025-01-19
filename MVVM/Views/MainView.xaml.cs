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
            if (taskName == "No Compartir Contraseñas")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "No Compartir Contraseñas");
                if (task != null)
                {
                    task.Completed = true; // Marcar la tarea como completada
                    mainViewModel.UpdateData(); // Actualizar el progreso
                }
            }
        });
        MessagingCenter.Subscribe<Password2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Crear Contraseñas Fuertes")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Crear Contraseñas Fuertes");
                if (task != null)
                {
                    task.Completed = true; 
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Strangers1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "No Compartir Información Personal")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "No Compartir Información Personal");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Strangers2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Identificar Qué Información es Privada")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Identificar Qué Información es Privada");
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
            if (taskName == "Identificar Señales de Alerta")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Identificar Señales de Alerta");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Devices1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Actualizaciones")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Actualizaciones");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Devices2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Antivirus")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Antivirus");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Games1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Jugar de Manera Segura")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Jugar de Manera Segura");
                if (task != null)
                {
                    task.Completed = true;
                    mainViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Games2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Proteger tu Información")
            {
                var task = mainViewModel.Tasks.FirstOrDefault(t => t.TaskName == "Proteger tu Información");
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