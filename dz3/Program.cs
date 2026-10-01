using dz3.enums;
using System.Security.Cryptography;

Console.WriteLine("#1");
int[] numbers = new int[10];
Console.WriteLine("Введите 10 чисел");
for (int i = 0; i < numbers.Length; i++) 
{
    Console.Write($"Число {i + 1}: ");
    string input = Console.ReadLine();
    int.TryParse(input, out numbers[i]);
}
for (int l = 0; l < numbers.Length - 1; l++)
{
    if (numbers[l] >= numbers[l + 1])
    {
        Console.WriteLine($"Последовательность нарушает {l + 1} число");
        break;
    }
}
Console.WriteLine("Последовательность упорядочена по возрастанию");

Console.WriteLine("#2");
Console.WriteLine("#2");
string card  = Console.ReadLine();
int k;
try
{
    string[] cards = new string[15];
    cards[6] = "Шесть";
    cards[7] = "Семь";
    cards[8] = "Восемь";
    cards[9] = "Девять";
    cards[10] = "Десять"; 
    cards[11] = "Валет";
    cards[12] = "Дама";
    cards[13] = "Король";
    cards[14] = "Туз";
    if (int.TryParse(card, out k))
    {
        if (k < 6 || k > 14)
        {
            throw new IndexOutOfRangeException("Неверно введен номер карты");
        }
        if (k >= 6 && k<= 14)
        {
            Console.WriteLine($"{k} это {cards[k]}");
        }
    }
    else
    {
        throw new FormatException("Введите верно номер карты");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine();
}

Console.WriteLine("#3");
Console.WriteLine("Введите слово:");
string word = Console.ReadLine().ToLower();
string result = "beer";
switch (word)
{
    case "Jabroni":
        result = "Patron Tequila";
        break;
    case "School Counselor":
        result = "Anything with Alcohol";
        break;
    case "Programmer":
        result = "Hipster Craft Beer";
        break;
    case "Politician":
        result = "Your tax dollars";
        break;
    case "Rapper":
        result = "Cristal";
        break;
    default:
        result = "Beer";
        break;
}
Console.WriteLine(result);
Console.ReadKey();

Console.WriteLine("#4");
Console.WriteLine("Введите число");
if (int.TryParse(Console.ReadLine(), out int numday))
{
    if (numday > 0 && numday < 8)
    {
        enums.days day = (enums.days)numday;
        Console.WriteLine($"День недели: {day}");
    }
    else
    {
        Console.WriteLine("ошибка");
    }
}
else
{
    Console.WriteLine("Введено неверно");
}

Console.WriteLine("#5");
string[] toys = { "Hello Kitty", "Barbie doll", "Teddy Bear", "Lol doll", "Hello Kitty", "Spider man", "Barbie doll" };
int sumdoll = 0;
foreach (string toy in toys)
{
    if (toy == "Hello Kitty" || toy == "Barbie doll")
    {
        sumdoll++;
    }
}
Console.WriteLine($"Количество кукол: {sumdoll}");