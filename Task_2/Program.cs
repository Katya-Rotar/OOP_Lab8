using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list = new List<Box<string>>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            Box<string> box = new Box<string>(input);
            list.Add(box);
        }
        string[] input_n = Console.ReadLine().Split(' ');
        int n1 = int.Parse(input_n[0]);
        int n2 = int.Parse(input_n[1]);
        SwapElements(list, n1, n2);
        foreach (Box<string> box in list)
        {
            int box_int;
            if (int.TryParse(box.value, out box_int))
            {
                Box<int> intBox = new Box<int>(box_int);
                Console.WriteLine(intBox.ToString());
            }
            else
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
    static void SwapElements<T>(List<T> list, int n1, int n2) {
        T element = list[n1];
        list[n1] = list[n2];
        list[n2] = element;
    }
}