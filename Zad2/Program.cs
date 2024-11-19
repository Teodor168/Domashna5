using System.Threading.Channels;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка за съдържание
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Alice");
            names.AddLast("Bob");
            names.AddLast("John");

            SearchName(names, "John");
            SearchName(names, "Michael");
        }

        static void SearchName(LinkedList<string> list, string name)
        {
            foreach (var item in list)
            {
                if (item == name)
                {
                    Console.WriteLine($"{name} e v spisuka");
                    return;
                }
            }
            Console.WriteLine($"{name} go nqma v spisuka");
        }
    }
}