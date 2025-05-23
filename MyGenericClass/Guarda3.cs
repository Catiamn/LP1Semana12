using System;

namespace MyGenericClass
{
    public class Guarda3<T>
{
    private T[] items = new T[3];

    public T GetItem(int index)
    {
         if (index < 0 || index > 2) throw new IndexOutOfRangeException();
        return items[index];
    }

    public void SetItem(int index, T value)
    {
         if (index < 0 || index > 2) throw new IndexOutOfRangeException();
        items[index] = value;
    }
}
}
