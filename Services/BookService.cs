using BookShop.Models;
using BookShop.Helper;

public class BookService : IBookService
{
    private readonly List<BookModel> _books;

    public BookService()
    {
        // Books
        _books =
        [
            new BookModel
            {
                BookId = 1,
                Title = "The Hobbit",
                AuthorId = 1,
                Author = new(){ AuthorId = 1, AuthorName = "J.R.R. Tolkien", Statement = "Creator of Middle-earth", Biography = "English writer and philologist."},
                PageCount = 310,
                PublishedOn = new DateTime(1937, 9, 21),
                ISBN = "1234567890123",
                Summary = "Bilbo Baggins goes on an unexpected journey.",
                AuthorBookNote = "One of Tolkien's most beloved works.",
                Price = 12.99m,
                StockLevel = 50,
                CategoryId = 1,
                Category = new(){ CategoryId = 1, CategoryName = "Fantasy", Description = "Magic, mythical creatures, epic worlds."},
                BookTags = new(){
                    new(){
                        TagId = 1,
                        TagName = "Fantasy",
                        Description = "Magic, mythical creatures, epic worlds.",
                        forBooks = true,
                        forAuthors = false,
                        forCategories = true
                    },
                    new(){
                        TagId = 2,
                        TagName = "Classic",
                        Description = "Timeless literature.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = true
                    }},
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 3,
                Title = "The Hobbit 2",
                AuthorId = 1,
                Author = new(){ AuthorId = 1, AuthorName = "J.R.R. Tolkien", Statement = "Creator of Middle-earth", Biography = "English writer and philologist."},
                PageCount = 310,
                PublishedOn = new DateTime(1937, 9, 21),
                ISBN = "1234567890124",
                Summary = "Bilbo Baggins goes on an unexpected journey 2.",
                AuthorBookNote = "One of Tolkien's most beloved works 2.",
                Price = 14.99m,
                StockLevel = 50,
                CategoryId = 1,
                Category = new(){ CategoryId = 1, CategoryName = "Fantasy", Description = "Magic, mythical creatures, epic worlds."},
                BookTags = new() {
                    new(){
                        TagId = 1,
                        TagName = "Fantasy",
                        Description = "Magic, mythical creatures, epic worlds.",
                        forBooks = true,
                        forAuthors = false,
                        forCategories = true
                    },
                    new(){
                        TagId = 2,
                        TagName = "Classic",
                        Description = "Timeless literature.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = true
                    },
                    new(){
                        TagId = 4,
                        TagName = "Bestseller",
                        Description = "The Number One Bestseller.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = false
                    }},
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 2,
                Title = "Foundation",
                AuthorId = 2,
                Author = new(){ AuthorId = 2, AuthorName = "Isaac Asimov", Statement = "Science fiction pioneer", Biography = "American writer and professor."},
                PageCount = 255,
                PublishedOn = new DateTime(1951, 6, 1),
                ISBN = "9876543210123",
                Summary = "A mathematician predicts the fall of the Galactic Empire.",
                AuthorBookNote = "A cornerstone of sci-fi literature.",
                Price = 10.99m,
                StockLevel = 30,
                CategoryId = 2,
                Category = new(){ CategoryId = 2, CategoryName = "Science Fiction", Description = "Futuristic, space, technology."},
                BookTags = new(){
                    new(){
                        TagId = 3,
                        TagName = "Sci-Fi",
                        Description = "Futuristic, space, technology.",
                        forBooks = true,
                        forAuthors = false,
                        forCategories = true
                    },
                    new(){
                        TagId = 4,
                        TagName = "Bestseller",
                        Description = "The Number One Bestseller.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = false
                    }},
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 4,
                Title = "Foundation 2",
                AuthorId = 2,
                Author = new(){ AuthorId = 2, AuthorName = "Isaac Asimov", Statement = "Science fiction pioneer", Biography = "American writer and professor."},
                PageCount = 255,
                PublishedOn = new DateTime(1951, 6, 1),
                ISBN = "9876543210127",
                Summary = "A mathematician predicts the fall of the Galactic Empire.",
                AuthorBookNote = "A cornerstone of sci-fi literature.",
                Price = 10.99m,
                StockLevel = 30,
                CategoryId = 2,
                Category = new(){ CategoryId = 2, CategoryName = "Science Fiction", Description = "Futuristic, space, technology."},
                BookTags = new(){
                    new(){
                        TagId = 3,
                        TagName = "Sci-Fi",
                        Description = "Futuristic, space, technology.",
                        forBooks = true,
                        forAuthors = false,
                        forCategories = true
                    },
                    new(){
                        TagId = 4,
                        TagName = "Bestseller",
                        Description = "The Number One Bestseller.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = false
                    }},
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 5,
                Title = "Foundation 3",
                AuthorId = 2,
                Author = new(){ AuthorId = 2, AuthorName = "Isaac Asimov", Statement = "Science fiction pioneer", Biography = "American writer and professor."},
                PageCount = 255,
                PublishedOn = new DateTime(1951, 6, 1),
                ISBN = "9876543210128",
                Summary = "A mathematician predicts the fall of the Galactic Empire.",
                AuthorBookNote = "A cornerstone of sci-fi literature.",
                Price = 9.99m,
                StockLevel = 30,
                CategoryId = 2,
                Category = new(){ CategoryId = 2, CategoryName = "Science Fiction", Description = "Futuristic, space, technology."},
                BookTags = new(){
                    new(){
                        TagId = 3,
                        TagName = "Sci-Fi",
                        Description = "Futuristic, space, technology.",
                        forBooks = true,
                        forAuthors = false,
                        forCategories = true
                    },
                    new(){
                        TagId = 4,
                        TagName = "Bestseller",
                        Description = "The Number One Bestseller.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = false
                    }},
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
            new BookModel
            {
                BookId = 6,
                Title = "The Hobbit 3",
                AuthorId = 1,
                Author = new(){ AuthorId = 1, AuthorName = "J.R.R. Tolkien", Statement = "Creator of Middle-earth", Biography = "English writer and philologist."},
                PageCount = 310,
                PublishedOn = new DateTime(1937, 9, 21),
                ISBN = "1234567890125",
                Summary = "Bilbo Baggins goes on an unexpected journey 2.",
                AuthorBookNote = "One of Tolkien's most beloved works 2.",
                Price = 12.99m,
                StockLevel = 50,
                CategoryId = 1,
                Category = new(){ CategoryId = 1, CategoryName = "Fantasy", Description = "Magic, mythical creatures, epic worlds."},
                BookTags = new(){
                    new(){
                        TagId = 1,
                        TagName = "Fantasy",
                        Description = "Magic, mythical creatures, epic worlds.",
                        forBooks = true,
                        forAuthors = false,
                        forCategories = true
                    }, new(){
                        TagId = 2,
                        TagName = "Classic",
                        Description = "Timeless literature.",
                        forBooks = true,
                        forAuthors = true,
                        forCategories = true
                    }},
                BookImageUrls = new() { "https://images.pexels.com/photos/2422178/pexels-photo-2422178.jpeg" }
            },
        ];
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

    public List<BookModel> GetBooksByFilters(SelectedFilters filters, string searchTerm = "")
    {
        var filteredBooks = _books.AsEnumerable();

        // Search term filter
        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            var term = searchTerm.Trim().ToLower();

            filteredBooks = filteredBooks.Where(b =>
                b.Title.ToLower().Contains(term) ||
                b.Author.AuthorName.ToLower().Contains(term)
            );
        }

        // Tag filter
        if (filters.Tags.Any())
        {
            filteredBooks = filteredBooks.Where(b =>
                b.BookTags.Any(t => filters.Tags.Any(ft => ft.TagId == t.TagId))
            );
        }

        // Author filter
        if (filters.Authors.Any())
        {
            filteredBooks = filteredBooks.Where(b =>
                filters.Authors.Any(fa => fa.AuthorId == b.AuthorId)
            );
        }

        // Category filter
        if (filters.Categories.Any())
        {
            filteredBooks = filteredBooks.Where(b =>
                filters.Categories.Any(fc => fc.CategoryId == b.CategoryId)
            );
        }

        return filteredBooks.ToList();
    }

}