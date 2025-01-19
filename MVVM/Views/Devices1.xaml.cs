namespace SeguridadInformatica.MVVM.Views;

public partial class Devices1 : ContentPage
{
	public Devices1()
	{
		InitializeComponent();
	}
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isIncorrectoChecked = checkBoxPractica1.IsChecked;
        bool isCorrectoChecked = checkBoxPractica2.IsChecked;

        if (isCorrectoChecked && !isIncorrectoChecked)
        {
            await DisplayAlert("Respuesta Correcta", "¡Correcto!", "OK");
            await Navigation.PopAsync();
            MessagingCenter.Send(this, "RespuestaCorrecta", "Actualizaciones");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Una actualizacion del dispositivo no es solo estetica.", "OK");
        }
    }
}