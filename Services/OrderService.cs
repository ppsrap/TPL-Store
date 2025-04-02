using TPL_Store.Data;

namespace TPL_Store.Services;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class OrderService
{
    private List<Order> _orders;

    public OrderService(string jsonFilePath)
    {
        // Load and deserialize the orders from the JSON file
        var jsonData = File.ReadAllText(jsonFilePath);
        _orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
    }

    public List<Order> GetOrders()
    {
        return _orders;
    }

    public Order GetOrderById(int orderId)
    {
        return _orders.Find(order => order.OrderID == orderId);
    }

    public void PrintOrderSummary()
    {
        foreach (var order in _orders)
        {
            Console.WriteLine($"OrderID: {order.OrderID}, Ordered By: {order.OrderedBy}, TotalCost: {order.TotalCost}");
            Console.WriteLine($"Items Ordered: {order.ItemsOrderedSummary}");
        }
    }
}
