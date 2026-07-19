using BookShop.Models;

public interface IAuthorService
{
    List<AuthorModel> GetAllAuthors();
    AuthorModel GetAuthorById(int id);
}