using System;
using System.Drawing;

namespace WebApplication1.Models
{
    public class Item
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string TShirtSize { get; set; }
        public string TShirtColor { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
    }
}
