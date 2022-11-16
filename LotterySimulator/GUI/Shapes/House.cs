using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GUI.Shapes
{
    public class House
    {
        public House(double x, double y, double w, double h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
            Colour = GetRandomColour();
            Shape = Draw();
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        private Color Colour { get; set; }
        public Rectangle Shape  { get; set; }
        private Rectangle Draw()
        {
            var rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.White);
            rect.StrokeThickness = 0;
            rect.Fill = new SolidColorBrush(Colour);
            rect.Width = W;
            rect.Height = H;
            Canvas.SetLeft(rect, X);
            Canvas.SetTop(rect, Y);
            return rect;
        }
        private Color GetRandomColour()
        {
            var r = new Random();
            var n = r.Next(10);
            switch (n)
            {
                case 0: return Colors.MediumSpringGreen;
                case 1: return Colors.AliceBlue;
                case 2: return Colors.Aqua;
                case 3: return Colors.BlueViolet;
                case 4: return Colors.CornflowerBlue;
                case 5: return Colors.DarkGreen;
                case 6: return Colors.DarkSlateGray;
                case 7: return Colors.Firebrick;
                case 8: return Colors.Goldenrod;
                case 9: return Colors.IndianRed;
                case 10: return Colors.LavenderBlush;
                default:
                    return Colors.Black;
            }
        }
    }
}
