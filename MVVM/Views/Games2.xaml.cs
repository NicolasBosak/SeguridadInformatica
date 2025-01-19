namespace SeguridadInformatica.MVVM.Views;

public partial class Games2 : ContentPage
{
	public Games2()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Proteger tu Información");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "No deberias compartir infomracion importante con nadie en internet.", "OK");
        }
    }
}