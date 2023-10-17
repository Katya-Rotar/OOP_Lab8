internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> list_string = new List<Box<string>>();
        List<Box<double>> list_double = new List<Box<double>>();

        Box<double> doubleBox = null;
        Box<string> box = null;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            double box_double;
            if (double.TryParse(input, out box_double))
            {
                doubleBox = new Box<double>(box_double);
                list_double.Add(doubleBox);
            }
            else
            {
               box = new Box<string>(input);
               list_string.Add(box);
            }
        }
        string input_text= Console.ReadLine();
        int sumElement = 0;
        if (double.TryParse(input_text, out double intList))
        { 
            sumElement = doubleBox.ComparingElements(list_double, intList);
        }
        else {
            sumElement = box.ComparingElements(list_string, input_text);
        }
        Console.WriteLine(sumElement);
    }
}