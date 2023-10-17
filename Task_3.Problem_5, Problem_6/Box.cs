class Box <T>{
    public T value { set; get; }
    private int n = 0;
    public Box(T value) {
        this.value = value;
    }
    public int ComparingElements(List<Box<T>> list, T value) {
        foreach (Box<T> item in list) {
            if (Comparer<T>.Default.Compare(item.value, value) > 0) {
                n++;
            }
        }
        return n;
    }
}