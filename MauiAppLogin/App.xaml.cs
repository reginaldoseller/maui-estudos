using Microsoft.Extensions.DependencyInjection;

namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            //Essa parte do código foi criada primeiro na Protegida.xaml.cs
            string? usuario_logado = null;

            

            MainPage = new Login();
=======
            MainPage = new AppShell();
>>>>>>> 1008b949541ca07412bba29fba45ba1178268d8f

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
<<<<<<< HEAD
            var Window = base.CreateWindow(activationState);

            Window.Width = 400;
            Window.Height = 600;

            return Window;
        }
    } // fecha a classe
} // fecha o namespace
=======
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
>>>>>>> 1008b949541ca07412bba29fba45ba1178268d8f
