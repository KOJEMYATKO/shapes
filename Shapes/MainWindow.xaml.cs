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
using shapeslib;

namespace Shapes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string angleorsidetext = "Угол";
        public MainWindow()
        {
            InitializeComponent();
            // MessageBox.Show(Class1.SUM2(12, 23, 12).ToString());
            sideAtxb.Text = "сторона А";
            sideBtxb.Text = "сторона B";
            sideCtxb.Text = angleorsidetext;
            RectangleA.Text = "сторона А";
            RectangleB.Text = "сторона B";
            radius.Text = "радиус";


        }
        #region triangle
        private void sideAtxb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sideAtxb.Text == "сторона А")
            {
                sideAtxb.Text = "";
            }
        }

        private void sideAtxb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sideAtxb.Text))
                sideAtxb.Text = "сторона А";
        }

        private void sideBtxb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sideBtxb.Text == "сторона B")
            {
                sideBtxb.Text = "";
            }
        }

        private void sideBtxb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sideBtxb.Text))
                sideBtxb.Text = "сторона B";
        }

        private void sideCtxb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sideCtxb.Text == angleorsidetext)
            {
                sideCtxb.Text = "";
            }
        }

        private void sideCtxb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sideCtxb.Text))
                sideCtxb.Text = angleorsidetext;
        }

        private void angleorsideCB_Click(object sender, RoutedEventArgs e)
        {
            if (angleorsideCB.IsChecked == true)
            {
                angleorsideCB.Content = "по трем сторонам";
                sideCtxb.Text = "сторона C";
                angleorsidetext = sideCtxb.Text;
            }
            else {
                angleorsideCB.Content = "по двум сторонам и углу";
                sideCtxb.Text = "угол";
                angleorsidetext = sideCtxb.Text;
            }
            if(sideCtxb.Text == angleorsidetext)
            {
                sideCtxb.Text = "";
                if (string.IsNullOrWhiteSpace(sideCtxb.Text))
                    sideCtxb.Text = angleorsidetext;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double sideA = Convert.ToDouble(sideAtxb.Text);
            double sideB = Convert.ToDouble(sideBtxb.Text);
            double sideC = Convert.ToDouble(sideCtxb.Text);
            if (angleorsideCB.IsChecked == true)
            {
                double gipot = (Math.Max(Math.Max(sideA, sideB), sideC));
                if (gipot == sideA)
                    if (sideB*sideB + sideC * sideC == gipot * gipot)
                        MessageBox.Show(Class1.triangleSide(sideA, sideB, sideC).ToString() + " - прямоугольный треугольник");
                if (gipot == sideB)
                    if (sideA * sideA + sideC * sideC == gipot * gipot)
                        MessageBox.Show(Class1.triangleSide(sideA, sideB, sideC).ToString() + " - прямоугольный треугольник");
                if (gipot == sideC)
                    if (sideB * sideB + sideA * sideA == gipot * gipot)
                        MessageBox.Show(Class1.triangleSide(sideA, sideB, sideC).ToString() + " - прямоугольный треугольник");
                MessageBox.Show(Class1.triangleSide(sideA, sideB, sideC).ToString());
            }
            else
            {
                MessageBox.Show(Class1.triangleAngle(sideA, sideB, sideC).ToString());
            }
        }
        #endregion
        #region Rectangle

        private void RectangleA_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RectangleA.Text == "сторона А")
            {
                RectangleA.Text = "";
            }
        }

        private void RectangleA_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RectangleA.Text))
                RectangleA.Text = "сторона А";
        }

        private void RectangleB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RectangleB.Text == "сторона B")
            {
                RectangleB.Text = "";
            }
        }

        private void RectangleB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RectangleB.Text))
                RectangleB.Text = "сторона B";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double sideA = Convert.ToDouble(RectangleA.Text);
            double sideB = Convert.ToDouble(RectangleB.Text);
            if(sideA == sideB)
            MessageBox.Show(Class1.Rectangle(sideA, sideB).ToString() + " - прямоугольник является квадратом");
            else
            MessageBox.Show(Class1.Rectangle(sideA, sideB).ToString());
        }


        #endregion
        #region circle
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rad = Convert.ToDouble(radius.Text);
            MessageBox.Show(Class1.Circle(rad).ToString());
        }

        private void radius_GotFocus(object sender, RoutedEventArgs e)
        {
            if (radius.Text == "радиус")
            {
                radius.Text = "";
            }
        }

        private void radius_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radius.Text))
                radius.Text = "радиус";
        }
        #endregion
    }
}
