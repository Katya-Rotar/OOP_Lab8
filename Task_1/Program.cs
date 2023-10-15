internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input_string = Console.ReadLine();
            int input_int;
            if (int.TryParse(input_string, out input_int))
            {
                Box<int> intBox = new Box<int>(input_int);
                Console.WriteLine(intBox.ToString());
            }
            else
            {
                Box<string> stringBox = new Box<string>(input_string);
                Console.WriteLine(stringBox.ToString());
            }
        }
    }
}