namespace CustomList;

public class MyCustomList<T>
{
    T[] array;
    public MyCustomList()
    {
        array = [];
    }

    public void Add(T entity)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = entity;
    }

    public T this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            if (index < 0)
                throw new ArgumentException();
            if (index < array.Length)
            {
                array[index] = value;
            }
            else
                throw new IndexOutOfRangeException();
        }
    }

    public bool Remove(T entity)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(entity))
            {
                count++;
            }
        }

        T[] newArr = new T[array.Length - count];
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (!entity.Equals(array[i]))
            {
                newArr[counter] = array[i];
                counter++;
            }
        }
        array = newArr;
        return false;
    }

    public void Print()
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    public void Select()
    {
        var props = typeof(T).GetProperties();
        foreach (var item in props)
        {
            Console.WriteLine(item);
        }
    }
    public void Insert(int index, T entity)
    {
        if (index < 0 || index > array.Length)
        {
            throw new IndexOutOfRangeException();
        }

        T[] newArray = new T[array.Length + 1];
        int counter = 0;

        for (int i = 0; i < newArray.Length; i++)
        {
            if (i != index)
            {
                newArray[i] = array[counter];
                counter++;
            }
        }
        newArray[index] = entity;

        array = newArray;
    }
    public void AddRange(T[] values)
    {
        int oldLength = array.Length; //4
        Array.Resize(ref array, array.Length + values.Length); //6

        for (int i = 0; i < values.Length; i++)
        {
            array[i + oldLength] = values[i];
        }
    }
}
