﻿namespace BubsPizzaria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string CustomerName { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Onion { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Sausage { get; set; }
        public float FinalPrice { get; set; }



    }
}
