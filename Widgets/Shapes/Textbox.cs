
class Textbox : Rectangle
{
    private ConsoleColor _backgroundColor;
    protected ConsoleColor BackgroundColor
    {
        get { return _backgroundColor; }
        init { _backgroundColor = value; }
    }
    private string _text;
    protected string Text
    {
        get { return _text; }
        init { _text = value; }
    }
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

    protected override string Name => "Textbox";

    public Textbox(int x, int y, int height, int width, string text, ConsoleColor bgColor) : base(x, y, height, width)
    {
        Text = text;
        Height = height;
        Width = width;
        if (string.IsNullOrEmpty(Text))
            BackgroundColor = ConsoleColor.Red;
        else
            BackgroundColor = bgColor;
    }

    public override void Draw()
    {
        Console.WriteLine($"Textbox (x:{X}, y:{Y}) {Size()}");
    }

    protected override string Size()
    {
        return $"Textbox Height={Height} Width={Width} BackgroundColor={BackgroundColor} Text={Text}";
    }
}

