namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вмъкване на елемент след даден възел


            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(4);
            numbers.AddLast(5);

            InsertAfterValue(numbers, 2, 3);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static void InsertAfterValue(LinkedList<int> list, int selectedNum, int valueToInsert)
        {
            LinkedListNode<int> currentNode = list.First;
            while (currentNode != null)
            {
                if (currentNode.Value == selectedNum)
                {
                    list.AddAfter(currentNode, valueToInsert);
                    return;
                }
                currentNode = currentNode.Next;
            }
            Console.WriteLine($"{selectedNum} ne e nameren v spisuka");
        }
    }
}