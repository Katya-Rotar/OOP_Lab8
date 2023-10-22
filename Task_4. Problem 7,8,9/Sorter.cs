class Sorter{
    public static void Sort<T>(Custom_List<T> customList) where T : IComparable<T>
    {
        customList.Sort();
    }
}
