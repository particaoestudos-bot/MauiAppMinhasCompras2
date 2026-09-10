using Microsoft.Extensions.DependencyInjection;

namespace MauiAppMinhasCompras2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // return new Window(new AppShell());
            MainPage = new NavigationPage(new Views.ListaProduto());
            //Bom dia tony paramos aqui, chegue na ag3 hj e va cuidar dar outras coisas, força meu querido vai dar tudo certo!:)
        }
    }
}