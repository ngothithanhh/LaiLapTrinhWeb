using System.Collections.Generic;
namespace Lap03.Models
{
    public class Categories
    {
        public string Title { get; set; }

        public List<Categories> GetCategoriesList()
        {
            List<Categories> categories = new List<Categories>()
            {
                new Categories(){ Title = "Áo dài"},
                new Categories(){ Title = "Áo lông"},
                new Categories(){ Title = "Túi xách"},
                new Categories(){ Title = "Đồng hồ"},
                new Categories(){ Title = "Ví da"},
                new Categories(){ Title = "Thắt lưng da"},
                new Categories(){ Title = "Tủ lạnh"},
                new Categories(){ Title = "Tivi"},
                new Categories(){ Title = "Quạt điện"},
                new Categories(){ Title = "Lò sưởi"}
            };
            return categories;
        }
    }
}
