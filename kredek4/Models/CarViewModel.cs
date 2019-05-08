using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kredek4.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// model
        /// </summary>
        public string Model { get; set; }
        
        /// <summary>
        /// marka
        /// </summary>
        public string Manufacturer { get; set; }
        
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        
        /// <summary>
        /// zdjecie
        /// </summary>
        public string Photo { get; set; }

        public CarViewModel(String model, string manufacturer, decimal price, string photo)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Photo = photo;
        }

    }
}
