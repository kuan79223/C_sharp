using System;

// 基地台
delegate int MathOperation(int x, int y);

class DelegateExample
{
    static int Addition(int x, int y)
    {
        return x + y;
    }
    static int Subtraction(int x, int y)
    {
        return x - y;
    }
    static void Main(string[] args)
    {
        // 在 main 創建兩個委派(委派的事件) 
        MathOperation additionDelegate = new MathOperation(Addition);
        MathOperation subtractionDelegate = new MathOperation(Subtraction);

        Console.WriteLine("Addition: " + additionDelegate(2, 3));
        Console.WriteLine("Subtraction: " + subtractionDelegate(2, 3));
    }
}



