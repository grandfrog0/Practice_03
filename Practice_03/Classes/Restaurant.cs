using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03.Classes
{
    /// <summary>
    /// Ресторан
    /// </summary>
    class Restaurant
    {
        public string Title { get; private set; }
        private List<Order> orders; // Активные заказы (агрегация)

        public Restaurant(string title)
        {
            Title = title;
            orders = new();
            Console.WriteLine($"Ресторан {Title} создан.");
        }

        /// <summary>
        /// Добавить заказ
        /// </summary>
        public void AddOrder(Order order)
        {
            if (order == null)
            {
                Console.WriteLine("Нельзя добавить пустой заказ.");
                return;
            }

            orders.Add(order);

            Console.WriteLine($"Заказ N{order.OrderId} добавлен.");
        }

        /// <summary>
        /// Удалить заказ
        /// </summary>
        public void RemoveOrder(Order order)
        {
            if (!orders.Contains(order))
            {
                Console.WriteLine($"Заказа N{order.OrderId} нет.");
                return;
            }

            order.ClearAllDishes();
            orders.Remove(order);

            Console.WriteLine($"Заказ N{order.OrderId} удален.");
        }
    }
}
