﻿using SQLite;
using System;
using System.Drawing;
namespace Tshirt
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
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