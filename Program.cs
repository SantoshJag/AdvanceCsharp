// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> integerList = new List<int> { 1, 4, 6, 9, 89, -3, -1, -9, -4, 56, 43 };
IntegerClass ic = new IntegerClass();
var sum = ic.CalculateSum(integerList);
Console.WriteLine($"Sum of a integer list is => {sum}");

Console.ReadKey();



public class IntegerClass
{
    public int CalculateSum(List<int> integerList)
    {
        int sum = 0;
        foreach (int a in integerList)
        {
            sum += a;
        }
        return sum;
    }
}