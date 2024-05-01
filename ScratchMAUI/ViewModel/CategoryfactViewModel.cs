using ScratchMAUI.Data;
using System.Collections.ObjectModel;

namespace ScratchMAUI.ViewModel
{
    [QueryProperty(nameof(CategoryName), nameof(categoryName))]
    public partial class CategoryfactViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Title))]
        private string categoryName;
        public string Title => $"{CategoryName} Facts";
        public CategoryfactViewModel()
        {

        }
        [ObservableProperty]
        private ObservableCollection<FactModel> _categoryFacts;

        public void LoadFacts()
        {
            var categoryFact = SeedData.GetCategoryFacts(CategoryName);
            CategoryFacts = new ObservableCollection<FactModel>(categoryFact);
        }

        [RelayCommand]
        private async Task GoToFactDetailPage(FactModel fact)
        {
            await Shell.Current.GoToAsync(nameof(FactDetailPage), new Dictionary<string, object> { [nameof(FactDetailViewModel.Fact)] = fact });
        }
    }
}