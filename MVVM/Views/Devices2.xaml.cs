namespace SeguridadInformatica.MVVM.Views;

public partial class Devices2 : ContentPage
{
	public Devices2()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Antivirus");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "No hay que dejarse llevar por el sufijo ware.", "OK");
        }
    }
}