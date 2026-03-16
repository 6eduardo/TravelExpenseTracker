using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpenseTracker.Pages;

namespace TravelExpenseTracker.ViewModels
{
    public partial class LoginViewModel: ObservableObject
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        //Go to Register Button
        [RelayCommand]
        private async Task NavigateToRegisterAsync() =>
            await Shell.Current.GoToAsync(nameof(RegisterPage));

        [RelayCommand]
        private async Task LoginAsync()
        {
            //Login Validation
            //Call the API
            //Redirect to Home/Main Page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
