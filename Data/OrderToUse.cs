namespace TPL_Store.Data;

public class Order
{
    public int OrderID { get; set; }
    public string OrderedBy { get; set; }
    public List<OrderLine> OrderLines { get; set; }
    public double TotalCost { get; set; }
    public string ItemsOrderedSummary { get; set; }
}

public class OrderLine
{
    public int RowNumber { get; set; }
    public int OrderID { get; set; }
    public SelectedItem SelectedItem { get; set; }
    public string ItemName { get; set; }
    public int ItemID { get; set; }
    public double Cost { get; set; }
    public int OrderAmount { get; set; }
    public double LineTotal { get; set; }
}

public class SelectedItem
{
    public int ItemID { get; set; }
    public string ItemName { get; set; }
    public double Cost { get; set; }
}