// // Медведева Ирина

// // 1. Написать метод, возвращающий минимальное из трёх чисел.
// Console.WriteLine("Введите три целых числа");
// Console.Write("Первое число: ");
// int a = int.Parse(Console.ReadLine()); //int a = Convert.ToInt32(Console.ReadLine()); // можно и так проверть 
//                                        // введенные числа на целочисленность
// Console.Write("Второе число: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("Третье число: ");
// int c = int.Parse(Console.ReadLine());

// int Min(int a, int b, int c)
// {
//     int min = a;

//     if (b < min) min = b;
//     if (c < min) min = c;
//     return min;
// }

// Console.WriteLine("Минимальное число: " + Min(a, b, c));

// // 2. Написать метод подсчета количества цифр числа.

// int a = new Random().Next(1, 999999);
// Console.WriteLine(a);
// //Console.WriteLine("Введите целое положительное число: "); //можно число задавать из консоли
// //uint n = uint.Parse(Console.ReadLine());
// int Count(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         n = n / 10;// так как n-целое, деление целочисленное	
//         count++;
//     }
//     return count;
// }

// Console.WriteLine($"В числе {Count(a)} цифр");


// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a > 0)
{
    int NumberSumm(int n)
    {
        int s = 0;
        while (n != 0)
        {
            s = s + n % 10;
            n = n / 10;
        }
        return s;
    }
    static bool isOdd(int n)
    {
        return n % 2 == 0;
    }
}
else break;









static int NumberSumm(int n)
{
    int s = 0;
    while (n != 0)
    {
        s = s + n % 10;
        n = n / 10;
    }
    return s;
}
static bool isOdd(int n)
{
    return n % 2 == 0;
}

static void Main()
{
    for (int i = 1; i <= 100; i++)
    {
        int sc = NumberSumm(i);
        if (isOdd(sc)) Console.WriteLine("{0} {1}", i, sc);
    }
}
}

// // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
// // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
// // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.


// void Main(string log, string pass)
// {
//     int count = 0;
//     do
//     {
//         Console.Write("Введите логин: ");
//         log = Console.ReadLine();
//         Console.Write("Введите пароль: ");
//         pass = Console.ReadLine();
//         count++;
//         if (log == "root" || pass == "GeekBrains")
//         {
//             Console.WriteLine("Вы прошли авторизацию");
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Проверьте правильность введенного логина и пароля");
//         }
//     }
//     while (count <= 2);// Повторять пока условие истинно(true)

//     if (count > 2)
//     {
//         Console.WriteLine("Вы сделали " + count + " неудачные попытки ввода, доступ к аккаунту ограничен, свяжитесь со службой поддержки");
//     }
// }
// string login = string.Empty;
// string password= string.Empty;
// Main(login,password);


// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
// нужно ли человеку похудеть, набрать вес или всё в норме.
// 5. б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
// 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
// «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, 
// используя структуру DateTime.
// // 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).

// void Loop(int a, int b)
// {
//     Console.Write($"{a}   "); //Console.Write("{0,4} ", a); //0,4 - задание интервала между значениями на вывод
//     if (a < b) Loop(a + 1, b);
// }

// Loop(1, 5);


// // 8. б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
// // сумма чисел, включая а и b.
// int Nums(int b)
// {
//     int a = 2;
//     if (b > a)
//     {
//         return Nums(b - 1) + b;
//     }
//     else
//     {
//         return a;
//     }
// }

// Console.WriteLine(Nums(3));

// // Достаточно решить 4 задачи. Разбивайте программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы делайте в одном решении.
