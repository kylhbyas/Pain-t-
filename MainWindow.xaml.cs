using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pain_t_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// Kyle Byassee
    /// 2023-02-23
    /// 
    /// This program is a paint application. A new program entry point (Class1.main) was also implemented.
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.Strokes.Clear();
        }
        private void Pen_Size_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // DrawingAttrubutes.MinWidth does not start at zero
            if (Pen_Size_Slider.Value >= DrawingAttributes.MinWidth)
            {
                // Default value
                Pen_Size_Slider.Minimum = 2.0031496062992127;
                //Pen_Size_Slider.Minimum = DrawingAttributes.MinWidth + 0.1;
                My_Canvas.DefaultDrawingAttributes.Width = Pen_Size_Slider.Value;
                My_Canvas.DefaultDrawingAttributes.Height = My_Canvas.DefaultDrawingAttributes.Width;
            }
        }

        private void Black_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void Gray_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Gray;
        }

        private void Dark_Red_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.DarkRed;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Orange_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Orange;
        }

        private void Yellow_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void Green_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Turquoise_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Turquoise;
        }

        private void Indego_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Indigo;
        }

        private void Purple_Button_Click(object sender, RoutedEventArgs e)
        {
            My_Canvas.DefaultDrawingAttributes.Color = Colors.Purple;
        }
    }
}
