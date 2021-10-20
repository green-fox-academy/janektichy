using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Collections.Generic;
using GreenFox;

namespace Av
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            var image = new Avalonia.Controls.Image();
            image.Source = new Avalonia.Media.Imaging.Bitmap(@"front/1 Dog/Walk.png");
            foxDraw.SetBackgroundColor(Colors.Green);
            foxDraw.AddImage(image, 50, 100);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
