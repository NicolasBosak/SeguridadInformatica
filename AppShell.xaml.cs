using SeguridadInformatica.MVVM.Views;

namespace SeguridadInformatica
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Password1), typeof(Password1));
        }
    }
}
