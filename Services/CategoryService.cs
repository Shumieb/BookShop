using BookShop.Models;

public class CategoryService : ICategoryService
{
    private readonly List<TagModel> _tags;
    private readonly List<CategoryModel> _categories;

    public CategoryService()
    {
        // Tags (consistent with BookService + AuthorService)
        _tags = new()
        {
            new TagModel { TagId = 1, TagName = "Fantasy", forBooks = true, forAuthors = false, forCategories = true },
            new TagModel { TagId = 2, TagName = "Classic", forBooks = true, forAuthors = true, forCategories = true },
            new TagModel { TagId = 3, TagName = "Sci-Fi", forBooks = true, forAuthors = false, forCategories = true }
        };

        // Categories
        _categories = new()
        {
            new CategoryModel
            {
                CategoryId = 1,
                CategoryName = "Fantasy",
                Description = "Magic, mythical creatures, epic worlds.",
                CategoryTags = new() { _tags[0] }
            },
            new CategoryModel
            {
                CategoryId = 2,
                CategoryName = "Science Fiction",
                Description = "Futuristic, space, technology.",
                CategoryTags = new() { _tags[2] }
            },
            new CategoryModel
            {
                CategoryId = 3,
                CategoryName = "Classics",
                Description = "Timeless literature across eras.",
                CategoryTags = new() { _tags[1] }
            }
        };
    }

    public List<CategoryModel> GetAllCategories() => _categories;

    public CategoryModel GetCategoryById(int id) =>
        _categories.FirstOrDefault(c => c.CategoryId == id);
}
