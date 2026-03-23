using Wed_Ban_Hang__Tuan_3.Models;

public class ShoppingCart
{
    // Danh sách các mặt hàng trong giỏ, mặc định khởi tạo là danh sách rỗng
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    /// <summary>
    /// Thêm sản phẩm vào giỏ hàng
    /// </summary>
    public void AddItem(CartItem item)
    {
        // Kiểm tra xem sản phẩm đã tồn tại trong giỏ hàng chưa
        var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);

        if (existingItem != null)
        {
            // Nếu đã có, chỉ cần cộng dồn số lượng
            existingItem.Quantity += item.Quantity;
        }
        else
        {
            // Nếu chưa có, thêm mới hoàn toàn vào danh sách
            Items.Add(item);
        }
    }

    /// <summary>
    /// Xóa hoàn toàn một sản phẩm khỏi giỏ hàng dựa trên ID
    /// </summary>
    public void RemoveItem(int productId)
    {
        Items.RemoveAll(i => i.ProductId == productId);
    }

    // Bạn có thể thêm các phương thức khác như: 
    // ClearCart(), GetTotal() hoặc UpdateQuantity() tại đây...
}