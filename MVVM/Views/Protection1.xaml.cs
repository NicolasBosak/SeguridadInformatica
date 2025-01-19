namespace SeguridadInformatica.MVVM.Views;

public partial class Protection1 : ContentPage
{
	public Protection1()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "¿Qué son las estafas en línea?");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el contenido", "OK");
        }
    }
}