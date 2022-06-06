using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp3
{
    //class Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Age { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Name} {Surname} {Age}";
    //    }

    //} 

    //public class IntArray
    //{
    //     private int[] arr = new int[] {11,22,33,44,55,66 };
    //     public int Length { get; } = 6;

    //    public override string ToString()
    //    {
    //        StringBuilder stringBuilder = new StringBuilder();
    //        foreach (var item in arr)
    //        {
    //            stringBuilder.Append($"{item} ");
    //        }
    //        return stringBuilder.ToString();
    //    }

    //    public int this[int index]
    //    {
    //        get { return arr[index]; }
    //        set { arr[index] = value; }
    //    }
    //} 

    //class EnRuDictionary
    //{
    //    public string this[string word]
    //    {
    //        get { 
    //            return word switch
    //            {
    //                "one" => "один",
    //                "two" => "два",
    //                "three" => "три",
    //                "four" => "четыре",
    //                "five" => "пять",
    //                "один" => "one",
    //                "два" => "two",
    //                "три" => "three",
    //                "четыре" => "four",
    //                "пять" => "five",
    //                _ => "This word not"
    //        };

    //            //switch (word)
    //            //{
    //            //    case "one": return "один";
    //            //    case "two": return "два";
    //            //    case "three": return "три";
    //            //    case "four": return "четыре";
    //            //    case "five": return "пять";
    //            //    case "один": return "one";
    //            //    case "два": return "two";
    //            //    case "три": return "three";
    //            //    case "четыре": return "four";
    //            //    case "пять": return "five";
    //            //    default:return "This word not"; ;
    //            //}
    //        } 

    //    }
    //}


    enum Gender
    {
        MALE, FEMALE, OTHER
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age} {Gender}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //  string text = "aaaaa";
            //Console.WriteLine(text?.Length);
            //  string str = text ?? "empty";

            // Console.WriteLine(str);

            //
            //Console.Write("Введите символ: ");
            //char sym = char.Parse(Console.ReadLine());
            //Console.Write("Число символов в строке: ");
            //int length = int.Parse(Console.ReadLine()); 
            //Console.Write("Число строк: "); 
            //int lines = int.Parse(Console.ReadLine()); 

            //for (int i = 0; i < lines; i++) { 
            //    for (int j = 0; j < length; j++) { 
            //        Console.Write(sym); 
            //    } 
            //    Console.WriteLine(); 
            //}



            //Person person = new Person();

            //Console.Write("Enter name    : ");
            //person.Name = Console.ReadLine();

            //Console.Write("Enter surname : ");
            //person.Surname = Console.ReadLine();

            //Console.Write("Enter age     : ");
            ////person.Age = Convert.ToInt32(Console.ReadLine()); BAD
            //int.TryParse(Console.ReadLine(), out int age);
            //person.Age = age;


            //Console.Write("Enter \n0 - Male\n1 - Female\n2 - Other : ");
            ////person.Gender = (Gender)int.Parse(Console.ReadLine()); BAD
            ////person.Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine()); BAD
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object result);
            //person.Gender = result == null ? Gender.OTHER : (Gender)result;

            //Console.WriteLine(person);


            //Gender gender = Gender.FEMALE;

            //Console.WriteLine(gender);









            //EnRuDictionary enRu = new EnRuDictionary();

            //Console.WriteLine(enRu["три"]);







            //IntArray arr = new IntArray();
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr);

            //Console.WriteLine(arr[3]);
            //arr[3] = 1000;
            //Console.WriteLine(arr[3]);











            //checked
            //{
            //    int x = int.MaxValue;
            //    Console.WriteLine(x);
            //    x++;
            //    Console.WriteLine(x);
            //}



            //Console.WriteLine(ReturnValue());

            //try
            //{
            //    Person person = null;

            //    Console.WriteLine(person.Name);
            //    int num1 = FindByIndex(1);
            //    int num2 = FindByIndex(0); 
            //    double result = Division(num1, num2);
            //    Console.WriteLine(result);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("IndexOutOfRangeException => " + ex.Message);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("NullReferenceException => " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception => " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Hello");
            //}



            //try
            //{
            //    Person person = null;

            //    Console.WriteLine(person.Name);
            //    int num1 = FindByIndex(1);
            //    int num2 = FindByIndex(0);
            //    double result = Division(num1, num2);
            //    Console.WriteLine(result);
            //} 
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception => " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Hello");
            //}









            //Console.Write("Hello my brother"); 
            //Environment.Exit(-1);
            //Console.WriteLine(" and sister");
            ////Sleep(1000);
            //Console.Write("Hello my brother");
            //Thread.Sleep(2000);
            //Console.WriteLine(" and sister");


            //Console.WriteLine("HHello my brother");
            //Console.WriteLine("HHello my brother");
            //Console.WriteLine("HHello my brother");

            //Console.ReadKey();

            //Console.Beep(1000, 1000);


            //   Console.WriteLine("HHello my brother");
            //   Console.WriteLine("HHello my brother");
            //   Console.WriteLine("HHello my brother");

            //   // system("cls")
            ////   Console.Clear();

            //   Console.WriteLine("12345");


            //for (int i = 0; i < 100; i++)
            //{
            //    Console.SetCursorPosition(i, i+1);
            //    Console.WriteLine("Hello my brother");
            //}

            //Console.WriteLine("Hello my brother");
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("Hello my brother");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.WriteLine("Hello my brother");

            /////////////////////////////////////////////////////////////////


            //List<Person> people = new List<Person>()
            //{
            //    new Person {Name = "Farid",Surname = "Abdullayev",Age = 26},
            //    new Person {Name = "Oleq",Surname = "Cerkasov",Age = 28},
            //    new Person {Name = "Dmitriy",Surname = "Slepcov",Age = 22}
            //};


            //StringBuilder stringBuilder = new StringBuilder(100);

            //foreach (var person in people)
            //{
            //    stringBuilder.Append($"{person}\n");
            //}


            //Console.WriteLine(stringBuilder);

            //File.WriteAllText("test.txt", stringBuilder.ToString());




            //List<Person> people = new List<Person>();

            //string[] linies = File.ReadAllLines("test.txt");

            //foreach (var line in linies)
            //{
            //    string[] parts = line.Split(' ');

            //    Person person = new Person
            //    {
            //        Name = parts[0],
            //        Surname = parts[1],
            //        Age = int.Parse(parts[2])
            //    };

            //    people.Add(person);
            //}

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////////
            ///


            //Person person = new Person
            //{
            //    Name = "Farid",
            //    Surname = "Abdullayev",
            //    Age = 26
            //};

            //Console.WriteLine(person);

            //File.WriteAllText("test.txt", person.ToString());

            //string text = File.ReadAllText("test.txt");// Farid Abdullayev 26
            //string[] arr = text.Split(' ');

            //Person person = new Person
            //{
            //    Name = arr[0],
            //    Surname = arr[1],
            //    Age = int.Parse(arr[2]) 
            //};


            //Console.WriteLine(person);

            ////////////////////////////////////////////////////////////////////

            //  File.WriteAllText("test.txt","Hello my brother and sister");
            //string text = File.ReadAllText("test.txt");
            //Console.WriteLine(text);

            // File.AppendAllText("test.txt", "Hello my dad"); 


            //static int FindByIndex(int index)
            //{
            //    return arr[index];
            //}

            //static int[] arr = new int[] {0, 11, 22, 33, 44, 55, 66 };

            //static int FindByIndex(int index) => arr[index];

            //static double Division (double a , double b)
            //{
            //    if (b == 0)  throw new Exception("Division by zero");

            //    return a / b;
            //}


            //public static int ReturnValue()
            //{
            //    int result = 0;
            //    try
            //    {
            //        result= 1;
            //    }
            //    catch (Exception ex)
            //    {
            //        result= 2;
            //    }
            //    finally
            //    {
            //        result= 3; 
            //    }
            //    return result;
            //}



            //public static int ReturnValue()
            //{
            //    int result = 0;
            //    try
            //    {
            //        result = 1;
            //        return result;
            //    }
            //    catch (Exception ex)
            //    {
            //        result = 2;
            //    }
            //    finally
            //    {
            //        result = 3;
            //        Console.WriteLine("Hello");
            //    }
            //    Console.WriteLine("99999999999");
            //    return result;
            //}


            //----------------------------------------------------------------------------------//
            //Console.WriteLine($"Ведите символ: ");
            //char s = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Введите длинну: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Введите ширину: ");
            //int b = int.Parse(Console.ReadLine());

            //for (int i = 0; i < a; ++i)
            //{

            //    Console.WriteLine();
            //    for (int j = 0; j < b; ++j)
            //    {
            //        if (i == 0 || i == a - 1 || j == 0 || j == b - 1)
            //            Console.Write($"{s}");
            //        else Console.Write(' ');

            //    }
            //}
           }
        }
    }

        
    

