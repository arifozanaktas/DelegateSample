namespace DelegateSample;

internal class Program
{
    static void Main(string[] args)
    {

        
        var mathExam = new MathExam();
        var result = mathExam.MathExams(10, 10, (a, b) => a * b + 100);
        Console.WriteLine(result);


    }
}
