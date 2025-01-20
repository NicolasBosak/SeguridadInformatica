namespace SeguridadInformatica.MVVM.Views;

public partial class Teen16 : ContentPage
{
	public Teen16()
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
            MessagingCenter.Send(this, "RespuestaCorrecta", "Como funciona la Ingenieria Social");
        }
        else
        {
            await DisplayAlert("Respuesta Incorrecta", "Vuelve a revisar el contenido", "OK");
        }
    }
}