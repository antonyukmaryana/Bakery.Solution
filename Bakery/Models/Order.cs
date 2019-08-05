using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public string Title { get; set; }
        public int Id { get; }
        private static int Counter;
        public string Description { get; set; }


        public Order(string title)
        {
            Title = title;
            Id = Counter++;
        }
    }
}