using Microsoft.Maui.Controls;

namespace SeguridadInformatica.MVVM.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Command NavigateToMainView => new Command(async () =>
        {
            await Navigation.PushAsync(new MainView());
        });

        public Command NavigateToTeenView => new Command(async () =>
        {
            await Navigation.PushAsync(new TeenView());
        });

        public Command NavigateToAdultView => new Command(async () =>
        {
            await Navigation.PushAsync(new AdultView()); 
        });
    }
}
