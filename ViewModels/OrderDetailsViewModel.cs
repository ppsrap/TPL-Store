using TPL_Store.Data;

namespace TPL_Store.ViewModels;

public class OrderDetailsViewModel : ViewModelBase
{
    private Order _order;

    public Order SelectedOrder
    {
        get => _order;
        set { _order = value; OnPropertyChanged(nameof(SelectedOrder)); }
    }

    public OrderDetailsViewModel(Order order)
    {
        _order = order;
    }
}
