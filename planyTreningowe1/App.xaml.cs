using Microsoft.Extensions.DependencyInjection;

namespace planyTreningowe1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new(new AppShell());
            window.Width = 550;
            window.Height = 1000;
            return window;
        }
    }
}