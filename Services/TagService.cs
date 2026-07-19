using BookShop.Models;

public class TagService : ITagService
{
    private readonly List<TagModel> _tags;

    public TagService()
    {
        _tags = new()
        {
            new TagModel
            {
                TagId = 1,
                TagName = "Fantasy",
                Description = "Magic, mythical creatures, epic worlds.",
                forBooks = true,
                forAuthors = false,
                forCategories = true
            },
            new TagModel
            {
                TagId = 2,
                TagName = "Classic",
                Description = "Timeless literature.",
                forBooks = true,
                forAuthors = true,
                forCategories = true
            },
            new TagModel
            {
                TagId = 3,
                TagName = "Sci-Fi",
                Description = "Futuristic, space, technology.",
                forBooks = true,
                forAuthors = false,
                forCategories = true
            },
            new TagModel
            {
                TagId = 4,
                TagName = "Biography",
                Description = "Life stories of notable individuals.",
                forBooks = true,
                forAuthors = true,
                forCategories = false
            }
        };
    }

    public List<TagModel> GetAllTags() => _tags;

    public TagModel GetTagById(int id) =>
        _tags.FirstOrDefault(t => t.TagId == id);

    public List<TagModel> GetTagsForBooks() =>
        _tags.Where(t => t.forBooks).ToList();

    public List<TagModel> GetTagsForAuthors() =>
        _tags.Where(t => t.forAuthors).ToList();

    public List<TagModel> GetTagsForCategories() =>
        _tags.Where(t => t.forCategories).ToList();
}
