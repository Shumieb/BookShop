using BookShop.Models;

public class AuthorService : IAuthorService
{
    private readonly List<TagModel> _tags;
    private readonly List<AuthorModel> _authors;

    public AuthorService()
    {
        // Tags (shared with BookService style)
        _tags = new()
        {
            new TagModel { TagId = 1, TagName = "Fantasy", forBooks = true, forAuthors = false, forCategories = true },
            new TagModel { TagId = 2, TagName = "Classic", forBooks = true, forAuthors = true, forCategories = true },
            new TagModel { TagId = 3, TagName = "Sci-Fi", forBooks = true, forAuthors = false, forCategories = true }
        };

        // Authors
        _authors = new()
        {
            new AuthorModel
            {
                AuthorId = 1,
                AuthorName = "J.R.R. Tolkien",
                Statement = "Creator of Middle-earth",
                Biography = "English writer and philologist.",
                AuthorTags = new() { _tags[1] }
            },
            new AuthorModel
            {
                AuthorId = 2,
                AuthorName = "Isaac Asimov",
                Statement = "Science fiction pioneer",
                Biography = "American writer and professor.",
                AuthorTags = new() { _tags[2] }
            },
            new AuthorModel
            {
                AuthorId = 3,
                AuthorName = "Jane Austen",
                Statement = "Classic English novelist",
                Biography = "Known for Pride and Prejudice.",
                AuthorTags = new() { _tags[1] }
            }
        };
    }

    public List<AuthorModel> GetAllAuthors() => _authors;

    public AuthorModel GetAuthorById(int id) =>
        _authors.FirstOrDefault(a => a.AuthorId == id);
}
