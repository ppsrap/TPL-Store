using System.Windows;
using TPL_Store.Data;
using TPL_Store.ViewModels;
using TPL_Store.views;

namespace TPL_Store.Services;

public class NavigationUseService
{
    public void NavigateTo(string viewName, object parameter = null)
    {
        Window newWindow = viewName switch
        {
            "HomeView" => new HomeView(),
            
            "OrderView" => new OrderView(),
            
            "OrderDetailsView" when parameter is Order order => 
                new OrderDetailsView { DataContext = new OrderDetailsViewModel(order) },
            
            _ => throw new ArgumentException("Invalid view name")
        };

        newWindow.Show();
        Application.Current.Windows[0]?.Close();
        Console.WriteLine($"Navigation to {viewName} successful.");
    }
}