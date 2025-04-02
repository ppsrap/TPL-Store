using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TPL_Store.Data;
using TPL_Store.Models;
using OrderLine = TPL_Store.Data.OrderLine;

namespace TPL_Store.ViewModels;

public class OrderViewModel : ObservableObject
{
    private readonly ItemRepository _itemRepository;

    public ObservableCollection<OrderLine> OrderLines { get; set; }
    public ObservableCollection<Items> Items { get; set; }

    public ICommand AddOrderLineCommand { get; }
    public ICommand RemoveOrderLineCommand { get; }

    public OrderViewModel(ItemRepository itemRepository)
    {
        _itemRepository = itemRepository;

        Items = new ObservableCollection<Items>(_itemRepository.GetAllItems());

        OrderLines = new ObservableCollection<OrderLine>();

        AddOrderLineCommand = new RelayCommand(AddOrderLine);
        RemoveOrderLineCommand = new RelayCommand<OrderLine>(RemoveOrderLine);
    }

    private void AddOrderLine()
    {
        OrderLines.Add(new OrderLine());
    }

    private void RemoveOrderLine(OrderLine orderLine)
    {
        if (orderLine != null)
            OrderLines.Remove(orderLine);
    }
}