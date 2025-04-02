using System.Windows.Input;
using TPL_Store.Data;
using TPL_Store.Services;
using CommunityToolkit.Mvvm.Input;

namespace TPL_Store.ViewModels;

public class LoginViewModel : ViewModelBase
{
    private string _username;
    private string _password;
    private string _errorMessage;
    private readonly UserRepository _userRepository;
    private readonly NavigationUseService _navigationUseService;

    public string Username
    {
        get => _username;
        set
        {
            _username = value;
            OnPropertyChanged(nameof(Username));
            ((RelayCommand)LoginCommand).NotifyCanExecuteChanged(); 
        }
    }

    public string Password
    {
        private get => _password;
        set
        {
            _password = value;
            OnPropertyChanged(nameof(Password));
            ((RelayCommand)LoginCommand).NotifyCanExecuteChanged(); 
        }
    }

    public string ErrorMessage
    {
        get => _errorMessage;
        set { _errorMessage = value; OnPropertyChanged(nameof(ErrorMessage)); }
    }

    public ICommand LoginCommand { get; }

    public LoginViewModel(UserRepository userRepository, NavigationUseService navigationUseService)
    {
        _userRepository = userRepository; 
        
        _navigationUseService = navigationUseService; 
        
        LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);
    }

    private bool CanExecuteLogin() 
    {
        var canExecute = !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        return canExecute;
    }

    private void ExecuteLogin()
    {
        if (_userRepository.ValidateUser(Username, Password))
        {
            _navigationUseService.NavigateTo("HomeView");
        }
        else
        {
            ErrorMessage = "Invalid Username or Password";
        }
    }
}