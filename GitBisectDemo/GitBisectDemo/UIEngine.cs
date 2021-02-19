using System;
using System.Collections.Generic;
using System.Text;

namespace GitBisectDemo
{
    public class UIEngine : IUIEngine
    {
        public int GetIntValue(string whatValue)
        {
            Console.WriteLine($"Enter the values for {whatValue}: ");
            string answer = Console.ReadLine();
            int value = int.Parse(answer);

            return value;
        }

        public void OutputValue(string value)
        {
            Console.WriteLine(value);
        }
    }
}
