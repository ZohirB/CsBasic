using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Test;

public class GenericsTest
{
    public static void testGenerics()
    {
        testingListOfPeople();
        //testingListOfInt();
    }

    public static void testingListOfPeople()
    {
        var people = new Any<Person>();
        people.Add(new Person("Ali","A"));
        people.Add(new Person("Zohir","b"));
        people.DisplayList();

        Console.WriteLine($"Lenght: {people.Count}");
        Console.WriteLine($"Empty: {people.IsEmpty}");
    }
/*
    public static void testingListOfInt()
    {
        var list = new Any<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.DisplayList();
        list.RemoveAt(1);
        list.DisplayList();
        //Print("test");
        //Print(1);
        Console.WriteLine($"Lenght: {list.Count}");
        Console.WriteLine($"Empty: {list.IsEmpty}");
    }
*/
    static void Print<T>(T value)
    {
        Console.WriteLine($"Datatype: : {typeof(T)}");
        Console.WriteLine($"Value: : {value}");
    }

    class Any<T> where T : class
    {
        private T[] _items;

        public void Add(T item)
        {
            if (_items is null)
            {
                _items = new T[] { item };
            }
            else
            {
                var length = _items.Length;
                var dest = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    dest[i] = _items[i];
                }

                dest[dest.Length - 1] = item;
                _items = dest;
            }
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position > _items.Length-1)
                return;
            var index = 0;
            var dest = new T[_items.Length - 1];
            for (int i = 0; i < _items.Length; i++)
            {
                if (position == i)
                    continue;
                dest[index++] = _items[i];
            }
            _items = dest;
        }

        public bool IsEmpty => _items is null || _items.Length == 0;
        public int Count => _items is null ? 0 : _items.Length;

        public void DisplayList()
        {
            Console.Write("[");
            for (int i = 0; i < _items.Length; i++)
            {
               Console.Write(_items[i]);
               if (i < _items.Length - 1)
               {
                   Console.Write(",");
               }
            }
            Console.WriteLine("]");
        }
    }
    
    class Person
    {
        private string _fname;
        private string _lname;

        public Person(string fname, string lname)
        {
            _fname = fname;
            _lname = lname;
        }
        public override string ToString()
        {
            return $"{_fname} {_lname}";
        }
    }
    
}