using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cat";
            Console.Write("Введите возраст: ");
            var age = Console.ReadLine();
            var catColor = new CatColor()
            {
                SickColor = "Зеленый",
                HealthyColor = "Белый"
            };
            var newCat = new Cat(age, catColor);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Имя {0}\nВозраст {1}\nТекущий цвет {2}", newCat.Name, age, newCat.CurrentColor);
                Console.WriteLine("1. Задать имя\n2. Задать цвет\n3. Ударить\n4. Покормить");
                try
                {
                    switch (Int32.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.Write("\nВведите имя: ");
                            newCat.Name = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Введите цвет больной кошки: ");
                            newCat.Color.SickColor = Console.ReadLine();
                            Console.Write("Введите цвет здоровой кошки: ");
                            newCat.Color.HealthyColor = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Вы наказали кошку");
                            newCat.Punish();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Вы покормили кошку");
                            newCat.Feed();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Неправильный пункт меню");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка");
                    Console.ReadKey();
                }
            }
        }
    }
}
