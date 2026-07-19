using BookShop.Models;

public interface IBookService
{
    List<BookModel> GetAllBooks();
    BookModel GetBookById(int id);
    List<BookModel> GetBooksByTagId(int tagId);
    List<BookModel> GetBooksByCategoryId(int categoryId);
    List<BookModel> GetBooksByAuthorId(int authorId);
    List<BookModel> GetBooksBySearchParam(string search);
}