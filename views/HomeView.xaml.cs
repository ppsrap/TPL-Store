using System.Windows;
using System.Windows.Controls;
using TPL_Store.Data;
using TPL_Store.Services;
using TPL_Store.ViewModels;

namespace TPL_Store.views;

public partial class HomeView 
{
    public HomeView()
    {
        InitializeComponent();
        DataContext = new HomeViewModel(new OrderRepository(), new NavigationUseService());
    }
}