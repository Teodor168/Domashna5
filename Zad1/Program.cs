namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Преброяване на елементи
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            numbers.AddLast(5);

            Console.WriteLine("Broqt e: " + CountElements(numbers));
        }

        static int CountElements(LinkedList<int> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                count++;
            }
            return count;
        }
    }
}