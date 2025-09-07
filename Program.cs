namespace Alekseev_ISP_232_Lab2
{
    internal class Program
    {
        static int health = 100;  // Объявляем переменную health (здоровье) и задаём начальное значение 100
        static void Main(string[] args)
        {
            //Задание 1
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0 ) { Console.WriteLine($"Число {number} чётное"); }
            //else { Console.WriteLine($"Число {} нечётное"); }
            //Задание 2
            //string password = Console.ReadLine();
            //string conf_password = Console.ReadLine();
            //if (password == conf_password) { Console.WriteLine("Пароль принят"); }
            //else { Console.WriteLine("Пароль не принят"); }
            //Задание 3
            //int num = Convert.ToInt32 (Console.ReadLine());
            //double num1 = num / 1000;
            //double num2 = num / 100 % 10;
            //double num3 = num / 10 % 10;
            //double num4 = num % 10;

            //if (Math.Round(num1, 0) + num4 == Math.Round(num2, 0) - Math.Round(num3, 0)) { Console.WriteLine("Yes"); }
            //else { Console.WriteLine("No"); }
            //Задание 4
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18) { Console.WriteLine("Доступ разрешен"); }
            //else { Console.WriteLine("Доступ запрещен"); }
            //Задание 5
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2) { Console.WriteLine(num2); }
            //else { Console.WriteLine(num1); }
            //Задание 6
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //string operation = Console.ReadLine();

            //switch (operation) {
            //    case "+":
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //        break;
            //}
            //Задание 7
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Pn");
            //        break;
            //    case 2:
            //        Console.WriteLine("Vt");
            //        break;
            //    case 3:
            //        Console.WriteLine("Sr");
            //        break;
            //    case 4:
            //        Console.WriteLine("Cht");
            //        break;
            //    case 5:
            //        Console.WriteLine("Pt");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sb");
            //        break;
            //    case 7:
            //        Console.WriteLine("Vs");
            //        break;
            //}
            //Задание 8
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //string operation = Console.ReadLine();

            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //        break;
            //}
            //Задание 9
            //int level = Convert.ToInt32(Console.ReadLine());
            //switch (level)
            //{
            //    case 1:
            //        Console.WriteLine("легкий");
            //        break;
            //    case 2: Console.WriteLine("Средний");
            //        break;
            //    case 3: Console.WriteLine("Сложный");
            //        break;
            //    default:
            //        Console.WriteLine("Несуществует");
            //        break;
            //}
            //Задание 10
            //    Console.WriteLine($"Здоровье персонажа: {health}");  // Выводим текущее здоровье на экран
            //    TakeDamage(30);  // Вызываем метод TakeDamage с параметром 30 (урон)
            //}
            // Метод, который уменьшает здоровье персонажа
            //static void TakeDamage(int damage)  // Принимает один параметр: damage — количество урона
            //{
            //    health -= damage;  // Уменьшаем здоровье на величину урона
            //    Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}.");
            // Выводим сообщение о получении урона и текущем здоровье
            //Задание 11
            //Console.Write("Выбери класс. воин, маг, разбойник, паладин, варвар, охотник, друид, жрец: ");
            //string class_game = Console.ReadLine();
            //string[] shooter_class = ["маг", "охотник", "жрец"];
            //if (shooter_class.Any(n => n == class_game )) { Console.WriteLine($"{class_game} - дальнобойщик"); }
            //else { Console.WriteLine($"{class_game} - ближний боец"); }
            //Задание 12
            //int sum = 0;
            //for (int i = 0; i <3; i++)
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a > 0) { sum += a; }
            //}
            //Console.WriteLine(sum);
            //Задание 13
            //Console.WriteLine("Выбери путь: А или Б: ");
            //Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
            //Console.WriteLine("Путь Б: Пойти по темному коридору.");
            //string way = Console.ReadLine();

            //if (way == "А")
            //{
            //    Console.WriteLine("Отгодай загадку.");
            //    Console.WriteLine("Дракон говорит: Кто не дышит, но живет; хоть не нужно — много пьет; и в\r\nжизни, и в смерти тело как лед.");
            //    Console.Write("Ответ? ");
            //    string answer = Console.ReadLine().ToLower();
            //    if (answer == "рыба") { Console.WriteLine("Дверь открыта"); }
            //    else { Console.WriteLine("Страшная смерть"); }
            //}
            //else
            //{
            //    Console.WriteLine("Выбери дверь: 1 или 2: ");                                
            //    string door = Console.ReadLine();
            //    if (door == "1") {
            //        Console.WriteLine("За ней скрыты сокровища Dungeon Master’а.");
            //        Console.WriteLine("Ура, Win"); }
            //    else {
            //        Console.WriteLine("За ней — ловушка с ядовитыми шипами");
            //        Console.WriteLine("Смерть"); }
            //}
        }
    }
}