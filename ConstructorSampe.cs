using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        public static void Main(string[] args)
        {
            Triangle a = new Triangle(
                InteractiveInput.InputFloat("辺の長さa："),
                InteractiveInput.InputFloat("辺の長さb："),
                InteractiveInput.InputFloat("辺の長さc："));
            Console.WriteLine($"面積は{a.GetSurface()}");
        }
        
    }
}
