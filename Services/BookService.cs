using BookShop.Models;

public class BookService : IBookService
{
    private readonly List<TagModel> _tags;
    private readonly List<AuthorModel> _authors;
    private readonly List<CategoryModel> _categories;
    private readonly List<BookModel> _books;

    public BookService()
    {
        // Tags
        _tags = new()
        {
            new TagModel { TagId = 1, TagName = "Fantasy", forBooks = true, forAuthors = false, forCategories = true },
            new TagModel { TagId = 2, TagName = "Classic", forBooks = true, forAuthors = true, forCategories = true },
            new TagModel { TagId = 3, TagName = "Sci-Fi", forBooks = true, forAuthors = false, forCategories = true },
            new TagModel { TagId = 4, TagName = "Bestseller", forBooks = true, forAuthors = true, forCategories = false }
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
            }
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
            }
        };

        // Books
        _books = new()
        {
            new BookModel
            {
                BookId = 1,
                Title = "The Hobbit",
                AuthorId = 1,
                Author = _authors[0],
                PageCount = 310,
                PublishedOn = new DateTime(1937, 9, 21),
                ISBN = "1234567890123",
                Summary = "Bilbo Baggins goes on an unexpected journey.",
                AuthorBookNote = "One of Tolkien's most beloved works.",
                Price = 12.99m,
                StockLevel = 50,
                CategoryId = 1,
                Category = _categories[0],
                BookTags = new() { _tags[0], _tags[1] },
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 3,
                Title = "The Hobbit 2",
                AuthorId = 1,
                Author = _authors[0],
                PageCount = 310,
                PublishedOn = new DateTime(1937, 9, 21),
                ISBN = "1234567890124",
                Summary = "Bilbo Baggins goes on an unexpected journey 2.",
                AuthorBookNote = "One of Tolkien's most beloved works 2.",
                Price = 14.99m,
                StockLevel = 50,
                CategoryId = 1,
                Category = _categories[0],
                BookTags = new() { _tags[0], _tags[1], _tags[3] },
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 2,
                Title = "Foundation",
                AuthorId = 2,
                Author = _authors[1],
                PageCount = 255,
                PublishedOn = new DateTime(1951, 6, 1),
                ISBN = "9876543210123",
                Summary = "A mathematician predicts the fall of the Galactic Empire.",
                AuthorBookNote = "A cornerstone of sci-fi literature.",
                Price = 10.99m,
                StockLevel = 30,
                CategoryId = 2,
                Category = _categories[1],
                BookTags = new() { _tags[2], _tags[3] },
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 4,
                Title = "Foundation 2",
                AuthorId = 2,
                Author = _authors[1],
                PageCount = 255,
                PublishedOn = new DateTime(1951, 6, 1),
                ISBN = "9876543210127",
                Summary = "A mathematician predicts the fall of the Galactic Empire.",
                AuthorBookNote = "A cornerstone of sci-fi literature.",
                Price = 10.99m,
                StockLevel = 30,
                CategoryId = 2,
                Category = _categories[1],
                BookTags = new() { _tags[2], _tags[3] },
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            }
        };
    }

    public List<BookModel> GetAllBooks() => _books;

    public BookModel GetBookById(int id) =>
        _books.FirstOrDefault(b => b.BookId == id);

    public List<BookModel> GetBooksByTagId(int tagId) =>
        _books.Where(b => b.BookTags.Any(t => t.TagId == tagId)).ToList();

    public List<BookModel> GetBooksByCategoryId(int categoryId) =>
        _books.Where(b => b.CategoryId == categoryId).ToList();

    public List<BookModel> GetBooksByAuthorId(int authorId) =>
        _books.Where(b => b.AuthorId == authorId).ToList();

    public List<BookModel> GetBooksBySearchParam(string search)
    {
        if (string.IsNullOrWhiteSpace(search))
            return new();

        search = search.ToLower();

        return _books.Where(b =>
            b.Title.ToLower().Contains(search) ||
            b.Author.AuthorName.ToLower().Contains(search)
        ).ToList();
    }
}