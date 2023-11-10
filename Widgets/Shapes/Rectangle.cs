
class Rectangle : Widget
{
    private int _height;
    protected int Height
    {
        get { return _height; }
        init { _height = value; }
    }
    private int _width;
    protected int Width
    {
        get { return _width; }
        init { _width = value; }
    }

    protected override string Name => "Rectangle";

    public Rectangle(int x, int y, int height, int width) : base(x, y)
    {
        Height = height;
        Width = width;
    }

    public override void Draw()
    {
        Console.WriteLine($"Rectangle (x:{X}, y:{Y}) {Size()}");
    }

    protected override string Size()
    {
        if (Height == Width)
            return $"Height and Width cannot be similar as it became Square";

        return $"height={Height} width={Width} size={Height*Width}";
    }
}

