﻿namespace BillingSystem.Core.ViewModels
{
    public class InternetDetails
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime UntilDate { get; set; }
        public string RouterMAC { get; set; }
        public decimal Price { get; set; }
    }
}
