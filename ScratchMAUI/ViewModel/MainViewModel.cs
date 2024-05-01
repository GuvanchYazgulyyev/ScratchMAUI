using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ScratchMAUI.Data;
using ScratchMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchMAUI.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private FactModel _factOfTheDay;
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<FactModel> RadomFacts { get; set; }
        public MainViewModel()
        {
            Categories = CategoryModel.GetCategoryModels();
            FactOfTheDay = SeedData.GetFactModel();
            RadomFacts = SeedData.GetRandomFactsdata();

        }
        [RelayCommand]
        private async Task GoToCategoryPlay(string categoryName)
        {
            //await Shell.Current.GoToAsync($"{nameof(CategoryFactsPage)}?categoryName={categoryName}");
            await Shell.Current.GoToAsync(nameof(CategoryFactsPage), new Dictionary<string, object> { ["categoryName"] = categoryName }); // Bu Parametre Çoklu Gönderim içinidir!!!
        }

        [RelayCommand]
        private async Task GoToFactDetailPage(FactModel fact)
        {
            await Shell.Current.GoToAsync(nameof(FactDetailPage), new Dictionary<string, object> { [nameof(FactDetailViewModel.Fact)] = fact });
        }


    }
}
