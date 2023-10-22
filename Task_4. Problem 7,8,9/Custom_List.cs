using System.Collections;

class Custom_List<T> : IEnumerable<T>
    where T : IComparable<T> //тип T повинен реалізовувати інтерфейс IComparable<T>
{
    public List<T> elements;
    public Custom_List() {
        elements = new List<T>();
    }
    public void Add(T element) {
        elements.Add(element);
    }
    public T Remove(int index) {
        elements.RemoveAt(index);
        return elements[index];
    }
    public bool Contains(T element) {
        return elements.Contains(element);
    }
    public void Swap(int index1, int index2) {
        T index1_element = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = index1_element;
    }
    public int CountGreaterThan(T element) {
        int n = 0;
        foreach(T item in elements)
        {
            if (item.CompareTo(element) > 0) { //повертає число для порівняння якщо < 0 то знаходиться перед об'єктом = 0 рівні, знаходиться після об'єкта > 0
                n++;
            }
        }
        return n;
    }
    public T Max() {
        T max = elements[0];
        foreach(T item in elements)
        {
            if (item.CompareTo(max) > 0) {
                max = item;
            }
        }
        return max;
    }
    public T Min()
    {
        T min = elements[0];
        foreach (T item in elements)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }
        return min;
    }
    public void Print() {
        foreach (T item in elements) {
            Console.WriteLine(item);
        }
    }
    public void Sort()
    {
        elements.Sort();
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T element in elements) {
            yield return element;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
