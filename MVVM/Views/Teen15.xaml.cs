namespace SeguridadInformatica.MVVM.Views;

public partial class Teen15 : ContentPage
{
	public Teen15()
	{
		InitializeComponent();
	}
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isCorrectoChecked = checkBoxOption1.IsChecked;
        bool isIncorrectoChecked = checkBoxOption2.IsChecked;

        if (isCorrectoChecked && !isIncorrectoChecked)
        {
            await DisplayAlert("Respuesta Correcta", "¡Correcto!", "OK");
            await Navigation.PopAsync();
            MessagingCenter.Send(this, "RespuestaCorrecta", "¿Que es la Ingenieria Social?");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el contenido", "OK");
        }
    }
}