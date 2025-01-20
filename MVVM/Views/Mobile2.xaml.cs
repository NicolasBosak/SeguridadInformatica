namespace SeguridadInformatica.MVVM.Views;

public partial class Mobile2 : ContentPage
{
	public Mobile2()
	{
		InitializeComponent();
	}
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isCorrectoChecked = checkBoxPractica1.IsChecked;
        bool isIncorrectoChecked = checkBoxPractica2.IsChecked;

        if (isCorrectoChecked && !isIncorrectoChecked)
        {
            await DisplayAlert("Respuesta Correcta", "¡Correcto!", "OK");
            await Navigation.PopAsync();
            MessagingCenter.Send(this, "RespuestaCorrecta", "Cómo Proteger mi Celular de Malware y Hacker");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el video", "OK");
        }
    }
}