using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.Input;
using TPL_Store.Data;
using TPL_Store.Services;
using TPL_Store.ViewModels;

namespace TPL_Store.views;

public partial class LoginView : Window
{
    public LoginView()
    {
        InitializeComponent();
        DataContext = new LoginViewModel(new UserRepository(), new NavigationUseService());
    }
    
    private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (sender is PasswordBox passwordBox && DataContext is LoginViewModel viewModel)
        {
            viewModel.Password = passwordBox.Password;
            viewModel.OnPropertyChanged(nameof(viewModel.Password));
            ((RelayCommand)viewModel.LoginCommand).NotifyCanExecuteChanged();  
        }
    }
}