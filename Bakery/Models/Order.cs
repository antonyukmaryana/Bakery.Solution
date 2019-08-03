using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public string Title { get; set;}
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
        private string Description { get; set; }
        

        public Order(string title)
        {
           Tittle = title
           _instances.Add(this);
           id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }

    }
}