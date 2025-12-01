namespace Task01;

public class Rectangle
{
    private double length;
    private double breadth;
    
    public double Length
    {
        get => length;
        set => length = value;
    }
    
    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    public double GetArea() => length * breadth;

    public string ShowDetails =>  $"Length: {length}, Breadth: {breadth}";
    
    public double CalculatePerimeter => 2*(length + breadth);
    
}