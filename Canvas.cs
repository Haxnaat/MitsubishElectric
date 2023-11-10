
class Canvas
{
    private readonly List<Widget> _widgets;

    public Canvas()
    {
        _widgets= new List<Widget>();
    }

    public void AddWidget(Widget widget)//Method to add Widgets to Canvas
    {
        _widgets.Add(widget);
    }

    public void Render() //Method for rendering of widget
    {
        foreach (Widget widget in _widgets)
            widget.Draw();
    }
}

