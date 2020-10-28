using System;
using System.Collections.ObjectModel;
using EventAppSample.Models;

namespace EventAppSample.ViewModels
{
    public class GuestViewModel
    {
        public ObservableCollection<Guests> guest { get; set; }

        public GuestViewModel()
        {
            guest = new ObservableCollection<Guests>()
            {
                new Guests { Picture = "LeomarisReyes.jpg" },
                new Guests { Picture = "VictorR.jpg" },
                new Guests { Picture = "LeomarisReyes.jpg" }
            };
        }
    }
}
