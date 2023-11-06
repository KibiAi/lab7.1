using lab7._1;

class Program
{
    static void Main()
    {
        Calculator<int> intCalculator = new Calculator<int>();

        int result1 = intCalculator.PerformOperation(3, 3, intCalculator.Add);
        int result2 = intCalculator.PerformOperation(2, 1, intCalculator.Subtract);
        int result3 = intCalculator.PerformOperation(5, 6, intCalculator.Multiply);
        int result4 = intCalculator.PerformOperation(6, 2, intCalculator.Divide);

        Console.WriteLine($"Int Results: Add({result1}), Subtract({result2}), Multiply({result3}), Divide({result4})");

        Calculator<double> doubleCalculator = new Calculator<double>();

        double result5 = doubleCalculator.PerformOperation(5.1, 3.2, doubleCalculator.Add);
        double result6 = doubleCalculator.PerformOperation(6.3, 2.3, doubleCalculator.Subtract);
        double result7 = doubleCalculator.PerformOperation(5.5, 3.2, doubleCalculator.Multiply);
        double result8 = doubleCalculator.PerformOperation(6.0, 2.5, doubleCalculator.Divide);

        Console.WriteLine($"Double Results: Add({result5}), Subtract({result6}), Multiply({result7}), Divide({result8})");
    }
}