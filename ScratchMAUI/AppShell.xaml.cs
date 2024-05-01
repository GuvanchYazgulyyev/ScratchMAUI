namespace ScratchMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CategoryFactsPage), typeof(CategoryFactsPage));
            Routing.RegisterRoute(nameof(FactDetailPage), typeof(FactDetailPage));
        }
    }
}
