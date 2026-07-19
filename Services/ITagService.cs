using BookShop.Models;

public interface ITagService
{
    List<TagModel> GetAllTags();
    TagModel GetTagById(int id);
    List<TagModel> GetTagsForBooks();
    List<TagModel> GetTagsForAuthors();
    List<TagModel> GetTagsForCategories();
}