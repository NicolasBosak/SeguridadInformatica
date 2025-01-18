using SeguridadInformatica.MVVM.Views;

namespace SeguridadInformatica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainView());
        }
    }
}
