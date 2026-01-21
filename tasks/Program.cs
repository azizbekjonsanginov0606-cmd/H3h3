// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var numbers = new List<int>() { 1, 2, 3, 2, 5, 2 };

var numbersA = new List<int>() { 1, 2, 3, 4, 5 };
var numbersB = new List<int>() { 2, 3, 5 };

var letters = new List<string>() { "A", "B", "C", "D" };

var values = new List<int>() { 10, 20, 30, 40, 50 };

var mixedNumbers = new List<int>() { 5, 1, 4, 2, 3 };

var clearList = new List<int>() { 1, 2, 3 };

var minMaxList = new List<int>() { 12, 3, 45, 7, 19 };

var conditionList = new List<int>() { 1, 2, 3, 4, 5, 6 };

var shuffleList = new List<int>() { 1, 2, 3, 4, 5 };

Console.WriteLine("task1");
Console.WriteLine();
var t1 = numbers.LastIndexOf(2);
Console.WriteLine("Natija = " + t1);
Console.WriteLine("-----------------------------");
Console.WriteLine("task2");
Console.WriteLine();
bool t2 = numbersB.All(x => numbersA.Contains(x));
Console.WriteLine("Natija = " + t2);
Console.WriteLine("-----------------------------");
Console.WriteLine("task3");
Console.WriteLine();
letters.Reverse();
Console.Write("Natija = [ ");
foreach (var s in letters)
{
    System.Console.Write(s + " ");
}
Console.WriteLine("]");
Console.WriteLine("-----------------------------");
// Console.WriteLine("task4");
// Console.WriteLine();
// if (clearList.Count() > 0)
// {
//    Console.WriteLine("Before clear: False");
// }
// else
// {
//    Console.WriteLine("After clear: True");
// }
// clearList.Clear();
// if (clearList.Count() > 0)
// {
//    Console.WriteLine("Before clear: False");
// }
// else
// {
//     Console.WriteLine("After clear: True");
// }
Console.WriteLine("-----------------------------");
Console.WriteLine("task5");
Console.WriteLine();
 var sublist = values.GetRange(1,3);
Console.Write("Natija = [ ");
foreach(int s in sublist)
{
    System.Console.Write(s + ", ");
}
Console.WriteLine("]");
Console.WriteLine("-----------------------------");
Console.WriteLine("task6");
Console.WriteLine();
var sortby = mixedNumbers.OrderBy(num => num);
Console.Write("Natija = [ ");
foreach (int s in sortby)
{
    Console.Write(s + ", ");
}
Console.WriteLine("]");

var desby = mixedNumbers.OrderByDescending(num => num);
Console.Write("Natija = [ ");
foreach (int s in desby)
{
    Console.Write(s + ", ");
}
Console.WriteLine("]");
Console.WriteLine("-----------------------------");
Console.WriteLine("task7");
Console.WriteLine();
System.Console.WriteLine($"Before: {clearList.Count()}");
clearList.Clear();
System.Console.WriteLine($"After: {clearList.Count()}");
Console.WriteLine("-----------------------------");
Console.WriteLine("task8");
Console.WriteLine();
int min = minMaxList.Min();
System.Console.WriteLine($"Min: {min}");
int max = minMaxList.Max();
System.Console.WriteLine($"Max: {max}");
Console.WriteLine("-----------------------------");
Console.WriteLine("task9");
Console.WriteLine();
conditionList.RemoveAll(num => num % 2 == 0);
Console.Write("Natija = [ ");
foreach (int s in conditionList)
{
    Console.Write(s + ", ");
}
Console.WriteLine("]");
Console.WriteLine("-----------------------------");
Console.WriteLine("task10");
Console.WriteLine();
Random random = new();
var newr = shuffleList.OrderBy(num => random.Next());
Console.Write("Natija = [ ");
foreach (int s in newr)
{
    Console.Write(s + ", ");
}
Console.WriteLine("]");
Console.WriteLine("-----------------------------");