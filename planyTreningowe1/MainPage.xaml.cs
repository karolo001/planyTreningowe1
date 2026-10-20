namespace planyTreningowe1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
            #if ANDROID
                handler.PlatformView.Background = null;
            #endif
                });
                
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Console.WriteLine("kliknieto przejscie na rejestracje");
            await Shell.Current.GoToAsync(nameof(RegisterView));
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("kliknietoi login");
        }
    }

}
