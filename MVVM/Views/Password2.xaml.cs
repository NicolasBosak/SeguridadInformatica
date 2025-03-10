namespace SeguridadInformatica.MVVM.Views;

public partial class Password2 : ContentPage
{
	public Password2()
	{
		InitializeComponent();
	}
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isIncorrectoChecked = checkBoxPractica1.IsChecked;
        bool isCorrectoChecked = checkBoxPractica2.IsChecked;

        if (isCorrectoChecked && !isIncorrectoChecked)
        {
            await DisplayAlert("Respuesta Correcta", "�Correcto!", "OK");
            await Navigation.PopAsync();
            MessagingCenter.Send(this, "RespuestaCorrecta", "Crear Contrase�as Fuertes");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Esto genera contrase�a debil.", "OK");
        }
    }
}