
class Circle : Widget
{
    private double _radius;
    protected double Radius
    {
        get { return _radius; }
        init { _radius = value; }
    }

    protected override string Name => "Circle";

    public Circle(int x, int y, double radius) : base(x, y)
    {
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Circle (x:{X}, y:{Y}) {Size()}");
    }

    protected override string Size()
    {
        return $"Area={Math.PI*Radius}";
    }
}

