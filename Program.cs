// See https://aka.ms/new-console-template for more information

Canvas canvas = new Canvas();

while (true)
{
    Console.WriteLine("Choose a widget to add (1: Square, 2: Rectangle,3: Circle,4: Ellipse, 5: TextBox, 0: Exit):");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddSquare(canvas);
            break;
        case "2":
            AddRectangle(canvas);
            break;
        case "3":
            AddCircle(canvas);
            break;
        case "4":
            AddEllipse(canvas);
            break;
        case "5":
            AddTextbox(canvas);
            break;
        case "0":
            //canvas.DrawWidgets();
            Console.WriteLine("Exited.");

            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
void AddSquare(Canvas canvas)
{
    int x, y, height, width;

    // Get X coordinate
    Console.WriteLine("Enter X coordinate:");
    while (!int.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for X coordinate:");
    }

    // Get Y coordinate
    Console.WriteLine("Enter Y coordinate:");
    while (!int.TryParse(Console.ReadLine(), out y))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for Y coordinate:");
    }

    // Get height
    Console.WriteLine("Enter height:");
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for height:");
    }

    // Get width
    Console.WriteLine("Enter width:");
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for width:");
    }

    Square square = new Square(x, y, height, width);
    canvas.AddWidget(square);
    canvas.Render();
}

void AddRectangle(Canvas canvas)
{
    int x, y, height, width;

    // Get X coordinate
    Console.WriteLine("Enter X coordinate:");
    while (!int.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for X coordinate:");
    }

    // Get Y coordinate
    Console.WriteLine("Enter Y coordinate:");
    while (!int.TryParse(Console.ReadLine(), out y))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for Y coordinate:");
    }

    // Get height
    Console.WriteLine("Enter height:");
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for height:");
    }

    // Get width
    Console.WriteLine("Enter width:");
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for width:");
    }

    Rectangle rectangle = new Rectangle(x, y, height, width);
    canvas.AddWidget(rectangle);
    canvas.Render();
}

void AddCircle(Canvas canvas)
{
    int x, y;
    double radius;

    // Get X coordinate
    Console.WriteLine("Enter X coordinate:");
    while (!int.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for X coordinate:");
    }

    // Get Y coordinate
    Console.WriteLine("Enter Y coordinate:");
    while (!int.TryParse(Console.ReadLine(), out y))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for Y coordinate:");
    }

    // Get radius
    Console.WriteLine("Enter radius:");
    while (!double.TryParse(Console.ReadLine(), out radius))
    {
        Console.WriteLine("Invalid input. Please enter a valid double for radius:");
    }

    Circle circle = new Circle(x, y, radius);
    canvas.AddWidget(circle);
    canvas.Render();
}

void AddEllipse(Canvas canvas)
{
    int x, y;
    double axisA, axisB;

    // Get X coordinate
    Console.WriteLine("Enter X coordinate:");
    while (!int.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for X coordinate:");
    }

    // Get Y coordinate
    Console.WriteLine("Enter Y coordinate:");
    while (!int.TryParse(Console.ReadLine(), out y))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for Y coordinate:");
    }

    // Get Axis A
    Console.WriteLine("Enter Axis A:");
    while (!double.TryParse(Console.ReadLine(), out axisA))
    {
        Console.WriteLine("Invalid input. Please enter a valid double for Axis A:");
    }

    // Get Axis B
    Console.WriteLine("Enter Axis B:");
    while (!double.TryParse(Console.ReadLine(), out axisB))
    {
        Console.WriteLine("Invalid input. Please enter a valid double for Axis B:");
    }

    Ellipse ellipse = new Ellipse(x, y, axisA, axisB);
    canvas.AddWidget(ellipse);
    canvas.Render();
}
void AddTextbox(Canvas canvas)
{
    int x, y, height, width;
    string text;
    ConsoleColor backgroundColor;

    // Get X coordinate
    Console.WriteLine("Enter X coordinate:");
    while (!int.TryParse(Console.ReadLine(), out x))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for X coordinate:");
    }

    // Get Y coordinate
    Console.WriteLine("Enter Y coordinate:");
    while (!int.TryParse(Console.ReadLine(), out y))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for Y coordinate:");
    }

    // Get height
    Console.WriteLine("Enter height:");
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for height:");
    }

    // Get width
    Console.WriteLine("Enter width:");
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for width:");
    }

    // Get text
    Console.WriteLine("Enter Text:");
    text = Console.ReadLine();

    // Get background color
    Console.WriteLine("Enter background color (e.g., Red, Green, Yellow):");
    while (!Enum.TryParse(Console.ReadLine(), true, out backgroundColor) || !Enum.IsDefined(typeof(ConsoleColor), backgroundColor))
    {
        Console.WriteLine("Invalid input. Please enter a valid ConsoleColor:");
    }

    Textbox textbox = new Textbox(x, y, height, width, text, backgroundColor);
    canvas.AddWidget(textbox);
    canvas.Render();
}







