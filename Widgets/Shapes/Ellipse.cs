
class Ellipse : Widget
{
    private double _axisA;
    protected double AxisA
    {
        get { return _axisA; }
        init { _axisA = value; }
    }
    private double _axisB;
    protected double AxisB
    {
        get { return _axisB; }
        init { _axisB = value; }
    }

    protected override string Name => "Ellipse";

    public Ellipse(int x, int y, double axisa, double axisb) : base(x, y)
    {
        AxisA = axisa;
        AxisB = axisb;
    }

    public override void Draw()
    {
        Console.WriteLine($"Ellipse (x:{X}, y:{Y}) {Size()}");
    }

    protected override string Size()
    {
        return $"AxisA={AxisA} AxisB={AxisB} Area={Math.PI * AxisA *AxisB}";
    }
}

