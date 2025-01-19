namespace SeguridadInformatica.MVVM.Views;

public partial class Content2 : ContentPage
{
	public Content2()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Identificar Señales de Alerta");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "No deberias abrir cualquier enlace externo.", "OK");
        }
    }
}