using ScratchMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchMAUI.ViewModel
{
   public class MainViewModel
    {
        public FactModel FactOfTheDay { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<FactModel> RadomFacts { get; set; }
        public MainViewModel()
        {
            Categories = CategoryModel.GetCategoryModels();
        }
    }
}
