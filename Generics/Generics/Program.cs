using System.Collections;
using System.ComponentModel.DataAnnotations;

IEnumerable<string> strings = ["Prvni string", "Druhy string"];
IEnumerable<int> integers = [5, 10, 15];
IEnumerable<object> objects = [10, "abcdef", -15, true];
WriteToConsole(strings);
WriteIntToConsole(integers);
GenericWriteToConsole(strings);
GenericWriteToConsole(integers);

void WriteToConsole(IEnumerable<string> strings)
{
    foreach (var s in strings)
    {
        Console.Write(s + " ");
    }
    Console.WriteLine();
}

void WriteIntToConsole(IEnumerable<int> integers)
{
    foreach (var i in integers)
    {
        Console.Write(i + ",");
    }
    Console.WriteLine();

}


// Breakout room 1
// Implementujte generickou metodu Max<T>, která porovná dva parametry typu IComparable<T> a vrátí jejich maximum.
Max(1, 2);
Max<int>(-5, 3);
T Max<T>(T first, T second) where T : IComparable<T>
{
    var result = first.CompareTo(second);
    if (result >= 0)
    {
        Console.WriteLine(first);
        return first;
    }
    else
    {
        Console.WriteLine(second);
        return second;
    }
}
// Implementujte generickou metodu Max<T>, která přijme IEnumerable<IComparable<T>> a vrátí jejich maximum.

MaxFromEnumerable<int>([-5, 3, 40]);
void MaxFromEnumerable<T>(IEnumerable<IComparable<T>> comparables)
{
    //Console.WriteLine(comparables.Max());
    foreach (var comparable in comparables)
    {

    }
}
// Implementujte generickou metodu IsDistinct<T>, která přijme IEnumerable<IComparable<T>> a vrátí true, pokud neobsahuje duplikáty.



//S Generikou

void GenericWriteToConsole<T>(IEnumerable<T> list) where T : IComparable<T>
{
    foreach (var s in list)
    {
        Console.Write(s.ToString() + ", ");
        //s.CompareTo();
    }
    Console.WriteLine();
}
