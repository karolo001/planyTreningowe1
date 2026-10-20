namespace planyTreningowe1;

public partial class RegisterView : ContentPage
{
	public RegisterView()
	{
        InitializeComponent();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
            #if ANDROID
                handler.PlatformView.Background = null; 
            #endif
            });
        }

    private async void BackToLoginScreen(object sender, TappedEventArgs e)
    {
        Console.WriteLine("wracam do logowania");
        await Shell.Current.GoToAsync("..", true);
    }

    private void registerButton_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("rejestruje");
    }
}