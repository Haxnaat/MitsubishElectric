abstract class Widget
{
    protected abstract string Name { get; }
    protected int X { get; init; }
    protected int Y { get; init; }

    public Widget(int x, int y)
    {
        X = x; Y = y;
    }

    protected abstract string Size();

    public abstract void Draw();
}

