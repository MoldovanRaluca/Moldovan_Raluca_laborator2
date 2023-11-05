using Moldovan_Raluca_laborator2.Models;

namespace Moldovan_Raluca_laborator2.ViewModels
{
    public class CategoryIndexData
    {
            public IEnumerable<Category> Categories { get; set; }
            public IEnumerable<Book> BookCategories { get; set; }
                
    }
}
