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
            if (taskName == "�Qu� son las estafas en l�nea?")
            {
                var task = adultViewModel.TasksAdult.FirstOrDefault(t => t.TaskName == "�Qu� son las estafas en l�nea?");
                if (task != null)
                {
                    task.Completed = true; // Marcar la tarea como completada
                    adultViewModel.UpdateData(); // Actualizar el progreso
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