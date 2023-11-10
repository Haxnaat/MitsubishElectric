# Mitsubishi Electric Console App

## Overview

This console application is a simple drawing app that allows you to render different shapes known as widgets on a canvas. The system comprises various widgets, each capable of rendering its unique features.

## Widgets

### Square

- Positioned using X and Y coordinates.
- Has its own size: height multiplied by width.
- Renders size and X/Y positions via its Draw method.

### Rectangle

- Positioned using X and Y coordinates.
- Has its own size: height multiplied by width.
- Has height and width attributes unique to rectangles.
- Renders size, height, width, and X/Y positions via its Draw method.

### Circle

- Positioned using X and Y coordinates.
- Has its own size, which is the area of the circle (Area = pi * radius squared).
- Renders size and X/Y position via its Draw method.

### Ellipse

- Positioned using X and Y coordinates.
- Has its own size, which is the area of the ellipse (Area = axis a * axis b * pi).
- Has horizontal and vertical diameters unique to ellipses.
- Renders size, horizontal diameter, vertical diameter, and X/Y positions via its Draw method.

### Text Box

- Derives from rectangle.
- Has a background color.
- Provides a Text attribute allowing string data to be set as the rendered content of the rectangle.
- Renders size, height, width, X/Y positions, background color, and text content via its Draw method.
- If no text content has been supplied, the background color defaults to red when the Draw method provides background color as part of its output.

## Canvas

The application provides a Canvas for displaying the rendered content of widgets, with the ability to add multiple widgets to the canvas so each can be rendered according to the unique rendering of each widget.

## Usage

1. Clone the repository: `git clone https://github.com/Haxnaat/MitsubishElectric.git`
2. Open the project in Visual Studio or your preferred IDE.
3. Build and run the application.

## Contributing

If you would like to contribute to this project, please follow the standard Git workflow:

1. Fork the repository.
2. Create a new branch for your feature or bug fix: `git checkout -b feature-name`.
3. Make your changes and commit them: `git commit -m "Your descriptive message"`.
4. Push your changes to your fork: `git push origin feature-name`.
5. Create a pull request on GitHub.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

