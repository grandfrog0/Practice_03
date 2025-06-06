using Practice_03.Classes;

namespace Practice_03
{
    internal class Program
    {
        /* Ресторан содержит заказы (агрегация), а каждый заказ содержит блюда (композиция).
         * Ресторан может добавлять/удалять заказы.
         * Заказ может добавлять/удалять блюда.
         * При удалении заказа блюда удаляются автоматически. 
         */
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("Claude Monet");

            Order order1 = new Order();
            order1.AddDish(new("Креветки", 250, 3));
            order1.AddDish(new("Пюре", 210));
            order1.AddDish(new("Морс", 85));
            Console.WriteLine(order1);
            restaurant.AddOrder(order1);
            Console.WriteLine();

            Order order2 = new Order();
            order2.AddDish(new("Спагетти", 185));
            order2.AddDish(new("Картофель фри", 65));
            order2.AddDish(new("Апельсиновый сок", 80));
            Console.WriteLine(order2);
            restaurant.AddOrder(order2);
            Console.WriteLine();

            Order order3 = new Order();
            order3.AddDish(new("Макарун", 65, 2));
            order3.AddDish(new("Эспрессо", 80));
            Console.WriteLine(order3);
            restaurant.AddOrder(order3);
            Console.WriteLine();

            restaurant.RemoveOrder(order1);
            restaurant.RemoveOrder(order2);
            restaurant.RemoveOrder(order3);
            restaurant.RemoveOrder(order3);
        }
    }
}
