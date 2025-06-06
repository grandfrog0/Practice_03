using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03.Classes
{
    /// <summary>
    /// Блюдо
    /// </summary>
    class Dish
    {
        public string Title { get; private set; }       // Название блюда
        public double Price { get; private set; }       // Цена блюда
        public int Count { get; private set; }          // Кол-во

        public double Cost => Price * Count;            // Цена с учетом кол-ва

        public Dish(string title, double price, int count=1)
        {
            Title = title;
            Price = price;
            Count = count;
        }

        public override string ToString() => $"{Title} ({Price} x {Count} = {Cost} руб.)";
    }
}
