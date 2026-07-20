using BookShop.Models;

public class CartService : ICartService
{
    private readonly List<CartItemModel> _cartItems = new();

    public List<CartItemModel> GetAllCartItems() => _cartItems;

    public void AddBookToCart(BookModel book)
    {
        var existingItem = _cartItems.FirstOrDefault(ci => ci.Book.BookId == book.BookId);

        if (existingItem is not null)
        {
            existingItem.Quantity++;
        }
        else
        {
            _cartItems.Add(new CartItemModel
            {
                CartItemId = GenerateCartItemId(),
                Book = book,
                Quantity = 1,
                UnitPrice = book.Price
            });
        }
    }

    public void IncreaseCartItemQuantity(int bookId)
    {
        var existingItem = _cartItems.FirstOrDefault(ci => ci.Book.BookId == bookId);

        if (existingItem is not null)
        {
            existingItem.Quantity++;
        }
    }

    public void DecreaseCartItemQuantity(int bookId)
    {
        var existingItem = _cartItems.FirstOrDefault(ci => ci.Book.BookId == bookId);

        if (existingItem is null)
            return;

        existingItem.Quantity--;

        if (existingItem.Quantity <= 0)
        {
            _cartItems.Remove(existingItem);
        }
    }

    public void RemoveItemFromCart(int bookId)
    {
        var existingItem = _cartItems.FirstOrDefault(ci => ci.Book.BookId == bookId);

        if (existingItem is not null)
        {
            _cartItems.Remove(existingItem);
        }
    }

    private int GenerateCartItemId()
    {
        return _cartItems.Count == 0
            ? 1
            : _cartItems.Max(ci => ci.CartItemId) + 1;
    }
}
