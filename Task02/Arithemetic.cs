namespace Task02;

public delegate int Calculate(int a, int b);

public class Arithmetic
{
    public int Add(int a, int b) => a + b;
    
    public int Subtract(int a, int b) => a - b;
}

