namespace ClassLibrary1
{
    internal interface ICalculator
    {
        string Operation { get; }

        int Calculate(int num);
    }
}