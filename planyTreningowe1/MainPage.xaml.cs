using Microsoft.Maui.Controls.Shapes;

namespace planyTreningowe1
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void previousWeekButton_Clicked(object sender, EventArgs e)
        {
        }

        private void nextWeekButton_Clicked(object sender, EventArgs e)
        {
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        private void dayButton_Clicked(object sender, EventArgs e)
        {
        }

        private void addExerciseButton_Clicked(object sender, EventArgs e)
        {
        }

    }

}
