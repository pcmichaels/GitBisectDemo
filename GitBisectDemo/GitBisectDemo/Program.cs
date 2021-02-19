using System;

namespace GitBisectDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculationEngine = new CalculationEngine();
            var uiEngine = new UIEngine();

            RunCalculation(calculationEngine, uiEngine);
        }

        public static void RunCalculation(CalculationEngine calculationEngine, IUIEngine uiEngine)
        {
            int x = uiEngine.GetIntValue("x") + 1;
            int y = uiEngine.GetIntValue("y");

            float result = calculationEngine.DoCalculation(x, y);

            uiEngine.OutputValue($"Answer is {result}");
        }
    }
}
