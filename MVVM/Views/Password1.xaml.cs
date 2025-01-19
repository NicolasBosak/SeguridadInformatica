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
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isVerdaderoChecked = checkBoxVerdadero.IsChecked;
        bool isFalsoChecked = checkBoxFalso.IsChecked;

        // Verificar si la respuesta es correcta
        if (isVerdaderoChecked && !isFalsoChecked)
        {
            // La respuesta es correcta, navega a la MainView y marca el checkbox correspondiente
            await DisplayAlert("Respuesta Correcta", "�Correcto! Compartir contrase�as es peligroso.", "OK");

            // Regresar a la MainView y pasar un par�metro indicando que la respuesta es correcta
            await Navigation.PopAsync(); // Regresar a la MainView

            // Aqu� se marca el checkbox correspondiente en la MainView
            MessagingCenter.Send(this, "RespuestaCorrecta", "No Compartir Contrase�as");
        }
        else
        {
            // La respuesta es incorrecta
            await DisplayAlert("Respuesta Incorrecta", "Incorrecto. Compartir contrase�as s� es peligroso.", "OK");
        }
    }
}