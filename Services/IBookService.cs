using BookShop.Models;
using BookShop.Helper;

public interface IBookService
{
    List<BookModel> GetAllBooks();
    BookModel GetBookById(int id);
    List<BookModel> GetBooksByTagId(int tagId);
    List<BookModel> GetBooksByCategoryId(int categoryId);
    List<BookModel> GetBooksByAuthorId(int authorId);
    List<BookModel> GetBooksBySearchParam(string search);
    List<BookModel> GetBooksByFilters(SelectedFilters filters, string searchTerm);
}