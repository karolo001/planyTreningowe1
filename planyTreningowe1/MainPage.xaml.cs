using Microsoft.Maui.Controls.Shapes;

namespace planyTreningowe1
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
        }


        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

    }

}
