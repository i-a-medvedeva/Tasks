//Медведева Ирина


// 1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
// В результате вся информация выводится в одну строчку:
// а) используя  склеивание;

Console.Write("Введите имя ");
string userName = Console.ReadLine();

Console.Write("Введите фамилию ");
string userSurname = Console.ReadLine();

Console.Write("Введите возраст ");
int userAge = int.Parse(Console.ReadLine());

Console.Write("Введите рост ");
int userHeight = int.Parse(Console.ReadLine());

Console.Write("Введите вес ");
int userWeight = int.Parse(Console.ReadLine());

Console.Write(userName + " " + userSurname + " " + userAge + " " + userHeight + " " + userWeight);
// 	б) используя форматированный вывод;

Console.WriteLine();
Console.Write(userName);
Console.Write(userSurname);
Console.Write(userAge);
Console.Write(userHeight);
Console.Write(userWeight);

// 	в) используя вывод со знаком $.
Console.WriteLine();
Console.WriteLine ($"{userName} {userSurname} {userAge} {userHeight} {userWeight}");













// 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
// где m — масса тела в килограммах, h — рост в метрах.


// 3.а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
// используя спецификатор формата .2f (с двумя знаками после запятой);

// int x1 = 1;
// int y1 = 1;
// int x2 = 2;
// int y2 = 2;

// //double distance = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
// double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine(distance);




// 3.б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.






// 4. Написать программу обмена значениями двух переменных:
// а) с использованием третьей переменной;
// 	б) *без использования третьей переменной.








// 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) *Сделать задание, только вывод организовать в центре экрана.
// в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).









// 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
