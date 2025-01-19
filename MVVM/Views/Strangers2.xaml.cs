namespace SeguridadInformatica.MVVM.Views;

public partial class Strangers2 : ContentPage
{
	public Strangers2()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Identificar Qué Información es Privada");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Esto es muy peligroso.", "OK");
        }
    }
}