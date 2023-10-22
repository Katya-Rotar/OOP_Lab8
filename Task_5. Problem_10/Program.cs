internal class Program
{
    private static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split(' ');
        string firstName = input1[0];
        string lastName = input1[1];
        string address = input1[2];
        Tuple<string, string> nameAddressTuple = new Tuple<string, string>(firstName +" "+ lastName, address);

        string[] input2 = Console.ReadLine().Split(' ');
        string name = input2[0];
        int litersOfBeer = int.Parse(input2[1]);
        Tuple<string, int> nameBeerTuple = new Tuple<string, int>(name, litersOfBeer);

        string[] input3 = Console.ReadLine().Split(' ');
        int Integer = int.Parse(input3[0]);
        double Double = double.Parse(input3[1]);
        Tuple<int, double> intDoubleTuple = new Tuple<int, double>(Integer, Double);

        Console.WriteLine($"\n{nameAddressTuple.Item1} -> {nameAddressTuple.Item2}" +
            $"\n{nameBeerTuple.Item1} -> {nameBeerTuple.Item2}" +
            $"\n{intDoubleTuple.Item1} -> {intDoubleTuple.Item2}");
    }
}