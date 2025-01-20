namespace SeguridadInformatica.MVVM.Views;

public partial class Wifi2 : ContentPage
{
	public Wifi2()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "¿Cómo Protegerme para Navegar Seguro al usar una Red WiFi Pública?");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el video", "OK");
        }
    }
}