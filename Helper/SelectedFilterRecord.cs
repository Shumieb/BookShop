using BookShop.Models;

namespace BookShop.Helper
{
    public record SelectedFilters(
        List<TagModel> Tags,
        List<AuthorModel> Authors,
        List<CategoryModel> Categories
    );
}