internal class Program
{
    private static void Main(string[] args)
    {
        Custom_List<string> string_list = new Custom_List<string>();
        Custom_List<int> int_List = new Custom_List<int>();

        while (true) {
            string[] input_n = Console.ReadLine().Split(' ');
            int number = 0;
            if (input_n[0].ToUpper() == "END"){
                break;
            }
            switch(input_n[0].ToLower()) {
                case "add":
                    string element_string = input_n[1];
                    int element_int;
                    if (int.TryParse(input_n[1], out element_int))
                    {
                        number = 1;
                        int_List.Add(element_int);
                    }
                    else {
                        string_list.Add(element_string);
                    }
                    break;
                case "remove":
                    int indexToRemove = int.Parse(input_n[1]);
                    switch (number) {
                        case 0:
                            string_list.Remove(indexToRemove);
                            break;
                        case 1:
                            int_List.Remove(indexToRemove);
                            break;
                    }
                    break;
                case "contains":
                    if (number == 0) {
                        Console.WriteLine(string_list.Contains(input_n[1])); 
                    }
                    else {
                        int indexContains = int.Parse(input_n[1]);
                        Console.WriteLine(int_List.Contains(indexContains)); }
                    break;
                case "swap":
                    if (number == 0){string_list.Swap(int.Parse(input_n[1]), int.Parse(input_n[2]));}
                    else{int_List.Swap(int.Parse(input_n[1]), int.Parse(input_n[2]));}
                    break;
                case "greater":
                    if (number == 0) { Console.WriteLine(string_list.CountGreaterThan(input_n[1])); }
                    else { Console.WriteLine(int_List.CountGreaterThan(int.Parse(input_n[1]))); }
                    break;
                case "max":
                    if (number == 0) { Console.WriteLine( string_list.Max()); }
                    else { Console.WriteLine(int_List.Max()); }
                    break;
                case "min":
                    if (number == 0) { Console.WriteLine(string_list.Min()); }
                    else { Console.WriteLine(int_List.Min()); }
                    break;
                case "print":
                    if (number == 0) { string_list.Print(); }
                    else { int_List.Print(); }
                    break;
                case "sort":
                    if (number == 0) { Sorter.Sort(string_list); }
                    else { Sorter.Sort(int_List); }
                    break;
            }
        }
    }
}