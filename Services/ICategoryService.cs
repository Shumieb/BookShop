using BookShop.Models;

public interface ICategoryService
{
    List<CategoryModel> GetAllCategories();
    CategoryModel GetCategoryById(int id);
}