using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Painter;
  
public partial class MainWindow : Window
{
    private int _diameter = (int)Sizes.MEDIUM; // set diameter of circle
    private Brush _brushColor = Brushes.Black; // set the drawing color
    private bool _shouldErase = false; // specify whether to erase
    private bool _shouldPaint = false; // specify whether to paint

    private enum Sizes // constants for diameter of the circle
    {
        SMALL = 4,
        MEDIUM = 8,
        LARGE = 10
    }

    public MainWindow()
    {
        InitializeComponent();
    }

    private void PaintCircle(Brush circleColor, Point position)
    {
        Ellipse newEllipse = new()
        {
            Fill = circleColor, // set Ellipse's color
            Width = _diameter, // set its horizontal diameter
            Height = _diameter // set its vertical diameter 
        };

        // set the Ellipse's position            
        Canvas.SetTop(newEllipse, position.Y); 
        Canvas.SetLeft(newEllipse, position.X);
        PaintCanvas.Children.Add(newEllipse);
    }

    // handles paintCanvas's MouseLeftButtonDown event
    private void PaintCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        _shouldPaint = true; // OK to draw on the Canvas
    }

    // handles paintCanvas's MouseLeftButtonUp event
    private void PaintCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        _shouldPaint = false; // do not draw on the Canvas
    }

    // handles paintCanvas's MouseRightButtonDown event
    private void PaintCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        _shouldErase = true; // OK to erase the Canvas
    }

    // handles paintCanvas's MouseRightButtonUp event
    private void PaintCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
    {
        _shouldErase = false; // do not erase the Canvas
    }

    // handles paintCanvas's MouseMove event
    private void PaintCanvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (_shouldPaint)
        {
            // draw a circle of selected color at current mouse position
            Point mousePosition = e.GetPosition(PaintCanvas);
            PaintCircle(_brushColor, mousePosition);
        }
        else if (_shouldErase)
        {
            // erase by drawing circles of the Canvas's background color
            Point mousePosition = e.GetPosition(PaintCanvas);
            PaintCircle(PaintCanvas.Background, mousePosition);
        }
    }

    // handles Red RadioButton's Checked event
    private void RedRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _brushColor = Brushes.Red;
    }

    // handles Blue RadioButton's Checked event
    private void BlueRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _brushColor = Brushes.Blue;
    }

    // handles Green RadioButton's Checked event
    private void GreenRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _brushColor = Brushes.Green;
    }

    // handles Black RadioButton's Checked event
    private void BlackRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _brushColor = Brushes.Black;
    }

    // handles Small RadioButton's Checked event
    private void SmallRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _diameter = (int)Sizes.SMALL;
    }

    // handles Medium RadioButton's Checked event
    private void MediumRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _diameter = (int)Sizes.MEDIUM;
    }

    // handles Large RadioButton's Checked event
    private void LargeRadioButton_Checked(object sender, RoutedEventArgs e)
    {
        _diameter = (int)Sizes.LARGE;
    }

    // handles Undo Button's Click event
    private void UndoButton_Click(object sender, RoutedEventArgs e)
    {
        int count = PaintCanvas.Children.Count;

        // if there are any shapes on Canvas remove the last one added
        if (count > 0)
        {
            PaintCanvas.Children.RemoveAt(count - 1);
        }
    }

    // handles Clear Button's Click event
    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        PaintCanvas.Children.Clear(); // clear the canvas
    }
}