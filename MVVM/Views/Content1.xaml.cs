namespace SeguridadInformatica.MVVM.Views;

public partial class Content1 : ContentPage
{
	public Content1()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "No Todo en Internet es Real");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "No es tan comun.", "OK");
        }
    }
}