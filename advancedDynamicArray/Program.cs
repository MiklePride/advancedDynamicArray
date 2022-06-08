class program
{
    static void Main(string[] args)
    {
        bool isExit = false;
        string exitCommand = "exit";
        string commandSumOfNumber = "sum";
        string userInput;
        int userNumber = 0;
        int sumOfUserNumber = 0;

        List<int> userNumbersStorage = new List<int>();

        Console.WriteLine($"Добро пожаловать в хранилище чисел!" +
            $"\nДля записи просто введите любое число." +
            $"\nЧтобы расчитать сумму всех записаных чисел введите команду {commandSumOfNumber}." +
            $"\nДля выхода из программы введите команду {exitCommand}");

        while (isExit == false)
        {
            Console.WriteLine("Введите число или команду: ");
            userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out userNumber);

            if (isNumber)
            {
                WriteNumber(userNumbersStorage, userNumber);
            }
            else if (userInput == commandSumOfNumber)
            {
                sumOfUserNumber = CalculateSumOfNumber(userNumbersStorage);
            }
            else if (userInput == exitCommand)
            {
                isExit = true;
            }
            else
            {
                Console.WriteLine("Данные не корректны!!!");
            }
        }
    }

    static void WriteNumber(List<int> numbers, int number)
    {
        numbers.Add(number);
        Console.WriteLine("Число записано! Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
        Console.Clear();
    }

    static int CalculateSumOfNumber(List<int> numbers)
    {
        int sumNumbers = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sumNumbers += numbers[i];
        }
        Console.WriteLine($"Сумма всех чисел хранилища равна - {sumNumbers}\n" +
                    $"Нажмите любую кнопку для продолжения...");
        Console.ReadKey();
        Console.Clear();
        return sumNumbers;
    }
}