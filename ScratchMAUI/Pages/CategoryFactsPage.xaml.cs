

namespace ScratchMAUI.Pages;

public partial class CategoryFactsPage : ContentPage
{
    private readonly CategoryfactViewModel _categoryfactView;

    public CategoryFactsPage(CategoryfactViewModel categoryfactView)
    {
        InitializeComponent();
        BindingContext = categoryfactView;
        _categoryfactView = categoryfactView;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _categoryfactView.LoadFacts();
    }
}