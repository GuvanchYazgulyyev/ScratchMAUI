namespace ScratchMAUI.Pages;

public partial class FactDetailPage : ContentPage
{
    private readonly FactDetailViewModel _viewModel;
    public FactDetailPage(FactDetailViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}