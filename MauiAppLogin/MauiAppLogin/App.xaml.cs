using Microsoft.Extensions.DependencyInjection;

namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Essa parte do código foi criada primeiro na Protegida.xaml.cs
            string? usuario_logado = null;

            

            MainPage = new Login();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var Window = base.CreateWindow(activationState);

            Window.Width = 400;
            Window.Height = 600;

            return Window;
        }
    } // fecha a classe
} // fecha o namespace