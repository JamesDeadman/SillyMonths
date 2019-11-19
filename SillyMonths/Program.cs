using System;
using SillyMonthsML.Model;

namespace SillyMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var input = new ModelInput() { Input = i };
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine($"{i} => {result.Prediction}");
            }
        }
    }
}
