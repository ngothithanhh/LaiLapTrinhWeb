namespace Lap03.Models
{
    public class Products
    {
        public string Title { get; set; }
        public string Image { get; set; }

        public List<Products> GetProductsList()
        {
            List<Products> products = new List<Products>()
            {
                new Products(){ Title = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/products/im.jpg"},
                new Products(){ Title = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/products/im.jpg"},
                new Products(){ Title = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/images/products/im.jpg"}
            };
            return products;
        }
    }
}
