namespace SeguridadInformatica.MVVM.Views;

public partial class Games1 : ContentPage
{
	public Games1()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Jugar de Manera Segura");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "No deberias compartir infomracion importante con nadie en internet.", "OK");
        }
    }
}