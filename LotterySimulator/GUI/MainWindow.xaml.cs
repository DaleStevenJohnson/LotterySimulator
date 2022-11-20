using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GUI.Shapes;
using GUI.ViewModel;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
            //var window = (Window)this.FindName("mw");
            //this.Width = 1080;
            //this.Height = 1080;
            //var houseSize = 200;
            //var border = 10;
            //var rows = this.Height / (houseSize);
            //var columns = this.Width / (houseSize);
            //var canvas = (Canvas)this.FindName("canvas");
            //canvas.Width = this.Width;
            //canvas.Height = this.Height;
            //canvas.Background = new SolidColorBrush(Colors.DimGray);
            //var houses = new List<House>();
            //for (int x = 0; x < columns; x++)
            //{
            //    for (int y = 0; y < rows; y++)
            //    {
            //        var h = new House(x * houseSize, y * houseSize, houseSize, houseSize);
            //        houses.Add(h);
            //        canvas.Children.Add(h.Shape);
            //    }
                
            //}
            
        }
    }
}
