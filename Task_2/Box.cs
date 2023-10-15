class Box <T>{
    public T value { set; get; }
    public Box(T value) {
        this.value = value;
    }
    public override string ToString()
    {
        string name = value.GetType().FullName; //отримання повного ім'я типу
        return $"{name}: {value}";
    }
}