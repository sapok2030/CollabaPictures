using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
    Console.Write("Введите значениегла: ");
string input = Console.ReadLine();
if (int.TryParse(input, int degree))
{
    var trigValue1 = GetTrigValue("sin", 45);
    var trigValue2 = GetTrigValue(input, degree);

    Calc(trigValue1, trigValue2);
}
else
{
    Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
}

// Add more functionalities
Console.Write("Введите второе значение (для синуса, косинуса, тангенса или котангенса): ");
string trigFuncInput = Console.ReadLine();

if (Enum.TryParse(trigFuncInput, true, out TrigFunction trigFunc))
{
    double trigValue3 = GetTrigValue(trigFuncInput, 0);
    Calc(trigValue2, trigValue3);
}
else
{
    Console.WriteLine("Неверный ввод. Пожалуйста, введите синус, косинус, тангенс или котангенс.");
}
}

// Add an enumeration for trig functions
public enum TrigFunction
{
    Sin,
    Cos,
    Tan,
    Cot
}
