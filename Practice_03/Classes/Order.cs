using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03.Classes
{
    /// <summary>
    /// Заказ
    /// </summary>
    class Order
    {
        // Статический функционал - у каждого заказа свой номер
        private static int lastOrderId;
        private static int NewId() => ++lastOrderId;

        private List<Dish> dishes;  // Блюда в заказе (композиция)
        public int OrderId { get; private set; }
        public double Cost
        {
            get
            {
                double cost = 0;
                foreach (Dish dish in dishes)
                    cost += dish.Cost;
                return cost;
            }
        }

        public Order(List<Dish> dishes)
        {
            OrderId = NewId();
            this.dishes = dishes;
        }

        public Order()
        {
            OrderId = NewId();
            this.dishes = new List<Dish>();
            Console.WriteLine($"Создан заказ N{OrderId}");
        }

        /// <summary>
        /// Добавить блюдо
        /// </summary>
        public void AddDish(Dish dish)
        {
            if (dish == null)
            {
                Console.WriteLine("Нельзя добавить пустое блюдо.");
                return;
            }

            dishes.Add(dish);

            Console.WriteLine("Блюдо добавлено в заказ.");
        }

        /// <summary>
        /// Удалить блюдо
        /// </summary>
        public void RemoveDish(Dish dish)
        {
            if (!dishes.Contains(dish))
            {
                Console.WriteLine("Блюда уже нет в заказе.");
                return;
            }

            dishes.Remove(dish);

            Console.WriteLine($"Блюдо {dish.Title} удалено из заказа N{OrderId}.");
        }

        /// <summary>
        /// Удалить все заказы
        /// </summary>
        public void ClearAllDishes()
        {
            foreach (Dish dish in dishes[..])
                RemoveDish(dish);
        }

        public override string ToString() => $"Заказ N{lastOrderId}. Блюда:\n{string.Join('\n', dishes)}\nСтоимость заказа: {Cost} руб.";
    }
}
