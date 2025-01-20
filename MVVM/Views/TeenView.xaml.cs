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
        MessagingCenter.Subscribe<Teen1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Qué es el Pishing?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Qué es el Pishing?");
                if (task != null)
                {
                    task.Completed = true; // Marcar la tarea como completada
                    teenViewModel.UpdateData(); // Actualizar el progreso
                }
            }
        });
        MessagingCenter.Subscribe<Teen2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Como evitar el Pishing")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Como evitar el Pishing");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen3, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Porque son importantes las contraseñas?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Porque son importantes las contraseñas?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen4, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Como Crear una Contraseñas Segura")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Como Crear una Contraseñas Segura");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen5, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué importa la privacidad en redes?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Por qué importa la privacidad en redes?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen6, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Privacidad en Redes Sociales")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Privacidad en Redes Sociales");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen7, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué cuidar nuestros dispositivos?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Por qué cuidar nuestros dispositivos?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen8, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Apps Maliciosas")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Apps Maliciosas");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen9, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Que es el ciberacoso?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Que es el ciberacoso?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen10, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Como Evitar el Ciberacoso")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Como Evitar el Ciberacoso");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen11, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué importa lo que descargamos?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Por qué importa lo que descargamos?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen12, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Identificar Sitios Poco Confiables")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Identificar Sitios Poco Confiables");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen13, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué son necesarias las actualizaciones?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Por qué son necesarias las actualizaciones?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        }); 
        MessagingCenter.Subscribe<Teen14, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Actualizaciones de Apps")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Actualizaciones de Apps");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen15, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Que es la Ingenieria Social?")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "¿Que es la Ingenieria Social?");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Teen16, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Como funciona la Ingenieria Social")
            {
                var task = teenViewModel.TasksTeen.FirstOrDefault(t => t.TaskName == "Como funciona la Ingenieria Social");
                if (task != null)
                {
                    task.Completed = true;
                    teenViewModel.UpdateData();
                }
            }
        });
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