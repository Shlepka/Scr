
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        string reversedWord = Reverse(word);
        Console.WriteLine("Перевернутое слово: " + reversedWord);

        Console.ReadLine();
    }

    static string Reverse(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

/*

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        string reversedWord = Reverse(word);
        Console.WriteLine("Перевернутое слово: " + reversedWord);

        Console.ReadLine();
    }

    static string Reverse(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

 */
