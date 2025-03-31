using System;
using System.Collections.Generic;

public static class GenericMethods
{
    // swap method
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    // display and reset method
    public static void DisplayAndReset<T1, T2>(ref T1 param1, ref T2 param2)
    {
        Console.WriteLine($"Type 1: {param1.GetType().Name}, Value: {param1}");
        Console.WriteLine($"Type 2: {param2.GetType().Name}, Value: {param2}");
        param1 = default;
        param2 = default;
    }

    // create instance method
    public static T CreateInstance<T>() where T : new()
    {
        return new T();
    }

    // compare method
    public static T GetMax<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    // sort params method
    public static List<T> SortParams<T>(params T[] items) where T : IComparable<T>
    {
        var list = new List<T>(items);
        list.Sort();
        return list;
    }

    // create dictionary method
    public static Dictionary<TKey, TValue> CreateDictionary<TKey, TValue>(TKey key, TValue value) 
        where TKey : struct, IComparable<TKey>
        where TValue : class
    {
        var dict = new Dictionary<TKey, TValue>();
        dict.Add(key, value);
        return dict;
    }

    // display dictionary method
    public static void DisplayDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
    {
        foreach (var kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }

    // return collection based on count method
    public static IEnumerable<T> ReturnCollection<T>(params T[] items)
    {
        if (items.Length < 3)
            return new Queue<T>(items);
        return new Stack<T>(items);
    }
}