using ScratchMAUI.ViewModel;

namespace ScratchMAUI
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _mainViewModel;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            BindingContext = mainViewModel;
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.DisplayAlert("Hi!", "Hello, this is tapped from the category", "Ok");
        }
    }
}
