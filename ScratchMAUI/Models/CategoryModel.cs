using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchMAUI.Models
{
    public struct CategoryModel
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public CategoryModel(string name, string ımage)
        {
            Name = name;
            Image = ımage;
        }

        public static IEnumerable<CategoryModel> GetCategoryModels()
        {
            return new List<CategoryModel>()
            {
                new CategoryModel("Animal","lion.png"),
                new CategoryModel("Human","human.png"),
                new CategoryModel("Entertainment","entertainment.png"),
                new CategoryModel("Science & Technology","cience.png"),
                new CategoryModel("World & Language","world_language.png"),
                new CategoryModel("Music","music.png"),
            };
        }
    }
}
