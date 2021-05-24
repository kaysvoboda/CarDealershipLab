using System;
namespace GC_CarDealership.Models
{
    public class CarViewModel
    {
        public CarViewModel(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;

        }

        public string Make { get; }
        public string Model { get; }
        public string Year { get; }
    }
}
