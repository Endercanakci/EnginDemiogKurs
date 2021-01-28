using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager<int, string> X = new DictionaryManager<int, string>();
            X.Add(10, "Taha");
            X.Add(20, "Ender");
            X.Add(30, "Engin");
            X.Show();
        }
    }
}