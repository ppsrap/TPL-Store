using System.Windows;
using TPL_Store.Data;
using TPL_Store.ViewModels;

namespace TPL_Store.views;

public partial class OrderView : Window
{
    public OrderView()
    {
        InitializeComponent();
        DataContext = new OrderViewModel(new ItemRepository());
    }
}