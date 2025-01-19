namespace SeguridadInformatica.MVVM.Views;

public partial class Strangers1 : ContentPage
{
	public Strangers1()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "No Compartir Información Personal");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Esto es muy peligroso.", "OK");
        }
    }
}