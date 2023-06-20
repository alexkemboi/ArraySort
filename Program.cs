using System;
class Progran
{
    static void Main(string[] args)
    {
        string[] dictionary = { "apple", "orange", "mango", "banana", "ovacado" };
        Array.Sort(dictionary);
        foreach (string key in dictionary)
        {
            Console.WriteLine(key);
        }
    }
}