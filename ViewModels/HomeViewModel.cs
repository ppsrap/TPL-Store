using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using TPL_Store.Data;
using TPL_Store.Services;

namespace TPL_Store.ViewModels;

public class HomeViewModel : ViewModelBase
{
    private readonly NavigationUseService _navigationService;
    private readonly OrderRepository _orderRepository;

    public ObservableCollection<Order> Orders { get; set; }
    private ObservableCollection<Order> _allOrders; 

    private string? _searchText;
    public string? SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            OnPropertyChanged(nameof(SearchText));
            FilterOrders();
        }
    }

    private Order? _selectedOrder;
    public Order? SelectedOrder
    {
        get => _selectedOrder;
        set { _selectedOrder = value; OnPropertyChanged(nameof(SelectedOrder)); }
    }

    public ICommand NewOrderCommand { get; }
    public ICommand ViewOrderDetailsCommand { get; }

    public HomeViewModel(OrderRepository orderRepository, NavigationUseService navigationService)
    {
        _orderRepository = orderRepository;
        _navigationService = navigationService;

        _allOrders = new ObservableCollection<Order>(_orderRepository.GetAllOrders());
        Orders = new ObservableCollection<Order>(_allOrders);

        NewOrderCommand = new RelayCommand(() => _navigationService.NavigateTo("OrderView", null));

        ViewOrderDetailsCommand = new RelayCommand<Order>(order => {
            if (order != null) 
                _navigationService.NavigateTo("OrderDetailsView", order);
        }, order => order != null);
    }



    private void FilterOrders()
    {
        if (string.IsNullOrWhiteSpace(SearchText))
        {
            Orders = new ObservableCollection<Order>(_allOrders);
        }
        else
        {
            Orders = new ObservableCollection<Order>(
                _allOrders.Where(o => o.OrderID.ToString().Contains(SearchText))
            );
        }
        OnPropertyChanged(nameof(Orders));
    }
}