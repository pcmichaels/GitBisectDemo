using System;

namespace GitBisectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculationEngine = new CalculationEngine();
            var uiEngine = new UIEngine();

            int x = uiEngine.GetIntValue("x");
            int y = uiEngine.GetIntValue("y");

            float result = calculationEngine.DoCalculation(x, y);

            Console.WriteLine($"Answer is {result}");
        }
    }
}
