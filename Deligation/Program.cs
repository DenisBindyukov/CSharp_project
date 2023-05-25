using System.Diagnostics.Metrics;

namespace F_Deligation
{
    class Program
    {
        public static void Main()
        {
            // Исходный массив чисел
            int[] numbers = { 5, 10, 2, 8, 3, 1, 7, 6, 9, 4 };

            // Сортировка массива по убыванию и выбор только 10 элементов
            var sortedNumbers = numbers.OrderByDescending(num => num).Take(10);

            // Вывод отсортированных чисел
            Console.WriteLine("Отсортированные числа:");
            foreach (int num in sortedNumbers)
            {
                Console.WriteLine(num);
            }


            // Создаем список пользователей
            List<User> users = new List<User>()
            {
                new User() { Name = "John", Age = 25, Country = "Belarus" },
                new User() { Name = "Alice", Age = 30, Country = "USA" },
                new User() { Name = "Bob", Age = 20, Country = "Russia" },
                new User() { Name = "Anna", Age = 35, Country = "Georgia" },
                new User() { Name = "George", Age = 35, Country = "France" },
                new User() { Name = "Denis", Age = 35, Country = "Germany" },
                new User() { Name = "Mark", Age = 35, Country = "Ukraine" },
                new User() { Name = "Michael", Age = 35, Country = "England" },
                new User() { Name = "John", Age = 35, Country = "Germany" },
            };


            List<User> sortedUsers = users
                .Where(u => u.Age > 25)
                .OrderBy(u => u.Name)
                .ThenBy(u => u.Country)
                .ToList();


            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.Name}, {user.Age}, {user.Country}");
            }


            Console.WriteLine(users.First().Name);
            Console.WriteLine(users.Last().Name);

            User findUser = users.FirstOrDefault(u => u.Age == 20);

            if (findUser != null)
            {
                Console.WriteLine(findUser.Name);
            }

            //Если не найдет  ниодного или более одного, выбросит исключение
            Console.WriteLine(users.Single(u => u.Age == 25).Name);
            //Если найдет более одного выбросит исключение, если ниодного вернут null
            Console.WriteLine(users.SingleOrDefault(u => u.Country == "Belarus")?.Name);


            //*******************************************************************************************//

            var list = new List<int> { 1, 2, 3 };
            var query = list.Where(c => c >= 2);
            list.Remove(3); //удаляем третий элемент из списка

            Console.Write(query.Count());
            // КОЛИЧЕСТВО ЭМЕМЕНТОВ ПОЛУЧАЕМ 1 по причине того что оператор Where конструируеться на 70 строке,
            // но вызываеться только оброщении к List, т.е на 73 строке
            //ДЛЯ ТОГО ЧТОБ ОПЕРАТОРЫ list СРАЗУ ОТРАБАТЫВАЛИ (был материалезован) НА СПИСКЕ, необходимо приминять .ToList() что бы получать готовый
            // cписок в момент объявления, это так же оптимизирует код так как если к листу применять циклы, каждый циклы будет каждый раз запускать
            // цепочку операций установленную на List .Where(u => u.Age > 25).OrderBy(u => u.Name).ThenBy(u => u.Country) и тд...
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }


    public class Car
    {
        int speed = 0;

        public event Action<int> TooFastDriving;

        // public event TooFast TooFastDriving;
        //event это надстройка над делегатом
        //public delegate void TooFast(int speed);

        // private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 20;

            if (this.speed > 100)
            {
                //tooFast(this.speed)
                TooFastDriving(this.speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        // public void RegisterOnTooFast(TooFast tooFast)
        // {
        //     this.tooFast = tooFast;
        // }
    }

    class TestDelegate
    {
        static Car car;

        static void TestCar()
        {
            car = new Car();
            //добавление в список делигатов
            car.TooFastDriving += SpeedHandler;
            car.TooFastDriving += SpeedHandler;
            //удаление из списока делигатов
            car.TooFastDriving -= SpeedHandler;

            car.Start();

            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
        }

        private static void SpeedHandler(int speed)
        {
            Console.WriteLine($"I got it! Current speed {speed}");
            car.Stop();
        }
    }
}