using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
                        DrawGreenLines(foxDraw);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 10, 100, 10);

            var startPoint = new Point(0, 20);
            var endPoint = new Point(100, 20);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}