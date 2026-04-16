using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpenseTracker.Model;

namespace TravelExpenseTracker.ViewModels
{
    public partial class HomeViewModel: ObservableObject
    {
        //Data to go to ColectionViews
        public ObservableCollection<TripModel> Trips { get; set; } = [];

        //
        [RelayCommand]
        private void AddTripsTemp()
        {
            Trips.Add(new TripModel("logo.png", "Trip 1", "Some Location"));
            Trips.Add(new TripModel("logo.png", "Another Trip 2", "Some Location"));
            Trips.Add(new TripModel("logo.png", "Alright Trip 3", "Some Location"));
            Trips.Add(new TripModel("logo.png", "Maybe Trip 4", "Some Location"));
            Trips.Add(new TripModel("logo.png", "Lets Trip 5", "Some Location"));
            Trips.Add(new TripModel("logo.png", "Mambu Trip 6", "Some Location"));
            Trips.Add(new TripModel("logo.png", "Go Trip 7", "Some Location"));

        }

    }
}
