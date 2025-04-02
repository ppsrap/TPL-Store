namespace TPL_Store.Models;

public class OrderLine
{
    public int OrderLineId { get; set; }
    public int OrderId { get; set; }
    public int ItemId { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public int Quantity { get; set; } = 1;
    public decimal ItemCost { get; set; } = 0m;
    
    public decimal LineTotal => Quantity * ItemCost;
}