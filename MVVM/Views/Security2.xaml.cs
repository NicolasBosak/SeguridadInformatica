namespace SeguridadInformatica.MVVM.Views;

public partial class Security2 : ContentPage
{
	public Security2()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Como crear contraseñas fuertes");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el video", "OK");
        }
    }
}