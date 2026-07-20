using BookShop.Models;

public interface ICartService
{
    List<CartItemModel> GetAllCartItems();
    void AddBookToCart(BookModel book);
    void IncreaseCartItemQuantity(int bookId);
    void DecreaseCartItemQuantity(int bookId);
    void RemoveItemFromCart(int bookId);
}

