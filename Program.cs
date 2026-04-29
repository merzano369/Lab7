namespace Lab7;

static class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.AddFirst(5);
        list.InsertAfterFirst(12);
        list.InsertAfterFirst(8);
        list.InsertAfterFirst(20);
        list.InsertAfterFirst(3);
        list.InsertAfterFirst(15);
        list.InsertAfterFirst(7);

        Console.WriteLine("=== Односпрямований список (елементи типу short) ===");
        Console.WriteLine();

        Console.Write("Початковий список: ");
        list.Print();
        Console.WriteLine();

        short searchValue = 10;
        int foundIndex = list.FindFirstGreaterThan(searchValue);
        Console.WriteLine("--- Операція 1: Знайти перший елемент > " + searchValue + " ---");
        if (foundIndex != -1)
        {
            Console.WriteLine("Знайдено на позиції: " + foundIndex);
        }
        else
        {
            Console.WriteLine("Не знайдено");
        }
        Console.WriteLine();

        double average = list.CalculateAverage();
        int sumAboveAverage = list.FindSumGreaterThanAverage();
        Console.WriteLine("--- Операція 2: Сума елементів > середнього ---");
        Console.WriteLine("Середнє арифметичне: " + average);
        Console.WriteLine("Сума елементів > середнього: " + sumAboveAverage);
        Console.WriteLine();

        LinkedList lessList = list.GetLessThanAverage();
        Console.WriteLine("--- Операція 3: Новий список з елементів < середнього ---");
        Console.Write("Елементи < " + average + ": ");
        lessList.Print();
        Console.WriteLine();

        var (maxValue, maxIndex) = list.FindMax();
        Console.WriteLine("--- Операція 4: Видалити елементи після максимального ---");
        Console.WriteLine("Максимальний елемент: " + maxValue + " (позиція " + maxIndex + ")");

        list.RemoveAfterMax();
        Console.Write("Список після видалення: ");
        list.Print();
        Console.WriteLine();

        Console.WriteLine("=== Демонстрація завершена ===");
    }
}