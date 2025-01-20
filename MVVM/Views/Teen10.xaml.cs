namespace SeguridadInformatica.MVVM.Views;

public partial class Teen10 : ContentPage
{
	public Teen10()
	{
		InitializeComponent();
	}
    private async void OnEvaluateAnswerClicked(object sender, EventArgs e)
    {
        bool isIncorrectoChecked = checkBoxOption1.IsChecked;
        bool isCorrectoChecked = checkBoxOption2.IsChecked;

        if (isCorrectoChecked && !isIncorrectoChecked)
        {
            await DisplayAlert("Respuesta Correcta", "�Correcto!", "OK");
            await Navigation.PopAsync();
            MessagingCenter.Send(this, "RespuestaCorrecta", "Como Evitar el Ciberacoso");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el contenido", "OK");
        }
    }
}