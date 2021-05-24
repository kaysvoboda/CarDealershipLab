using System;
namespace GC_CarDealership.Services.Models
{
    public class APIResponse
    {
        public APIResponse()
        {
        }

        
        public class Car
        {
            public int Id { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public string Color { get; set; }
        }
    }
}
