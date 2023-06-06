using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Size = System.Windows.Size;

namespace Paint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Graphics g;
        //int x = -1;
        //int y = -1;
        //bool moving;
        //System.Drawing.Pen pen;
        //List<System.Drawing.Point> points = new List<System.Drawing.Point>();

        //enum ShapeType { Rectangle, Elipse, Line, Pen };

        //private ShapeType currentShape;
        //System.Drawing.Point start;
        //System.Drawing.Rectangle rectangle;
        //List<Shape> shapes = new List<Shape>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            Canvas canvas = new Canvas();
            save.DefaultExt = ".PNG";
            save.Filter = "Image (.PNG)|*.PNG";
            if (save.ShowDialog() == true)
                SaveImage(canvas, save.FileName);
        }

        public static void SaveImage(Canvas canvas, string fileName)
        {
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)canvas.Width, (int)canvas.Height, 96d, 96d, PixelFormats.Pbgra32);
            canvas.Measure(new Size((int)canvas.Width, (int)canvas.Height));
            canvas.Arrange(new System.Windows.Rect(new Size((int)canvas.Width, (int)canvas.Height)));
            bmp.Render(canvas);
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            using (FileStream file = File.Create(fileName))
            {
                encoder.Save(file);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void Pink_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Pink;
        }

        private void Magenta_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Magenta;
        }

        private void RedBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Red;
        }

        private void GreenBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Green;
        }

        private void BlueBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Blue;
        }

        private void YellowBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Yellow;
        }

        private void BlackBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Black;
        }

        private void PinkBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Pink;
        }

        private void MagentaBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Magenta;
        }

        private void Default_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void DefaultBg_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.White;
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void Rectangle_Click(object sender, RoutedEventArgs e)
        {
            //currentShape = ShapeType.Rectangle;
        }

        private void Ellipse_Click(object sender, RoutedEventArgs e)
        {
            //currentShape = ShapeType.Elipse;
        }

        private void Line_Click(object sender, RoutedEventArgs e)
        {
            //currentShape = ShapeType.Line;
        }

        private void Pen_Click(object sender, RoutedEventArgs e)
        {
            //currentShape = ShapeType.Pen;
        }

        private void Eraser_Click(object sender, RoutedEventArgs e)
        {
            EraserMethod();
        }

        private void EraserMethod()
        {
            if (Holst.EditingMode == InkCanvasEditingMode.Ink)
                Holst.EditingMode = InkCanvasEditingMode.EraseByPoint;
            else
                Holst.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void W45_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 45;
        }

        private void W48_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 48;
        }

        private void W52_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 52;
        }

        private void W59_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 59;
        }

        private void W61_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 61;
        }

        private void W66_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 66;
        }

        private void W5_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 5;
        }

        private void W10_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 10;
        }

        private void W12_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 12;
        }

        private void W16_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 16;
        }

        private void W19_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 19;
        }

        private void W25_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 25;
        }

        private void W36_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 36;
        }

        private void SaveCm_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            Canvas canvas = new Canvas();
            save.DefaultExt = ".PNG";
            save.Filter = "Image (.PNG)|*.PNG";
            if (save.ShowDialog() == true)
                SaveImage(canvas, save.FileName);
        }

        private void ExitCm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeCm_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeCm_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void RedCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void GreenCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void BlueCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void YellowCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void WhiteCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void PinkCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Pink;
        }

        private void MagentaCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Magenta;
        }

        private void DefaultCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void RedBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Red;
        }

        private void GreenBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Green;
        }

        private void BlueBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Blue;
        }

        private void YellowBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Yellow;
        }

        private void BlackBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Black;
        }

        private void PinkBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Pink;
        }

        private void MagentaBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.Magenta    ;
        }

        private void DefaultBgCm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.Background = System.Windows.Media.Brushes.White;
        }

        private void EraserCm_Click(object sender, RoutedEventArgs e)
        {
            EraserMethod();
        }

        private void W5Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 5;
        }

        private void W10Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 10;
        }

        private void W12Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 12;
        }

        private void W16Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 16;
        }

        private void W19Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 19;
        }

        private void W25Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 25;
        }

        private void W36Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 36;
        }

        private void W45Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 45;
        }

        private void W48Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 48;
        }

        private void W52Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 52;
        }

        private void W59Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 59;
        }

        private void W61Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 61;
        }

        private void W66Cm_Click(object sender, RoutedEventArgs e)
        {
            this.Holst.DefaultDrawingAttributes.Width = Width = 66;
        }
    }
}

    //abstract class Shape
    //{
    //    public abstract void Draw(Graphics g);
    //}

    //class Rect : Shape
    //{
    //    public System.Drawing.Brush Brush { get; set; }
    //    public System.Drawing.Rectangle Rectangle { get; set; }
    //    public Rect() { }
    //    public Rect(System.Drawing.Rectangle r, System.Drawing.Color c)
    //    {
    //        Brush = new SolidBrush(c);
    //        Rectangle = r;
    //    }

    //    public override void Draw(Graphics g)
    //    {
    //        g.FillRectangle(Brush, Rectangle);
    //    }
    //}

    //class Elipse : Rect
    //{
    //    public Elipse() { }
    //    public Elipse(System.Drawing.Rectangle r, System.Drawing.Color c) : base(r, c) { }

    //    public override void Draw(Graphics g)
    //    {
    //        g.FillEllipse(Brush, Rectangle);
    //    }
    //}

    //class Line : Shape
    //{
    //    public System.Drawing.Pen Pen { get; set; }
    //    public System.Drawing.Point Start { get; set; }
    //    public System.Drawing.Point End { get; set; }

    //    public Line() { }
    //    public Line(System.Drawing.Color c, System.Drawing.Point s, System.Drawing.Point e)
    //    {
    //        Pen = new System.Drawing.Pen(c);
    //        Start = s;
    //        End = e;
    //    }

    //    public override void Draw(Graphics g)
    //    {
    //        g.DrawLine(Pen, Start, End);
    //    }
    //}
