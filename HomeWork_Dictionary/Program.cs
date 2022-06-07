using System;

namespace HomeWork_Dictionary
{
    class EnRusDictionary
    {
        public string this[string word]
        {
            get {
                return word switch
                {
                    "mother" => "мама",
                    "father" => "папа",
                    "son" => "сын",
                    "daughter" => "дочь",
                    "children" => "дети",
                    "hello" => "привет",
                    "world" => "мир",
                    "me" => "мне",
                    "like" => "нравится",
                    "program" => "программа",
                    "create" => "создавать",
                    "beautiful" => "прекрасная",
                    "this" => "это",
                    "motherland" => "родина",
                    "house" => "здание",
                    "home" => "дом",
                    "we" => "мы",
                    "send" => "пошли",
                    "in" => "на",
                    "square" => "площадь",
                    "мама" => "mother",
                    "папа" => "father",
                    "сын" => "son",
                    "дочь" => "daughter",
                    "дети" => "children",
                    "привет" => "hello",
                    "мир" => "world",
                    "мне" => "me",
                    "нравится" => "like",
                    "программа" => "program",
                    "создавать" => "create",
                    "прекрасная" => "beautiful",
                    "это" => "this",
                    "родина" => "motherland",
                    "здание" => "house",
                    "дом" => "home",
                    "мы" => "we",
                    "пошли" => "send",
                    "на" => "in",
                    "площадь" => "square",
                    _=> "This word is not in the dictionary!!!"
                };
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EnRusDictionary enRusD = new EnRusDictionary();
            Console.WriteLine("Введите слово или строку: ");
            string text = Console.ReadLine().ToLower();
            string[] textArray = text.Split(' ');
            foreach (string word in textArray) Console.Write($"{enRusD[word]}" + " ");
        }
    }
}
