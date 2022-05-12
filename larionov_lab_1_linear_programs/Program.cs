namespace larionov_lab_1_linear_programs //Пространство имён
{
    class Class1 //Класс
    {
        static void Main(string[] args) //Главная функция
        {
            void functionMyCosZ1(double a, bool isMore = true) //Функция вычисляющая значение z1
            {
                Console.WriteLine($"Z1 = cos({a}) + cos(2 * {a}) + cos(6 * {a}) + cos(7 * {a})"); //Выводим на экран исходную формулу со значением "A"

                double val1 = a;        //Вычисление аргумента 1 функции
                double val2 = 2 * a;    //Вычисление аргумента 2 функции
                double val3 = 6 * a;    //Вычисление аргумента 3 функции
                double val4 = 7 * a;    //Вычисление аргумента 4 функции

                double cos1 = Math.Cos(val1);   //Вычисление значения 1 функции
                double cos2 = Math.Cos(val2);   //Вычисление значения 2 функции
                double cos3 = Math.Cos(val3);   //Вычисление значения 3 функции
                double cos4 = Math.Cos(val4);   //Вычисление значения 4 функции

                if (isMore) //Если нужно отобразить ход вычислений
                {
                    Console.WriteLine($"Z1 = cos({val1}) + cos({val2}) + cos({val3}) + cos({val4})"); //Показываем функцию с вычисленными аргументами

                    Console.WriteLine($"\ncos({val1}) = {cos1}");   //Выводим вычисление 1 функции
                    Console.WriteLine($"cos({val2}) = {cos2}");     //Выводим вычисление 2 функции
                    Console.WriteLine($"cos({val3}) = {cos3}");     //Выводим вычисление 3 функции
                    Console.WriteLine($"cos({val4}) = {cos4}\n");   //Выводим вычисление 4 функции

                    Console.WriteLine($"Z1 = {cos1} + {cos2} + {cos3} + {cos4}"); //Выводим промежуточный результат вычислений
                }
                Console.WriteLine($"Z1 = {cos1 + cos2 + cos3 + cos4}\n"); //Выводим конечный результат
            }

            void functionMyCosZ2(double a, bool isMore = true) //Функция вычисляющая значение z2
            {
                Console.WriteLine($"Z2 = 4 * cos({a}/2) * cos(5/2 * {a}) * cos(4 * {a})");  //Выводим на экран исходную формулу со значением "A"

                double val1 = a / 2;    //Вычисление аргумента 1 функции
                double val2 = 2.5 * a;  //Вычисление аргумента 2 функции
                double val3 = 4 * a;    //Вычисление аргумента 3 функции

                double cos1 = Math.Cos(val1);   //Вычисление значения 1 функции
                double cos2 = Math.Cos(val2);   //Вычисление значения 2 функции
                double cos3 = Math.Cos(val3);   //Вычисление значения 3 функции

                if (isMore) //Если нужно отобразить ход вычислений
                {
                    Console.WriteLine($"Z2 = 4 * cos({val1}) * cos({val2}) * cos({val3})"); //Показываем функцию с вычисленными аргументами

                    Console.WriteLine($"\ncos({val1}) = {cos1}");   //Выводим вычисление 1 функции
                    Console.WriteLine($"cos({val2}) = {cos2}");     //Выводим вычисление 2 функции
                    Console.WriteLine($"cos({val3}) = {cos3}\n");   //Выводим вычисление 3 функции

                    Console.WriteLine($"Z2 = 4 * {cos1} * {cos2} * {cos3}");    //Выводим промежуточный результат вычислений
                    Console.WriteLine($"Z2 = {4 * cos1} * {cos2} * {cos3}");    //Выводим промежуточный результат вычислений
                }
                Console.WriteLine($"Z2 = {4 * cos1 * cos2 * cos3}");    //Выводим конечный результат
            }

            Console.WriteLine("Варинат №6. Ларионов Никита Юрьевич. гр. 110з\n");   //Выводим информацию о студенте и варианте работы

            Console.WriteLine("Z1 = cos(A) + cos(2A) + cos(6A) + cos(7A)\n");   //Выводим формулу №1
            Console.WriteLine("Z2 = 4 * cos(A/2) * cos(5/2A) * cos(4A)\n");     //Выводим формулу №2

            string aStr = "";   //Переменная для строкового значения "A"
            bool isNumber = false, isMore = true;   //Переменные для определения является ли "А" числом и отображать ли ход вычислений
            
            const string kFileName = "data.txt";      //Имя файла с исходными данными

            while (true)    //Цикл из-за которого завершение программы контролируется пользователем
            {
                Console.WriteLine("\nХотите видеть ход вычислений? [y/n]");     //Задаём вопрос пользователю
                isMore = Console.ReadLine()?.ToLower() != "n";      //Определяем режим показа информации

                Console.WriteLine($"\nВведите значение A (число). Для чтения данных из файла {kFileName} введите \"F\"");   //Определяем режим работы программы
                Console.WriteLine("Для выхода введите \"Z\": ");    //Сообщаем пользователю возможность выхода из программы

                aStr = Console.ReadLine().ToLower();    //получаем значение "А"


                isNumber = double.TryParse(aStr, out var a);    //проверяем является ли "А" числом

                if (aStr == "z")     //проверяем не хочет ли пользователь прекратить работу программы
                {
                    break;  //прекращаем работу программы
                }
                else if (aStr == "f")   //проверяем не хочет ли пользователь прочитать данные из файла
                {

                    if (File.Exists(kFileName))     //Проверяем наличие файла (в папке с исполняемым файлом)
                    {

                        try {   //Исключение поможет избежать краха программы в случае ошибки или если прочитать данные из существующего файла не получиться 

                            StreamReader file = new StreamReader(kFileName); //открываем файл для чтения

                            int countStrings = 0, countProcessingStrings = 0; //переменные для подсчета значений в файле и успешных вычислений

                            while (!file.EndOfStream)   //чтение файла
                            {
                                ++countStrings; //считаем строки в файле

                                aStr = file.ReadLine(); //читаем строку
                                isNumber = double.TryParse(aStr, out a); //проверяем является ли она числом если да, то заносим результат в переменную "а"

                                if (isNumber) //если строка является числом
                                {
                                    Console.WriteLine("================================================================"); //начало вычислений
                                    Console.WriteLine($"A({countStrings}) = {a}\n");    //Выводим номер строки и значение числа "а"

                                    Console.ForegroundColor = ConsoleColor.Green;   //Z1 выведем зеленым цветом
                                    functionMyCosZ1(a, isMore);     //вычислим значение Z1 со значением "а" с учетом режима вывода информации

                                    Console.ForegroundColor = ConsoleColor.Blue;    //Z2 выведем синим цветом
                                    functionMyCosZ2(a, isMore);     //вычислим значение Z2 со значением "а" с учетом режима вывода информации

                                    Console.ResetColor();   //сбросим цвета консоли
                                    Console.WriteLine("================================================================\n"); //конец вычислений

                                    ++countProcessingStrings; //инкрементируем значение успешных вычислений
                                }
                                else //если строка не число
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;      //выведем красным цветом сообщение об ошибке
                                    Console.WriteLine($"A({countStrings}) = {aStr} - не число!\n");     //Выводим номер строки и значение числа "а" с текстом ошибки
                                    Console.ResetColor();   //сбросим цвета консоли
                                }
                            }

                            file.Close();   //закрываем файл

                            Console.WriteLine($"\nКоличество строк (чисел) в файле {kFileName}: {countStrings}"); //Выводим информацию для пользователя

                            Console.ForegroundColor = ConsoleColor.Green;   //выведем текст зеленым цветом
                            Console.WriteLine($"Количество успешных вычислений: {countProcessingStrings}"); //Выводим информацию для пользователя

                            if (countStrings > countProcessingStrings)  //если не все строки в файле оказались числами
                            {
                                Console.ForegroundColor = ConsoleColor.Red;     //выведем ошибку красным цветом
                                Console.WriteLine($"Количество ошибок: {countStrings - countProcessingStrings}");   //Выводим информацию для пользователя

                            }
                        }
                        catch(Exception e) //Ловим исключение
                        {
                            Console.ForegroundColor = ConsoleColor.Red;     //выведем ошибку красным цветом
                            Console.WriteLine($"Ошибка: {e.Message}");       //Выводим информацию для пользователя
                        }

                    }
                    else //если файла не существует
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //выведем ошибку красным цветом
                        Console.WriteLine($"Файл {kFileName} не существует!");  //Выводим информацию для пользователя
                    }

                }
                else if (!isNumber) //Если введенные пользователем данные не являются числом
                {
                    Console.ForegroundColor = ConsoleColor.Red;     //выведем ошибку красным цветом
                    Console.WriteLine("\nНекорректный ввод!\n");    //Выводим информацию для пользователя
                }
                else
                {
                    Console.WriteLine($"\nA = {a}\n"); //Выведем значение переменной "а"

                    Console.ForegroundColor = ConsoleColor.Green;   //выведем текст зеленым цветом
                    Console.WriteLine("Z1 = cos(A) + cos(2A) + cos(6A) + cos(7A)");     //выведем формулу Z1 в исходном виде
                    functionMyCosZ1(a, isMore);     //вычислим значение Z1 со значением "а" с учетом режима вывода информации

                    Console.ForegroundColor = ConsoleColor.Blue;    //выведем текст синим цветом
                    Console.WriteLine("Z2 = 4 * cos(A/2) * cos(5/2A) * cos(4A)");    //выведем формулу Z2 в исходном виде
                    functionMyCosZ2(a, isMore);     //вычислим значение Z2 со значением "а" с учетом режима вывода информации
                }


                Console.ResetColor();   //сбросим цвета консоли

            }

        }
    }
}