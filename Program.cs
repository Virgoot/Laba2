using System;
// aboba
class Program
{
    static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            printMenu();

            int userInput;
            bool validMenuChoice = int.TryParse(Console.ReadLine(), out userInput);

            if (validMenuChoice && userInput >= 1 && userInput <= 3)
            {
                switch (userInput)
                {
                    case 1:
                        {
                            const double PI = Math.PI;

                            Console.Write("Введите значение A: ");
                            bool validA = double.TryParse(Console.ReadLine(), out double a);

                            if (validA)
                            {
                                Console.Write("Введите значение B: ");
                                bool validB = double.TryParse(Console.ReadLine(), out double b);

                                if (validB)
                                {
                                    double cosB = Math.Cos(b);

                                    if (cosB >= 0)
                                    {
                                        double f = Math.Pow(Math.Sin((3 * PI / 4) + (a / 3)), 2) + Math.Sqrt(cosB);
                                        Console.WriteLine($"Результат - {f:F2}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка: подкоренное выражение cos(B) < 0, вычисление невозможно.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка: введите число для B!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: введите число для A!");
                            }

                          
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("\n----------------------------------------");
                            Console.WriteLine("Кошель Виталий Михайлович / 6106-090301D");
                            Console.WriteLine("----------------------------------------\n");
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Вы уверены?: (д/н)");
                            string userAnswer = Console.ReadLine();

                            if (userAnswer == "д")
                            {
                                isRunning = false; 
                            }
                            else if (userAnswer != "н")
                            {
                                Console.WriteLine("Некорректный ввод! Возвращаю в меню");
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Зачем ты вводишь что-то, кроме цифр от 1 до 3?");
            }
        }
    }

    static void printMenu()
    {
        Console.WriteLine("1. Отгадать ответ");
        Console.WriteLine("2. Об авторе");
        Console.WriteLine("3. Выход");
        Console.WriteLine("Выберите вариант (1-3): ");
    }
}
