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
        MessagingCenter.Subscribe<Protection1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Qué son las estafas en línea?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Qué son las estafas en línea?");
                if (task != null)
                {
                    task.Completed = true; // Marcar la tarea como completada
                    adultViewModel.UpdateData(); // Actualizar el progreso
                }
            }
        });
        MessagingCenter.Subscribe<Protection2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Como Evitar Estafas en Internet")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Como Evitar Estafas en Internet");
                if (task != null)
                {
                    task.Completed = true; 
                    adultViewModel.UpdateData(); 
                }
            }
        });
        MessagingCenter.Subscribe<Security2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Como crear contraseñas fuertes")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Como crear contraseñas fuertes");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Privacity2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Recomendaciones para proteger tu información")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Recomendaciones para proteger tu información");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Mobile2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Cómo Proteger mi Celular de Malware y Hacker")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Cómo Proteger mi Celular de Malware y Hacker");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Pishing2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Cómo Evitar Ataques de Phishing")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Cómo Evitar Ataques de Phishing");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Software2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Ventajas y Desventaja de Actualizar")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Ventajas y Desventaja de Actualizar");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Security1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué son importantes las contraseñas fuertes?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Por qué son importantes las contraseñas fuertes?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Privacity1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Riesgos de Compartir Demasiado en Redes Sociales")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Riesgos de Compartir Demasiado en Redes Sociales");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Mobile1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué es importante proteger tu celular?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Por qué es importante proteger tu celular?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Pishing1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Qué es el phishing?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Qué es el phishing?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Software1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Por qué son importantes las actualizaciones?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Por qué son importantes las actualizaciones?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Shopp1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Cómo Comprar de Forma Segura en Internet")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Cómo Comprar de Forma Segura en Internet");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Shopp2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Cómo evitar fraudes en compras por internet?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Cómo evitar fraudes en compras por internet?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Wifi1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "Riesgos de Usar Redes Wi-Fi Abiertas")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "Riesgos de Usar Redes Wi-Fi Abiertas");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Wifi2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Cómo Protegerme para Navegar Seguro al usar una Red WiFi Pública?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Cómo Protegerme para Navegar Seguro al usar una Red WiFi Pública?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Cloud1, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "¿Qué es la nube?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "¿Qué es la nube?");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
        MessagingCenter.Subscribe<Cloud2, string>(this, "RespuestaCorrecta", (sender, taskName) =>
        {
            if (taskName == "La Seguridad en la Nube")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "La Seguridad en la Nube");
                if (task != null)
                {
                    task.Completed = true;
                    adultViewModel.UpdateData();
                }
            }
        });
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