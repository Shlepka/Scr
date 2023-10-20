class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine();

        string encryptedWord = Encrypt(word);
        Console.WriteLine("Со смещением слово: " + encryptedWord);

        string reversedWord = Reverse(encryptedWord);
        Console.WriteLine("Перевернутое слово: " + reversedWord);

        //string decryptedWord = Decrypt(encryptedWord);
        //Console.WriteLine("Расшифрованное слово: " + decryptedWord);

        Console.ReadLine();
    }
    static string Reverse(string encryptedWord)
    {
        char[] charArray = encryptedWord.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string Encrypt(string word)
    {
        string encryptedWord = "";

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(c + 1); // Замена на следующую букву в алфавите
                encryptedWord += encryptedChar;
            }
            else
            {
                encryptedWord += c; // Добавление символа без изменений
            }
        }

        return encryptedWord;
    }

    //static string Decrypt(string encryptedWord)
    //{
    //    string decryptedWord = "";

    //    foreach (char c in encryptedWord)
    //    {
    //        if (char.IsLetter(c))
    //        {
    //            char decryptedChar = (char)(c - 1); // Замена на предыдущую букву в алфавите
    //            decryptedWord += decryptedChar;
    //        }
    //        else
    //        {
    //            decryptedWord += c; // Добавление символа без изменений
    //        }
    //    }

    //    return decryptedWord;
    //}
}