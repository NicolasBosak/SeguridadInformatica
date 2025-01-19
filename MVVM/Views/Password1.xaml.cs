using SeguridadInformatica.MVVM.ViewModel;
using SeguridadInformatica.MVVM.Models;

namespace SeguridadInformatica.MVVM.Views;

public partial class Password1 : ContentPage
{
    public Password1()
	{
		InitializeComponent();
    }
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isVerdaderoChecked = checkBoxVerdadero.IsChecked;
        bool isFalsoChecked = checkBoxFalso.IsChecked;

        if (isVerdaderoChecked && !isFalsoChecked)
        {
            await DisplayAlert("Respuesta Correcta", "¡Correcto! Compartir contraseñas es peligroso.", "OK");
            await Navigation.PopAsync(); 
            MessagingCenter.Send(this, "RespuestaCorrecta", "No Compartir Contraseñas");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Incorrecto. Compartir contraseñas sí es peligroso.", "OK");
        }
    }
}