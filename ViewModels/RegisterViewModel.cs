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
    public partial class RegisterViewModel: ObservableObject
    {
        [ObservableProperty]
        public string _name;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        //Go back to login
        [RelayCommand]
        private async Task NavigateBackAsync() =>
            await Shell.Current.GoToAsync("..");
    }
}
