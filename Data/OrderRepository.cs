using System.IO;
using Newtonsoft.Json;

namespace TPL_Store.Data;

public class OrderRepository
{
    private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "orders.json");

    public List<Order> GetAllOrders()
    {
        Console.WriteLine($"Looking for orders.json at: {_filePath}");

        if (!File.Exists(_filePath))
        {
            Console.WriteLine("orders.json file not found.");
            return new List<Order>();
        }

        var json = File.ReadAllText(_filePath);
        Console.WriteLine($"File read successfully. JSON content: {json}");

        var orders = JsonConvert.DeserializeObject<List<Order>>(json) ?? new List<Order>();
        Console.WriteLine($"Deserialized orders: {orders.Count} orders found.");
        
        return orders;
    }

    public Order GetOrderById(int orderId)
    {
        return GetAllOrders().FirstOrDefault(o => o.OrderID == orderId);
    }
}