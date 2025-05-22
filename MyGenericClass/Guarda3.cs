using System;

namespace MyGenericClass
{
    public class Guarda3<T>
{
    private T[] items = new T[3];

    public T GetItem(int index)
    {
        return items[index];
    }

    public void SetItem(int index, T value)
    {
        items[index] = value;
    }
}
}
